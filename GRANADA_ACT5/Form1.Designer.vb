<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Labelone = New Label()
        Txtone = New TextBox()
        Labeltwo = New Label()
        Txttwo = New TextBox()
        DIVIDE = New Button()
        rstdivide = New TextBox()
        SuspendLayout()
        ' 
        ' Labelone
        ' 
        Labelone.AutoSize = True
        Labelone.Location = New Point(28, 31)
        Labelone.Name = "Labelone"
        Labelone.Size = New Size(86, 15)
        Labelone.TabIndex = 0
        Labelone.Text = "FIRST NUMBER"
        ' 
        ' Txtone
        ' 
        Txtone.Location = New Point(27, 65)
        Txtone.Name = "Txtone"
        Txtone.Size = New Size(97, 23)
        Txtone.TabIndex = 1
        ' 
        ' Labeltwo
        ' 
        Labeltwo.AutoSize = True
        Labeltwo.Location = New Point(33, 110)
        Labeltwo.Name = "Labeltwo"
        Labeltwo.Size = New Size(104, 15)
        Labeltwo.TabIndex = 2
        Labeltwo.Text = "SECOND NUMBER"
        ' 
        ' Txttwo
        ' 
        Txttwo.Location = New Point(36, 144)
        Txttwo.Name = "Txttwo"
        Txttwo.Size = New Size(102, 23)
        Txttwo.TabIndex = 3
        ' 
        ' DIVIDE
        ' 
        DIVIDE.Location = New Point(53, 187)
        DIVIDE.Name = "DIVIDE"
        DIVIDE.Size = New Size(78, 27)
        DIVIDE.TabIndex = 4
        DIVIDE.Text = "DIVIDE"
        DIVIDE.UseVisualStyleBackColor = True
        ' 
        ' rstdivide
        ' 
        rstdivide.Location = New Point(29, 236)
        rstdivide.Name = "rstdivide"
        rstdivide.Size = New Size(109, 23)
        rstdivide.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = My.Resources.Resources.spirit
        ClientSize = New Size(800, 450)
        Controls.Add(rstdivide)
        Controls.Add(DIVIDE)
        Controls.Add(Txttwo)
        Controls.Add(Labeltwo)
        Controls.Add(Txtone)
        Controls.Add(Labelone)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Labelone As Label
    Friend WithEvents Txtone As TextBox
    Friend WithEvents Labeltwo As Label
    Friend WithEvents Txttwo As TextBox
    Friend WithEvents DIVIDE As Button
    Friend WithEvents rstdivide As TextBox
End Class
