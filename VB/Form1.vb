Imports Microsoft.VisualBasic
Imports DevExpress.XtraMap
Imports System
Imports System.Windows.Forms

Namespace MapSearchExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			' Specify the Bing key for a Bing search data provider.
			SearchProvider.BingKey = "INSERT_YOUR_BING_KEY_HERE"

			' Disable the built-in search panel.
			SearchProvider.ShowSearchPanel = False

			' Handle the SearchCompleted event. 
			AddHandler SearchProvider.SearchCompleted, AddressOf OnSearchCompleted
		End Sub

		Protected ReadOnly Property SearchLayer() As InformationLayer
			Get
				Return CType(mapControl1.Layers(1), InformationLayer)
			End Get
		End Property
		Protected ReadOnly Property SearchProvider() As BingSearchDataProvider
			Get
				Return CType(SearchLayer.DataProvider, BingSearchDataProvider)
			End Get
		End Property

		Private Sub btnGo_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnGo.Click
			SearchProvider.Search(txtCityName.Text)
		End Sub

		Private Sub OnSearchCompleted(ByVal sender As Object, ByVal e As BingSearchCompletedEventArgs)
			If e.Error IsNot Nothing OrElse e.Cancelled Then
				Return
			End If

			Dim result As SearchRequestResult = e.RequestResult
			If result.ResultCode = RequestResultCode.Success Then
				Dim region As LocationInformation = result.SearchRegion

				If region IsNot Nothing Then
					NavigateTo(region.Location)
				Else
					If result.SearchResults.Count > 0 Then
						NavigateTo(result.SearchResults(0).Location)
					End If
				End If
			End If

			If result.ResultCode = RequestResultCode.BadRequest Then
				MessageBox.Show("The Bing Search service does not work for this location.")
			End If
		End Sub

		Private Sub NavigateTo(ByVal geoPoint As GeoPoint)
			mapControl1.CenterPoint = geoPoint
		End Sub
	End Class
End Namespace