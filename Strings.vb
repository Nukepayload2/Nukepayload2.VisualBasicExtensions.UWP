Imports Nukepayload2.VisualBasicExtensions.UWP.Native.Strings
Public Module Strings
    Public Function StrConv$(Source$, Conversion As VbStrConv)
        Debug.WriteLine(VbStrConvToMapFlags(Conversion).ToString("x"))
        Return LCMapString(VbStrConvToMapFlags(Conversion), Source)
    End Function
    Public Function StrConv$(Source$, Conversion As VbStrConv, LocaleName$)
        Return LCMapString(LocaleName, VbStrConvToMapFlags(Conversion), Source)
    End Function
End Module