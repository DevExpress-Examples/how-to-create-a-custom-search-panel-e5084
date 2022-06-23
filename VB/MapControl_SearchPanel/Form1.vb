Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace MapControl_SearchPanel

    Public Partial Class Form1
        Inherits Form

        Private ReadOnly Property SearchLayer As InformationLayer
            Get
                Return CType(mapControl1.Layers("SearchLayer"), InformationLayer)
            End Get
        End Property

        Private ReadOnly Property SearchProvider As BingSearchDataProvider
            Get
                Return CType(SearchLayer.DataProvider, BingSearchDataProvider)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
            AddHandler SearchLayer.DataRequestCompleted, AddressOf SearchLayer_DataRequestCompleted
            ' 
            mapControl1.Layers.Add(New ImageLayer() With {.DataProvider = New BingMapDataProvider() With {.BingKey = "YOUR BING KEY", .Kind = BingMapKind.Area}})
        End Sub

        Private Sub SearchLayer_DataRequestCompleted(ByVal sender As Object, ByVal e As RequestCompletedEventArgs)
            mapControl1.ZoomToFitLayerItems()
        End Sub

        Private Sub bSearch_Click(ByVal sender As Object, ByVal e As EventArgs)
            SearchProvider.Search(teKeyword.Text)
        End Sub
    End Class
End Namespace
