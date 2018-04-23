using System;
using System.Web;
using DevExpress.XtraPrinting;
using DevExpress.XtraPrinting.BrickExporters;
using DevExpress.XtraPrinting.Native;
using DevExpress.XtraPrinting.Export;
using DevExpress.XtraReports.UI;

namespace E4931 {
    class HyperlinkBrickExporter : LabelBrickExporter {
        protected HyperlinkBrick HyperlinkBrick {
            get {
                return Brick as HyperlinkBrick;
            }
        }

        protected override void FillHtmlTableCellCore(IHtmlExportProvider exportProvider) {
            exportProvider.CurrentCell.InnerHtml = String.Format("<a href='{1}' target='{2}'>{0}</a>",
                HttpUtility.HtmlEncode(HyperlinkBrick.Text),
                HyperlinkBrick.Url,
                HyperlinkBrick.Target);
        }
    }

    [BrickExporter(typeof(HyperlinkBrickExporter))]
    public class HyperlinkBrick : LabelBrick {
        public static string HyperlinkBrickTypeName = "Hyperlink";

        static HyperlinkBrick() {
            BrickFactory.RegisterFactory(HyperlinkBrickTypeName, new DefaultBrickFactory<HyperlinkBrick>());
        }

        public HyperlinkBrick()
            : base() {
        }

        public HyperlinkBrick(IBrickOwner owner)
            : base(owner) {
        }

        public override string BrickType {
            get {
                return HyperlinkBrickTypeName;
            }
        }
    }

    public class XRHyperlink : XRLabel {
        protected override VisualBrick CreateBrick(VisualBrick[] childrenBricks) {
            return new HyperlinkBrick(this);
        }
    }
}