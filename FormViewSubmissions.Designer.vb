<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormViewsubmissions
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnPrevious = New Button()
        btnNext = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(110, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 0
        Label1.Text = "Name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(95, 142)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 20)
        Label2.TabIndex = 1
        Label2.Text = "Phone Num"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(110, 92)
        Label3.Name = "Label3"
        Label3.Size = New Size(46, 20)
        Label3.TabIndex = 2
        Label3.Text = "Email"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(95, 201)
        Label4.Name = "Label4"
        Label4.Size = New Size(87, 40)
        Label4.TabIndex = 3
        Label4.Text = "Github Link " & vbCrLf & " for Task 2" & vbCrLf
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(95, 275)
        Label5.Name = "Label5"
        Label5.Size = New Size(79, 40)
        Label5.TabIndex = 4
        Label5.Text = "Stopwatch" & vbCrLf & "    time" & vbCrLf
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(226, 53)
        Label6.Name = "Label6"
        Label6.Size = New Size(0, 20)
        Label6.TabIndex = 5
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(232, 40)
        txtName.Name = "txtName"
        txtName.ReadOnly = True
        txtName.Size = New Size(323, 27)
        txtName.TabIndex = 6
        txtName.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtEmail
        ' 
        txtEmail.Location = New Point(232, 92)
        txtEmail.Name = "txtEmail"
        txtEmail.ReadOnly = True
        txtEmail.RightToLeft = RightToLeft.Yes
        txtEmail.Size = New Size(323, 27)
        txtEmail.TabIndex = 7
        txtEmail.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtPhone
        ' 
        txtPhone.Location = New Point(232, 139)
        txtPhone.Name = "txtPhone"
        txtPhone.ReadOnly = True
        txtPhone.Size = New Size(323, 27)
        txtPhone.TabIndex = 8
        txtPhone.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Location = New Point(232, 201)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.ReadOnly = True
        txtGitHubLink.Size = New Size(323, 27)
        txtGitHubLink.TabIndex = 9
        txtGitHubLink.TextAlign = HorizontalAlignment.Center
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.Location = New Point(232, 288)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.ReadOnly = True
        txtStopwatchTime.Size = New Size(323, 27)
        txtStopwatchTime.TabIndex = 10
        txtStopwatchTime.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnPrevious
        ' 
        btnPrevious.BackColor = Color.Yellow
        btnPrevious.Location = New Point(95, 350)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(225, 32)
        btnPrevious.TabIndex = 11
        btnPrevious.Text = "PREVIOUS (CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = False
        ' 
        ' btnNext
        ' 
        btnNext.BackColor = Color.LightBlue
        btnNext.Location = New Point(335, 350)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(220, 32)
        btnNext.TabIndex = 12
        btnNext.Text = "NEXT (CTRL+N)"
        btnNext.UseVisualStyleBackColor = False
        ' 
        ' FormViewsubmissions
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        KeyPreview = True
        Name = "FormViewsubmissions"
        Text = "Mohnish Kamalaksha , Slidely Task 2 - View Submissions"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
End Class
