Imports System
Imports System.IO
Imports System.Text
Imports System.Collections.Generic
Public Class frmMain

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.FolderBrowserDialog1.SelectedPath.Trim() = "" Then
            MsgBox("Please Choose a Destination Folder", MsgBoxStyle.OkOnly, "Problem")
            Exit Sub

        End If
        Dim users() As String
        Dim groups() As String

        'Dim writer As StreamWriter = New StreamWriter("c:\temp\CHatterGroups" & GetRandom(1, 1000) & ".csv")
        Dim writer As StreamWriter = New StreamWriter(Me.FolderBrowserDialog1.SelectedPath & "\ChatterGroups" & GetRandom(1, 1000) & ".csv")
        groups = Me.tGroups.Text.Split(Environment.NewLine)
        Dim uBG As Integer = UBound(groups)
        Dim t1 As Boolean = False
        ' tOut.Text = "UserID,GroupID" & Environment.NewLine
        writer.WriteLine("UserID,GroupID")
        users = Me.tUsers.Text.Split(vbCrLf)
        For i = 0 To UBound(users)
            For j = 0 To (uBG - 0)
                ' tOut.Text = tOut.Text & users(i).ToString & "," & groups(j).ToString & Environment.NewLine
                If users(i).ToString.Trim <> "005C0000003W4V1IAK" Then
                    writer.WriteLine(users(i).ToString.Trim & "," & groups(j).ToString.Trim)
                End If

                If users(i).ToString.Trim = "005C0000003VzjA" Then
                    t1 = True


                End If
                writer.Flush()

            Next
        Next
        MsgBox("Complete", MsgBoxStyle.OkOnly, "Complete")
        Application.Exit()

    End Sub
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        ' by making Generator static, we preserve the same instance '
        ' (i.e., do not create new instances with the same seed over and over) '
        ' between calls '
        Static Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Me.tGroups.Text = "0F9C0000000L3jQKAS" & vbCrLf & "0F9C0000000L3jVKAS" & vbCrLf & "0F9C0000000L3jaKAC" & vbCrLf & "0F9C0000000L3kxKAC"
        '    Me.tGroups.Text = "0F930000000L5Y1"

    End Sub

    Private Sub tGroups_TextChanged(sender As Object, e As EventArgs) Handles tGroups.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.FolderBrowserDialog1.ShowDialog()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
