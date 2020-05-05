﻿Imports System.IO
Imports System.Data.SqlClient

Public Class chargeinfo
    Dim strconn As String = login.ss
    Dim conn As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim sql As String

    Public condition As String

    Public Function decryptConString() As String
        Dim base64encoded As String = File.ReadAllText("connectionstring.txt")
        Dim data As Byte() = System.Convert.FromBase64String(base64encoded)
        Return System.Text.ASCIIEncoding.ASCII.GetString(data)
    End Function

    Public Sub connect()
        conn = New SqlConnection
        conn.ConnectionString = strconn
        If conn.State <> ConnectionState.Open Then
            conn.Open()
        End If
    End Sub

    Public Sub disconnect()
        conn = New SqlConnection
        conn.ConnectionString = strconn
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub seniorinfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        lblcash.Text = ""
    End Sub

    Private Sub seniorinfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grdcharge.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        grdcharge.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub
End Class