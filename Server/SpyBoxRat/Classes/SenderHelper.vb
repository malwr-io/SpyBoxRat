﻿Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class SenderHelper

    Public Shared Sub SenderHelper(ByVal ja As List(Of TcpClient), ByVal id As String, ByVal StringHelper As String)

        Try

            For Each j As TcpClient In ja


                If id = j.Client.RemoteEndPoint.ToString Then

                    'For Each i As Char In StringHelper ''OLD

                    Dim bufFfer() As Byte = Encoding.Default.GetBytes(StringHelper)

                    Task.Run(Sub() j.GetStream().WriteAsync(bufFfer, 0, bufFfer.Length))

                    '  Next  ''OLD

                End If

            Next

        Catch ex As Exception

        End Try

    End Sub

End Class
