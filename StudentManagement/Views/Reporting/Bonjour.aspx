<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Bonjour.aspx.cs" Inherits="StudentManagement.Views.Reporting.Groups" %>

<%@ Register assembly="CrystalDecisions.Web, Version=13.0.3500.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" namespace="CrystalDecisions.Web" tagprefix="CR" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="../aspnet_client/system_web/4_6_81/crystalreportviewers13/js/crviewer/crv.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <CR:CrystalReportViewer ID="CrystalReportViewer1" runat="server" AutoDataBind="True" GroupTreeImagesFolderUrl="" Height="50px" ReportSourceID="CrystalReportSource1" ToolbarImagesFolderUrl="" ToolPanelWidth="200px" Width="350px" />
            <CR:CrystalReportSource ID="CrystalReportSource1" runat="server">
                <Report FileName="Views\Reporting\BonjourRapport.rpt">
                </Report>
            </CR:CrystalReportSource>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
    </form>
</body>
</html>
