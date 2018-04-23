# How to create a custom hyperlink XRControl and specify custom HTML export for it


<p>This example demonstrates how to create a custom <a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRControltopic"><u>XRControl</u></a> descendant with custom export code.</p><br />
<p>A custom hyperlink control (<a href="http://documentation.devexpress.com/#XtraReports/clsDevExpressXtraReportsUIXRLabeltopic"><u>XRLabel</u></a> control descendant) is created in this example. This control is represented as <a> tag in HTML documents. </p><p>To correctly save/restore the custom XRControl to/from report document data, a custom XtraPrinting <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument88"><u>visual brick</u></a> was created to represent this control. Please refer to the <a href="http://documentation.devexpress.com/#XtraReports/CustomDocument5157"><u>Storing Report Documents</u></a> help topic for more information regarding report documents. </p><p>Custom brick exporter class was used to customize the brick export process.</p>

<br/>


