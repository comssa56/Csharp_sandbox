Public Class Form1

    Private Sub HelloWorld(sender As Object, e As EventArgs) Handles HelloWorldButton.Click
        Dim HWComponent = New HelloWorldComponent(Me.HelloWorldList, Me.HelloWorldButton, Me.HelloWorldLabel)
        HelloWorldController.ButtonPushed(HWComponent)
    End Sub

End Class

