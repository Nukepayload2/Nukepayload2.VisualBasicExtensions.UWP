Imports System.Runtime.InteropServices

Public Module VBMath

    Dim rand As New Random(0)

    Public Sub Randomize()
        rand = New Random
    End Sub

    Public Sub Randomize(Number As Single)
        rand = New Random(New SingleInt32(Number).Int32Value)
    End Sub

    Public Function Rnd() As Single
        Return rand.NextDouble
    End Function

    Public Function Rnd(Number As Single) As Single
        rand = New Random(New SingleInt32(Number).Int32Value)
        Return Rnd
    End Function

    Private Structure SingleInt32
        Sub New(SingleValue!)
            Me.SingleValue = SingleValue
        End Sub
        Sub New(Int32Value%)
            Me.Int32Value = Int32Value
        End Sub
        <FieldOffset(0)>
        Dim SingleValue!
        <FieldOffset(0)>
        Dim Int32Value%
    End Structure
End Module