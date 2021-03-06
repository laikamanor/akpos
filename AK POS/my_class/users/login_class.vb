﻿Imports AK_POS.connection_class
Public Class login_class
    Dim cc As New connection_class
    Private username As String = "", password As String = ""
    Public ReadOnly Property getUsername() As String
        Get
            Return username
        End Get
    End Property
    Public Sub setUsername(ByVal value As String)
        username = value
    End Sub
    Public ReadOnly Property getPassword() As String
        Get
            Return password
        End Get
    End Property
    Public Sub setPassword(ByVal value As String)
        password = value
    End Sub
    Public Function checkLogin() As Boolean
        Dim result_num As Integer = 0, result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT dbo.checkLogin(@username,@password)", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        cc.cmd.Parameters.AddWithValue("@password", cc.Encrypt(password))
        'cc.cmd.Parameters.AddWithValue("@password", System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(password)).Trim)
        result_num = cc.cmd.ExecuteScalar()
        cc.con.Close()
        result = IIf(result_num = 1, True, False)
        Return result
    End Function

    Public Function checkUserStatus() As Boolean
        Dim result_num As Integer = 0, result As Boolean = False
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT dbo.checkUserStatus(@username)", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        result_num = cc.cmd.ExecuteScalar()
        cc.con.Close()
        result = IIf(result_num = 1, True, False)
        Return result
    End Function

    Public Sub insertCutOff()
        Try
            Dim lm As Boolean = False, status As String = "", date_from As New DateTime(), dateNow As String = cc.getSystemDate.ToString("MM/dd/yyyy")
            cc.con.Open()
                cc.cmd = New SqlClient.SqlCommand("SELECT status,date FROM tblcutoff WHERE userid=(SELECT systemid FROM tblusers WHERE username=@username) ORDER BY cid DESC;", cc.con)
                cc.cmd.Parameters.AddWithValue("@username", username)
                cc.rdr = cc.cmd.ExecuteReader
                If cc.rdr.Read Then
                    lm = True
                    status = cc.rdr("status")
                    date_from = CDate(cc.rdr("date"))
                Else
                    lm = False
                End If
                cc.con.Close()
            If lm Then
                If status = "In Active" And date_from.ToString("MM/dd/yyyy") = cc.getSystemDate.ToString("MM/dd/yyyy") Then
                ElseIf status = "In Active" And date_from.ToString("MM/dd/yyyy") <> cc.getSystemDate().ToString("MM/dd/yyyy") Then
                    cc.con.Open()
                    cc.cmd = New SqlClient.SqlCommand("INSERT INTO tblcutoff (userid,status,date) VALUES ((SELECT systemid FROM tblusers WHERE username=@username2), 'Active',GETDATE());", cc.con)
                    cc.cmd.Parameters.AddWithValue("@username2", username)
                    cc.cmd.ExecuteNonQuery()
                    cc.con.Close()
                ElseIf status = "Active" And date_from.ToString("MM/dd/yyyy") <> cc.getSystemDate().ToString("MM/dd/yyyy") Then
                ElseIf status = "Active" And date_from.ToString("MM/dd/yyyy") = cc.getSystemDate().ToString("MM/dd/yyyy") Then
                End If
            Else
                cc.con.Open()
                cc.cmd = New SqlClient.SqlCommand("INSERT INTO tblcutoff (userid,status,date) VALUES ((SELECT systemid FROM tblusers WHERE username=@username2), 'Active',GETDATE());", cc.con)
                cc.cmd.Parameters.AddWithValue("@username2", username)
                cc.cmd.ExecuteNonQuery()
                cc.con.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Public Sub insertLogs()
        Try
            cc.con.Open()
            cc.cmd = New SqlClient.SqlCommand("INSERT INTO tbllogin (username,login,logout,datelogin) VALUES (@username,(SELECT FORMAT(GETDATE(), 'hh:mm tt')),(SELECT FORMAT(GETDATE(), 'hh:mm tt')),(SELECT  FORMAT(GETDATE(), 'MM/dd/yyyy')))", cc.con)
            cc.cmd.Parameters.AddWithValue("@username", username)
            cc.cmd.ExecuteNonQuery()
            cc.con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
    End Sub
    Public Function getWorkgroup(ByVal columnName As String) As String
        Dim result As String = ""
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("SELECT " & columnName & " [" & columnName & "] FROM tblusers WHERE username=@username", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        result = cc.cmd.ExecuteScalar
        cc.con.Close()
        Return result
    End Function

    Public Sub logOut()
        cc.con.Open()
        cc.cmd = New SqlClient.SqlCommand("UPDATE tbllogin SET logout=(select format(getdate(), 'hh:mm tt')) WHERE systemid=(SELECT TOP 1 systemid FROM tbllogin WHERE username=@username ORDER BY systemid DESC);", cc.con)
        cc.cmd.Parameters.AddWithValue("@username", username)
        cc.cmd.ExecuteNonQuery()
        cc.con.Close()
    End Sub

    Public Function checkCutOff() As Boolean
        Dim result As Boolean = False, date_from As New DateTime(), status As String = "", serverDate As New DateTime()
        serverDate = cc.getSystemDate
        Try
            cc.con.Open()
            cc.cmd = New SqlClient.SqlCommand("SELECT TOP 1 a.date,a.status FROM tblcutoff a INNER JOIN tblusers b ON a.userid = b.systemid WHERE CAST(a.date AS date)=(SELECT TOP 1 CAST(datecreated AS date) FROM tblinvsum WHERE verify=0 AND b.workgroup NOT IN ('Administrator','LC Accounting') ORDER BY invsumid ASC)", cc.con)
            cc.rdr = cc.cmd.ExecuteReader
            If cc.rdr.Read Then
                date_from = CDate(cc.rdr("date"))
                status = cc.rdr("status")
            End If
            cc.con.Close()

            If status = "In Active" And date_from.ToString("MM/dd/yyyy") = serverDate.ToString("MM/dd/yyyy") Then
                result = True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            cc.con.Close()
        End Try
        Return result
    End Function
End Class
