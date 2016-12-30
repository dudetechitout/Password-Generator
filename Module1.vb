Imports System.Text
Module Module1
    Function gen(ByVal i As Integer)
        Dim characters As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcdefghijklmnopqrstuvwxyz+_)(*&^%$#@!-={}][':;?><,./\|"
        Dim producer As New Random
        Dim collector As New StringBuilder
        For counter As Integer = 1 To i
            Dim supplier As Integer = producer.Next(0, characters.Length)
            collector.Append(characters.Substring(supplier, 1))
        Next
        Return collector.ToString()
    End Function
    Sub Main(ByVal gather() As String)
        Dim length As Integer = 12
        If Not gather.Length = 0 Then
            length = gather(0)
        End If
        Console.WriteLine(gen(length))
        Dim entry = Console.ReadLine()
        Do
            If Console.KeyAvailable Then
                Dim key_info As ConsoleKeyInfo = Console.ReadKey(True)
                If (key_info.Key.Equals(ConsoleKey.Escape)) Then
                    Exit Do
                ElseIf (entry.Equals("cls")) Then
                    Console.Clear()
                    entry = Console.ReadLine()
                Else
                    If Not entry Is Nothing Then
                        Console.WriteLine(gen(entry))
                        entry = Console.ReadLine()
                    Else
                        Exit Do
                    End If
                End If
            End If
        Loop
    End Sub
End Module
