Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json
Public Class FormCreateSubmissions
    Private stopwatch As New Stopwatch()
    Private updateTimer As Timer
    Private Sub FormCreateSubmission_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        updateTimer = New Timer()
        updateTimer.Interval = 1000 ' Update every second
        AddHandler updateTimer.Tick, AddressOf UpdateStopwatchLabel
    End Sub

    Private Sub FormCreateSubmission_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatch.IsRunning Then
            stopwatch.Stop()
            updateTimer.Stop()
        Else
            stopwatch.Start()
            updateTimer.Start()
        End If
        UpdateStopwatchLabel()
    End Sub

    Private Sub UpdateStopwatchLabel()
        txtStopwatchTime.Text = String.Format("{0:hh\:mm\:ss}", stopwatch.Elapsed)
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Dim submission = New With {
                .name = txtName.Text,
                .email = txtEmail.Text,
                .phone = txtPhone.Text,
                .github_link = txtGitHubLink.Text,
                .stopwatch_time = txtStopwatchTime.Text
            }
            Dim json = JsonConvert.SerializeObject(submission)
            Dim content = New StringContent(json, Encoding.UTF8, "application/json")

            Using client As New HttpClient()
                Dim response = Await client.PostAsync("http://localhost:3000/submit", content)
                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful")
                Else
                    Dim responseContent = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show($"Error submitting form: {response.StatusCode} - {responseContent}")
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"An error occurred: {ex.Message}")
        End Try
    End Sub
End Class
