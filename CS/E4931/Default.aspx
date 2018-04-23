<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="E4931.Default" %>

<%@ Register Assembly="DevExpress.XtraReports.v13.1.Web, Version=13.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a"
    Namespace="DevExpress.XtraReports.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <dx:ReportToolbar ID="SampleReportToolbar" runat="server" ReportViewerID="SampleReportViewer">           
        </dx:ReportToolbar>
        <dx:ReportViewer ID="SampleReportViewer" runat="server" 
            oncachereportdocument="SampleReportViewer_CacheReportDocument" 
            onrestorereportdocumentfromcache="SampleReportViewer_RestoreReportDocumentFromCache" 
            Report="<%# new SampleReport() %>" ReportName="SampleReport">
        </dx:ReportViewer>
    </div>
    </form>
</body>
</html>
