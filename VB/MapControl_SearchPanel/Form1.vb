Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace MapControl_SearchPanel
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly Property SearchLayer() As InformationLayer
            Get
                Return CType(mapControl1.Layers("SearchLayer"), InformationLayer)
            End Get
        End Property
        Private ReadOnly Property SearchProvider() As BingSearchDataProvider
            Get
                Return CType(SearchLayer.DataProvider, BingSearchDataProvider)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler SearchLayer.DataRequestCompleted, AddressOf SearchLayer_DataRequestCompleted
        End Sub

        Private Sub SearchLayer_DataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl1.ZoomToFitLayerItems()
        End Sub

        Private Sub bSearch_Click(ByVal sender As Object, ByVal e As EventArgs) Handles bSearch.Click
            SearchProvider.Search(teKeyword.Text)
        End Sub
    End Class
End Namespace
