<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCreateSubmissions
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        btnToggleStopwatch = New Button()
        btnSubmit = New Button()
        txtStopwatchTime = New TextBox()
        txtGitHubLink = New TextBox()
        txtPhone = New TextBox()
        txtEmail = New TextBox()
        txtName = New TextBox()
        Label6 = New Label()
        SuspendLayout()
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(96, 243)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 40)
        Label4.TabIndex = 8
        Label4.Text = "Github Link " & vbCrLf & " for Task 2" & vbCrLf
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(114, 116)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 7
        Label3.Text = "Email"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(97, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 6
        Label2.Text = "Phone Num"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(114, 53)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 5
        Label1.Text = "Name"
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.BackColor = Color.Yellow
        btnToggleStopwatch.Location = New Point(96, 306)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(247, 42)
        btnToggleStopwatch.TabIndex = 10
        btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL+T)"
        btnToggleStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.LightBlue
        btnSubmit.Location = New Point(192, 383)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(247, 42)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "SUBMIT (CTRL+S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(349, 314)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(198, 27)
        txtStopwatchTime.TabIndex = 17
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(224, 256)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(323, 27)
        txtGitHubLink.TabIndex = 16
        txtGitHubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(224, 174)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(323, 27)
        txtPhone.TabIndex = 15
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(224, 115)
        txtEmail.Name = "txtEmail"
        txtEmail.RightToLeft = RightToLeft.Yes
        txtEmail.Size = New Size(323, 27)
        txtEmail.TabIndex = 14
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(224, 53)
        txtName.Name = "txtName"
        txtName.Size = New Size(323, 27)
        txtName.TabIndex = 13
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(218, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 12
        ' 
        ' FormCreateSubmission
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(btnSubmit)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "FormCreateSubmission"
        Text = "Mohnish Kamalaksha, Slidely Task 2 - Create Submission"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label6 As Label
End Class
