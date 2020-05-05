﻿Imports System.Data.SqlClient
Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports CrystalDecisions.ReportSource
Imports CrystalDecisions.Windows.Forms

Public Class receiptnew
    Dim strconn As String = login.ss
    Dim sql As String
    Dim conn As SqlConnection
    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim dscmd As New SqlDataAdapter
    Public objRpt As New crreceiptnew
    Public ds As New DataSet1
    Public sqlquery As String
    Public constring As String
    Dim trnum As String = "", servicetype As String = ""

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

    Private Sub receiptprev_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ds = New DataSet1
        Try
            sqlquery = "SELECT TOP 1 * FROM tbltransaction order by transid DESC"
            connect()
            cmd = New SqlCommand(sqlquery, conn)
            dr = cmd.ExecuteReader
            If dr.Read Then
                trnum = dr("transnum")
                servicetype = dr("servicetype")
            End If
            dr.Dispose()
            cmd.Dispose()

            'sqlquery = "SELECT itemname,qty,totalprice,discprice FROM tblorder where transnum='" & trnum & "'"
            If mainmenu.lblidno.Text <> "" Then
                sqlquery = "SELECT tbltransaction.transnum,tbltransaction.cashier,tbltransaction.servicetype,tbltransaction.delcharge,tbltransaction.subtotal,tbltransaction.less,tbltransaction.vat,tbltransaction.amtdue,tbltransaction.tenderamt,tbltransaction.change,tblorder.itemname,tblorder.qty,tblorder.discprice,tblorder.totalprice,tbltransaction.vatsales,tbltransaction.transid,tblorder.dscnt,tblorder.request,tblsenior.idno,tblsenior.name  FROM tbltransaction RIGHT OUTER JOIN tblorder ON tbltransaction.transnum=tblorder.transnum RIGHT OUTER JOIN tblsenior ON tbltransaction.transnum=tblsenior.transnum where tbltransaction.transnum='" & trnum & "' order by tbltransaction.transid DESC"
                connect()
                sql = procesSQL()
                Me.Cursor = Cursors.WaitCursor

                dscmd = New SqlDataAdapter(sql, conn)
                dscmd.Fill(ds.DataTable1)
                'MsgBox(ds.Tables(0).Rows.Count)
                disconnect()

            Else
                sqlquery = "SELECT tbltransaction.transnum,tbltransaction.cashier,tbltransaction.servicetype,tbltransaction.delcharge,tbltransaction.subtotal,tbltransaction.less,tbltransaction.vat,tbltransaction.amtdue,tbltransaction.tenderamt,tbltransaction.change,tblorder.itemname,tblorder.qty,tblorder.discprice,tblorder.totalprice,tbltransaction.vatsales,tbltransaction.transid,tblorder.dscnt,tblorder.request FROM tbltransaction RIGHT OUTER JOIN tblorder ON tbltransaction.transnum=tblorder.transnum where tbltransaction.transnum='" & trnum & "' order by tbltransaction.transid DESC"
                connect()
                sql = procesSQL()
                Me.Cursor = Cursors.WaitCursor

                dscmd = New SqlDataAdapter(sql, conn)
                dscmd.Fill(ds.DataTable1)
                'MsgBox(ds.Tables(0).Rows.Count)
                disconnect()

            End If

            Dim MyText As TextObject
            If ds.Tables(0).Rows.Count > 0 Then
                If ds.Tables(0).Rows(0).Item("DataColumn6") = "0.00" Then
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text97"), TextObject)
                    MyText.Text = ""
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text98"), TextObject)
                    MyText.Text = ""
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text99"), TextObject)
                    MyText.Text = ""
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text151"), TextObject)
                    MyText.Text = ""
                Else
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text97"), TextObject)
                    MyText.Text = "Discount Type:"
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text98"), TextObject)
                    MyText.Text = "ID No.:"
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text99"), TextObject)
                    MyText.Text = "Name:"
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text151"), TextObject)
                    MyText.Text = "Signature:________________________"
                End If


                If ds.Tables(0).Rows(0).Item("DataColumn16") < 1000000 Then
                    Dim temp As String = ""
                    Dim s As String = ds.Tables(0).Rows(0).Item("DataColumn16")
                    For vv As Integer = 1 To 6 - s.Length
                        temp = temp & "0"
                    Next
                    ds.Tables(0).Rows(0).Item("DataColumn16") = temp & s
                End If

                Dim titems As Integer = 0
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    If ds.Tables(0).Rows(i).Item("DataColumn17") <> "0" Then
                        ds.Tables(0).Rows(i).Item("DataColumn11") = ds.Tables(0).Rows(i).Item("DataColumn11") & " -" & ds.Tables(0).Rows(i).Item("DataColumn17") & "% off"
                    End If
                    If Trim(ds.Tables(0).Rows(i).Item("DataColumn18").ToString) <> "" Then
                        Dim x As String = ds.Tables(0).Rows(i).Item("DataColumn18")
                        ds.Tables(0).Rows(i).Item("DataColumn18") = "-" & x
                    End If
                    titems += ds.Tables(0).Rows(i).Item("DataColumn12")
                Next

                MyText = CType(objRpt.ReportDefinition.ReportObjects("Textitem"), TextObject)
                MyText.Text = titems
                MyText.ObjectFormat.HorizontalAlignment = Alignment.RightAlign

                connect()
                For i = 0 To ds.Tables(0).Rows.Count - 1
                    ds.Tables(0).Rows(i).Item("DataColumn23") = Val(ds.Tables(0).Rows(i).Item("DataColumn5")) - (Val(ds.Tables(0).Rows(i).Item("DataColumn8")) - Val(ds.Tables(0).Rows(i).Item("DataColumn4")))

                    Dim tempprice As Double = 0
                    sql = "Select * from tblorder where transnum='" & trnum & "'"
                    cmd = New SqlCommand(sql, conn)
                    dr = cmd.ExecuteReader
                    While dr.Read
                        tempprice += Val(dr("price")) * (Val(dr("dscnt")) / 100) * Val(dr("qty"))
                    End While
                    dr.Dispose()
                    cmd.Dispose()

                    ds.Tables(0).Rows(i).Item("DataColumn24") = tempprice

                    ds.Tables(0).Rows(i).Item("DataColumn22") = Val(ds.Tables(0).Rows(i).Item("DataColumn23")) + Val(ds.Tables(0).Rows(i).Item("DataColumn24"))

                    If ds.Tables(0).Rows(i).Item("DataColumn6") = 100 Then
                        ds.Tables(0).Rows(i).Item("DataColumn22") = 0
                    End If

                    sql = "Select * from tbltransaction where transnum='" & trnum & "'"
                    cmd = New SqlCommand(sql, conn)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        If dr("disctype").ToString.Contains("Senior") Or dr("disctype").ToString.Contains("Pwd") Then
                            If dr("remarks").ToString.Contains("W/ GRPM") Then
                                ds.Tables(0).Rows(i).Item("DataColumn21") = (dr("vatsales") + dr("vat")) / 1.12
                                ds.Tables(0).Rows(i).Item("DataColumn22") = ds.Tables(0).Rows(i).Item("DataColumn21") * 0.2
                                Dim lessbased As Double = dr("subtotal") - (dr("vatsales") + dr("vat"))
                                ds.Tables(0).Rows(i).Item("DataColumn15") = lessbased / 1.12
                                ds.Tables(0).Rows(i).Item("DataColumn7") = lessbased - (lessbased / 1.12)
                            Else
                                ds.Tables(0).Rows(i).Item("DataColumn21") = Val(ds.Tables(0).Rows(i).Item("DataColumn5") / 1.12).ToString("n2")
                                ds.Tables(0).Rows(i).Item("DataColumn22") = ds.Tables(0).Rows(i).Item("DataColumn21") * 0.2
                                ds.Tables(0).Rows(i).Item("DataColumn15") = "0.00"
                                ds.Tables(0).Rows(i).Item("DataColumn7") = "0.00"
                            End If
                        Else
                            ds.Tables(0).Rows(i).Item("DataColumn21") = "0.00"
                        End If
                        MyText = CType(objRpt.ReportDefinition.ReportObjects("Text127"), TextObject)
                        MyText.Text = dr("tablenum")
                        MyText = CType(objRpt.ReportDefinition.ReportObjects("Text96"), TextObject)
                        MyText.Text = dr("disctype")
                    End If
                    dr.Dispose()
                    cmd.Dispose()
                Next

                If servicetype = "Transfer" Then
                    sql = "Select * from tbltransfer where transnum='" & trnum & "'"
                    connect()
                    cmd = New SqlCommand(sql, conn)
                    dr = cmd.ExecuteReader
                    If dr.Read Then
                        MyText = CType(objRpt.ReportDefinition.ReportObjects("Text128"), TextObject)
                        MyText.Text = "to " & dr("branch")
                    End If
                    dr.Dispose()
                    cmd.Dispose()
                Else
                    MyText = CType(objRpt.ReportDefinition.ReportObjects("Text128"), TextObject)
                    MyText.Text = ""
                End If
            End If


            objRpt.SetDataSource(Me.ds.Tables(0))
            CrystalReportViewer1.ReportSource = objRpt
            CrystalReportViewer1.Refresh()

            Me.Cursor = Cursors.Default

            Dim a As String = MsgBox("Do you want to print receipt?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "")
            If a = vbYes Then
                'MsgBox(ds.Tables(0).Rows(0).Item(0))
                objRpt.PrintToPrinter(1, False, 0, 0)
            End If

            Me.Close()

        Catch ex As System.InvalidOperationException
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Critical, "")
        Catch ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox(ex.Message, MsgBoxStyle.Information)
        End Try
    End Sub

    Public Function procesSQL() As String
        Dim inSql As String
        Dim firstPart As String
        Dim lastPart As String
        Dim selectStart As Integer
        Dim fromStart As Integer
        Dim fields As String()
        Dim i As Integer
        Dim MyText As TextObject
        'Dim mycol As FieldObject

        inSql = sqlquery
        'inSql = inSql.ToUpper

        selectStart = inSql.IndexOf("SELECT")
        fromStart = inSql.IndexOf("FROM")
        selectStart = selectStart + 6
        firstPart = inSql.Substring(selectStart, (fromStart - selectStart))
        lastPart = inSql.Substring(fromStart, inSql.Length - fromStart)

        fields = firstPart.Split(",")
        firstPart = ""
        'MsgBox(fields.Length)
        For i = 0 To fields.Length - 1
            If i > 0 Then
                firstPart = firstPart & " , " & fields(i).ToString() & " as DataColumn" & i + 1
                MyText = CType(objRpt.ReportDefinition.ReportObjects("Text" & i + 1), TextObject)
                MyText.Text = Trim(fields(i).ToString())
            Else
                firstPart = firstPart & fields(i).ToString() & " as DataColumn" & i + 1
                MyText = CType(objRpt.ReportDefinition.ReportObjects("Text" & i + 1), TextObject)
                MyText.Text = Trim(fields(i).ToString())
            End If
        Next


        sql = "SELECT " & firstPart & " " & lastPart

        Return sql
    End Function
End Class