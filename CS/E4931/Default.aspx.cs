using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using DevExpress.XtraReports.Web;

namespace E4931 {
    public partial class Default : System.Web.UI.Page {
        protected void Page_Load(object sender, EventArgs e) {

        }

        protected void SampleReportViewer_CacheReportDocument(object sender, CacheReportDocumentEventArgs e) {
            Session["DocumentCache"] = e.SaveDocumentToMemoryStream();
        }

        protected void SampleReportViewer_RestoreReportDocumentFromCache(object sender, RestoreReportDocumentFromCacheEventArgs e) {
            Stream documentCache = (Stream) Session["DocumentCache"];
            if (documentCache != null) {
                e.RestoreDocumentFromStream(documentCache);
            }
        }
    }
}