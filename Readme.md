<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599214/13.1.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4931)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx](./CS/E4931/Default.aspx) (VB: [Default.aspx](./VB/E4931/Default.aspx))
* [Default.aspx.cs](./CS/E4931/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/E4931/Default.aspx.vb))
* [SampleReport.cs](./CS/E4931/SampleReport.cs) (VB: [SampleReport.vb](./VB/E4931/SampleReport.vb))
* **[XRHyperlink.cs](./CS/E4931/XRHyperlink.cs) (VB: [XRHyperlink.vb](./VB/E4931/XRHyperlink.vb))**
<!-- default file list end -->
# How to create a custom hyperlink XRControl and specify custom HTML export for it
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4931/)**
<!-- run online end -->


<p>This example demonstrates how to create a custom <a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRControltopic"><u>XRControl</u></a> descendant with custom export code.</p><br />
<p>A custom hyperlink control (<a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRLabeltopic"><u>XRLabel</u></a> control descendant) is created in this example. This control is represented as <a> tag in HTML documents. </p><p>To correctly save/restore the custom XRControl to/from report document data, a custom XtraPrinting <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument88"><u>visual brick</u></a> was created to represent this control. Please refer to the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5157"><u>Storing Report Documents</u></a> help topic for more information regarding report documents. </p><p>Custom brick exporter class was used to customize the brick export process.</p>

<br/>


