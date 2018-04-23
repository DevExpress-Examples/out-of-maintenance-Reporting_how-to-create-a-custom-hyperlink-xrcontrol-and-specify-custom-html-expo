Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports DevExpress.XtraReports.UI

''' <summary>
''' Summary description for SampleReport
''' </summary>
Public Class SampleReport
	Inherits DevExpress.XtraReports.UI.XtraReport
	Private Detail As DevExpress.XtraReports.UI.DetailBand
	Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
	Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Private nWindDataSet1 As NWindDataSet
    Private productsTableAdapter As NWindDataSetTableAdapters.ProductsTableAdapter
	Private ReportHeader As ReportHeaderBand
	Private lbHeader As XRLabel
	Private hlProductName As E4931.XRHyperlink
	Private lbUnitPrice As XRLabel
	''' <summary>
	''' Required designer variable.
	''' </summary>
	Private components As System.ComponentModel.IContainer = Nothing

	Public Sub New()
		InitializeComponent()
	End Sub

	''' <summary> 
	''' Clean up any resources being used.
	''' </summary>
	''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
	Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
		If disposing AndAlso (components IsNot Nothing) Then
			components.Dispose()
		End If
		MyBase.Dispose(disposing)
	End Sub

	#Region "Designer generated code"

	''' <summary>
	''' Required method for Designer support - do not modify
	''' the contents of this method with the code editor.
	''' </summary>
	Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.lbUnitPrice = New DevExpress.XtraReports.UI.XRLabel()
			Me.hlProductName = New E4931.XRHyperlink()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.nWindDataSet1 = New NWindDataSet()
        Me.productsTableAdapter = New NWindDataSetTableAdapters.ProductsTableAdapter()
			Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
			Me.lbHeader = New DevExpress.XtraReports.UI.XRLabel()
			CType(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbUnitPrice, Me.hlProductName})
			Me.Detail.HeightF = 25F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' lbUnitPrice
			' 
			Me.lbUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.UnitPrice", "{0:c}")})
			Me.lbUnitPrice.Font = New System.Drawing.Font("Times New Roman", 14F)
			Me.lbUnitPrice.LocationFloat = New DevExpress.Utils.PointFloat(501.6667F, 0F)
			Me.lbUnitPrice.Name = "lbUnitPrice"
			Me.lbUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbUnitPrice.SizeF = New System.Drawing.SizeF(138.3332F, 25F)
			Me.lbUnitPrice.StylePriority.UseFont = False
			Me.lbUnitPrice.StylePriority.UseTextAlignment = False
			Me.lbUnitPrice.Text = "lbUnitPrice"
			Me.lbUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' hlProductName
			' 
			Me.hlProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Products.ProductName"), New DevExpress.XtraReports.UI.XRBinding("NavigateUrl", Nothing, "Products.ProductID", "javascript:void({0})")})
			Me.hlProductName.Font = New System.Drawing.Font("Times New Roman", 12F)
			Me.hlProductName.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 0F)
			Me.hlProductName.Name = "hlProductName"
			Me.hlProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.hlProductName.SizeF = New System.Drawing.SizeF(491.6667F, 25F)
			Me.hlProductName.StylePriority.UseFont = False
			Me.hlProductName.StylePriority.UseTextAlignment = False
			Me.hlProductName.Text = "hlProductName"
			Me.hlProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' nWindDataSet1
			' 
			Me.nWindDataSet1.DataSetName = "NWindDataSet"
			Me.nWindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' productsTableAdapter
			' 
			Me.productsTableAdapter.ClearBeforeFill = True
			' 
			' ReportHeader
			' 
			Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbHeader})
			Me.ReportHeader.Name = "ReportHeader"
			' 
			' lbHeader
			' 
			Me.lbHeader.Font = New System.Drawing.Font("Times New Roman", 36F)
			Me.lbHeader.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.lbHeader.Name = "lbHeader"
			Me.lbHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
			Me.lbHeader.SizeF = New System.Drawing.SizeF(630F, 79.99998F)
			Me.lbHeader.StylePriority.UseFont = False
			Me.lbHeader.StylePriority.UseTextAlignment = False
			Me.lbHeader.Text = "Sample Report"
			Me.lbHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
			' 
			' SampleReport
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.ReportHeader})
			Me.DataAdapter = Me.productsTableAdapter
			Me.DataMember = "Products"
			Me.DataSource = Me.nWindDataSet1
			Me.Version = "13.1"
			CType(Me.nWindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

	End Sub

	#End Region
End Class
