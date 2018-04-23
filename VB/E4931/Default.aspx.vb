Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.IO
Imports DevExpress.XtraReports.Web

Namespace E4931
	Partial Public Class [Default]
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)

		End Sub

		Protected Sub SampleReportViewer_CacheReportDocument(ByVal sender As Object, ByVal e As CacheReportDocumentEventArgs)
			Session("DocumentCache") = e.SaveDocumentToMemoryStream()
		End Sub

		Protected Sub SampleReportViewer_RestoreReportDocumentFromCache(ByVal sender As Object, ByVal e As RestoreReportDocumentFromCacheEventArgs)
			Dim documentCache As Stream = CType(Session("DocumentCache"), Stream)
			If documentCache IsNot Nothing Then
				e.RestoreDocumentFromStream(documentCache)
			End If
		End Sub
	End Class
End Namespace