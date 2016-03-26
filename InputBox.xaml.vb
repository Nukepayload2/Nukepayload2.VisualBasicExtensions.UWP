' “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上提供

''' <summary>
''' 可用于自身或导航至 Frame 内部的空白页。
''' </summary>
Public NotInheritable Class InputBox
    Inherits ContentDialog
    Public Overloads Async Function ShowAsync(Prompt As String, Title As String, Optional InputScope As InputScopeNameValue = InputScopeNameValue.Text) As Task(Of String)
        Me.Title = Title
        TxtPrompt.Text = Prompt
        TxtOutput.Text = ""
        TxtOutput.InputScope = New InputScope
        TxtOutput.InputScope.Names.Clear()
        TxtOutput.InputScope.Names.Add(New InputScopeName(InputScope))
        Await ShowAsync()
        Return TxtOutput.Text
    End Function

    Private Sub BtnOk_Click(sender As Object, e As RoutedEventArgs)
        Hide()
    End Sub
End Class