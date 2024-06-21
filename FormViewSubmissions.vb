Imports System.Net.Http
Imports Newtonsoft.Json

Public Class FormViewSubmissions
    Private currentIndex As Integer = 0
    Private submissions As New List(Of Submission)

    Public Class Submission
        Public Property name As String
        Public Property email As String
        Public Property phone As String
        Public Property github_link As String
        Public Property stopwatch_time As String
    End Class

    Private Async Sub FormViewSubmissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Await LoadSubmissions()
        If submissions.Count > 0 Then
            DisplaySubmission(currentIndex)
        Else
            MessageBox.Show("No submissions available to display.")
        End If
    End Sub

    Private Async Function LoadSubmissions() As Task
        submissions = New List(Of Submission)()

        Using client As New HttpClient()
            Try
                Dim response = Await client.GetAsync("http://localhost:3000/read")

                If response.IsSuccessStatusCode Then
                    Dim json = Await response.Content.ReadAsStringAsync()

                    If Not String.IsNullOrEmpty(json) Then
                        submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(json)

                        If submissions Is Nothing OrElse submissions.Count = 0 Then
                            MessageBox.Show("No submissions loaded.")
                        End If
                    Else
                        MessageBox.Show("Empty response received from server.")
                    End If
                Else
                    MessageBox.Show("Failed to load submissions. Status code: " & response.StatusCode)
                End If
            Catch ex As Exception
                MessageBox.Show("Error loading submissions: " & ex.Message)
            End Try
        End Using
    End Function

    Private Sub DisplaySubmission(index As Integer)
        If index >= 0 AndAlso index < submissions.Count Then
            Dim submission = submissions(index)
            txtName.Text = submission.name
            txtEmail.Text = submission.email
            txtPhone.Text = submission.phone
            txtGitHubLink.Text = submission.github_link
            txtStopwatchTime.Text = submission.stopwatch_time
        Else
            MessageBox.Show("No submissions to display.")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(currentIndex)
        End If
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        ' Optional: Handle any specific logic when phone text changes
    End Sub
End Class

