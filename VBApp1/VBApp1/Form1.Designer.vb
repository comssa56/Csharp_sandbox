<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.HelloWorldLabel = New System.Windows.Forms.Label()
        Me.HelloWorldButton = New System.Windows.Forms.Button()
        Me.HelloWorldList = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'HelloWorldLabel
        '
        Me.HelloWorldLabel.AutoSize = True
        Me.HelloWorldLabel.Location = New System.Drawing.Point(504, 170)
        Me.HelloWorldLabel.Name = "HelloWorldLabel"
        Me.HelloWorldLabel.Size = New System.Drawing.Size(113, 36)
        Me.HelloWorldLabel.TabIndex = 0
        Me.HelloWorldLabel.Text = "Label1"
        '
        'HelloWorldButton
        '
        Me.HelloWorldButton.Location = New System.Drawing.Point(114, 194)
        Me.HelloWorldButton.Name = "HelloWorldButton"
        Me.HelloWorldButton.Size = New System.Drawing.Size(187, 107)
        Me.HelloWorldButton.TabIndex = 1
        Me.HelloWorldButton.Text = "ose!!"
        Me.HelloWorldButton.UseVisualStyleBackColor = True
        '
        'HelloWorldList
        '
        Me.HelloWorldList.FormattingEnabled = True
        Me.HelloWorldList.ItemHeight = 36
        Me.HelloWorldList.Location = New System.Drawing.Point(114, 92)
        Me.HelloWorldList.Name = "HelloWorldList"
        Me.HelloWorldList.Size = New System.Drawing.Size(230, 40)
        Me.HelloWorldList.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 36.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.HelloWorldList)
        Me.Controls.Add(Me.HelloWorldButton)
        Me.Controls.Add(Me.HelloWorldLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()


        Dim HWComponent = New HelloWorldComponent(Me.HelloWorldList, Me.HelloWorldButton, Me.HelloWorldLabel)
        HelloWorldController.Init(HWComponent)

    End Sub

    Friend WithEvents HelloWorldLabel As Label
    Friend WithEvents HelloWorldButton As Button
    Friend WithEvents HelloWorldList As ListBox
End Class
