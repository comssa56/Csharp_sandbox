Public Module HelloWorldConst
    Public Enum ListBoxItem
        One = 1
        Two
        Three
    End Enum

    Public Function GetListBoxItemMap() As Dictionary(Of String, ListBoxItem)
        Return New Dictionary(Of String, ListBoxItem) From {
            {"1", ListBoxItem.One},
            {"2", ListBoxItem.Two},
            {"3", ListBoxItem.Three}
        }
    End Function

    Public Function GetResultStrMap() As Dictionary(Of ListBoxItem, String)
        Return New Dictionary(Of ListBoxItem, String) From {
            {ListBoxItem.One, "hello"},
            {ListBoxItem.Two, "world"},
            {ListBoxItem.Three, "hello world"}
        }
    End Function

    Public ReadOnly Property RESULT_INITIAL_STR As String = "???"


End Module

Public Class HelloWorldListBox
    Private ReadOnly listbox As ListBox

    Public Sub New(listbox As ListBox)
        Me.listbox = listbox
    End Sub

    Public Function GetInitialItems() As List(Of String)
        GetListBoxItemMap.Clear()
        Return HelloWorldConst.GetListBoxItemMap.Keys.ToList
    End Function

    Public Function GetSelectedType() As HelloWorldConst.ListBoxItem
        Return HelloWorldConst.GetListBoxItemMap.Item(Me.listbox.SelectedItem)
    End Function

End Class

Public Class HelloWorldButton
    Private ReadOnly button As Button

    Public Sub New(button As Button)
        Me.button = button
    End Sub

End Class

Public Class HelloWorldResult
    Private ReadOnly result As Label

    Public Sub New(result As Label)
        Me.result = result
    End Sub

    Public Function GetInitStr() As String
        Return RESULT_INITIAL_STR
    End Function

    Public Function GetResultStr(key As HelloWorldConst.ListBoxItem) As String
        Return GetResultStrMap.Item(key)
    End Function

End Class


Public Class HelloWorldComponent

    Public listbox As ListBox
    Public button As Button
    Public result As Label

    Public Sub New(listbox As ListBox, button As Button, result As Label)
        Me.listbox = listbox
        Me.button = button
        Me.result = result
    End Sub

End Class

Public Module HelloWorldController

    Public Sub Init(component As HelloWorldComponent)
        Dim box = New HelloWorldListBox(component.listbox)
        Dim result = New HelloWorldResult(component.result)

        HelloWorldView.Init(component, box.GetInitialItems)
        HelloWorldView.SetResult(component, result.GetInitStr())
    End Sub

    Public Sub ButtonPushed(component As HelloWorldComponent)
        Dim box = New HelloWorldListBox(component.listbox)
        Dim result = New HelloWorldResult(component.result)

        HelloWorldView.SetResult(component, result.GetResultStr(box.GetSelectedType()))
    End Sub

End Module

Public Module HelloWorldView
    Public Sub Init(component As HelloWorldComponent, listItems As List(Of String))
        component.listbox.Items.Clear()
        listItems.ForEach(
            Sub(item)
                component.listbox.Items.Add(item)
            End Sub
        )
    End Sub

    Public Sub SetResult(component As HelloWorldComponent, resultStr As String)
        component.result.Text = resultStr
    End Sub

End Module

