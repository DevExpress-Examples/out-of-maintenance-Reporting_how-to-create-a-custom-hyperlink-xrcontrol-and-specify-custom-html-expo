using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

/// <summary>
/// Summary description for SampleReport
/// </summary>
public class SampleReport : DevExpress.XtraReports.UI.XtraReport {
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private E4931.NWindDataSet nWindDataSet1;
    private E4931.NWindDataSetTableAdapters.ProductsTableAdapter productsTableAdapter;
    private ReportHeaderBand ReportHeader;
    private XRLabel lbHeader;
    private E4931.XRHyperlink hlProductName;
    private XRLabel lbUnitPrice;
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    public SampleReport() {
        InitializeComponent();
    }

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.lbUnitPrice = new DevExpress.XtraReports.UI.XRLabel();
            this.hlProductName = new E4931.XRHyperlink();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.nWindDataSet1 = new E4931.NWindDataSet();
            this.productsTableAdapter = new E4931.NWindDataSetTableAdapters.ProductsTableAdapter();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lbHeader = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbUnitPrice,
            this.hlProductName});
            this.Detail.HeightF = 25F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.UnitPrice", "{0:c}")});
            this.lbUnitPrice.Font = new System.Drawing.Font("Times New Roman", 14F);
            this.lbUnitPrice.LocationFloat = new DevExpress.Utils.PointFloat(501.6667F, 0F);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbUnitPrice.SizeF = new System.Drawing.SizeF(138.3332F, 25F);
            this.lbUnitPrice.StylePriority.UseFont = false;
            this.lbUnitPrice.StylePriority.UseTextAlignment = false;
            this.lbUnitPrice.Text = "lbUnitPrice";
            this.lbUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // hlProductName
            // 
            this.hlProductName.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Products.ProductName"),
            new DevExpress.XtraReports.UI.XRBinding("NavigateUrl", null, "Products.ProductID", "javascript:void({0})")});
            this.hlProductName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.hlProductName.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 0F);
            this.hlProductName.Name = "hlProductName";
            this.hlProductName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.hlProductName.SizeF = new System.Drawing.SizeF(491.6667F, 25F);
            this.hlProductName.StylePriority.UseFont = false;
            this.hlProductName.StylePriority.UseTextAlignment = false;
            this.hlProductName.Text = "hlProductName";
            this.hlProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nWindDataSet1
            // 
            this.nWindDataSet1.DataSetName = "NWindDataSet";
            this.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productsTableAdapter
            // 
            this.productsTableAdapter.ClearBeforeFill = true;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lbHeader});
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Times New Roman", 36F);
            this.lbHeader.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lbHeader.SizeF = new System.Drawing.SizeF(630F, 79.99998F);
            this.lbHeader.StylePriority.UseFont = false;
            this.lbHeader.StylePriority.UseTextAlignment = false;
            this.lbHeader.Text = "Sample Report";
            this.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter;
            // 
            // SampleReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader});
            this.DataAdapter = this.productsTableAdapter;
            this.DataMember = "Products";
            this.DataSource = this.nWindDataSet1;
            this.Version = "13.1";
            ((System.ComponentModel.ISupportInitialize)(this.nWindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion
}
