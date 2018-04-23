Imports Microsoft.VisualBasic
Imports System
Imports System.Web
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraPrinting.BrickExporters
Imports DevExpress.XtraPrinting.Native
Imports DevExpress.XtraPrinting.Export
Imports DevExpress.XtraReports.UI

Namespace E4931
	Friend Class HyperlinkBrickExporter
		Inherits LabelBrickExporter
		Protected ReadOnly Property HyperlinkBrick() As HyperlinkBrick
			Get
				Return TryCast(Brick, HyperlinkBrick)
			End Get
		End Property

		Protected Overrides Sub FillHtmlTableCellCore(ByVal exportProvider As IHtmlExportProvider)
			exportProvider.CurrentCell.InnerHtml = String.Format("<a href='{1}' target='{2}'>{0}</a>", HttpUtility.HtmlEncode(HyperlinkBrick.Text), HyperlinkBrick.Url, HyperlinkBrick.Target)
		End Sub
	End Class

	<BrickExporter(GetType(HyperlinkBrickExporter))> _
	Public Class HyperlinkBrick
		Inherits LabelBrick
		Public Shared HyperlinkBrickTypeName As String = "Hyperlink"

		Shared Sub New()
			BrickFactory.RegisterFactory(HyperlinkBrickTypeName, New DefaultBrickFactory(Of HyperlinkBrick)())
		End Sub

		Public Sub New()
			MyBase.New()
		End Sub

		Public Sub New(ByVal owner As IBrickOwner)
			MyBase.New(owner)
		End Sub

		Public Overrides ReadOnly Property BrickType() As String
			Get
				Return HyperlinkBrickTypeName
			End Get
		End Property
	End Class

	Public Class XRHyperlink
		Inherits XRLabel
		Protected Overrides Function CreateBrick(ByVal childrenBricks() As VisualBrick) As VisualBrick
			Return New HyperlinkBrick(Me)
		End Function
	End Class
End Namespace