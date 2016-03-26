#If WINDOWS_UWP Then
Imports Windows.UI.Popups
Public Module Interaction
    Public Async Function MsgBoxAsync(Prompt$, HasCancel As Boolean, Title$, Optional OK$ = "确定", Optional Cancel$ = "取消") As Task(Of Boolean?)
        Dim dlg As New MessageDialog(Prompt, Title)
        Dim Result As Boolean?
        Dim msg As New MessageDialog(Prompt, Title)
        msg.Commands.Add(New UICommand(OK, Sub(command) Result = True))
        msg.DefaultCommandIndex = 0
        If HasCancel Then
            msg.Commands.Add(New UICommand(Cancel, Sub(command) Result = False))
            msg.CancelCommandIndex = 1
        End If
        Dim tsk = msg.ShowAsync
        Await tsk
        Return Result
    End Function
    Dim inputbox As New InputBox()
    Public Async Function InputBoxAsync(Prompt$, Title$, Optional InputScope As InputScopeNameValue = InputScopeNameValue.Text) As Task(Of String)
        Return Await inputbox.ShowAsync(Prompt, Title, InputScope)
    End Function
End Module
#End If