' Developer Express Code Central Example:
' How to search for a location on a map using a custom search panel
' 
' This example demonstrates how to find a city on a map using the Microsoft Bing
' Search data service. Note that the built-in search panel is not applicable in
' this example, so the BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false.
' To find a city on the map, type it in the custom
' search panel and click the Go button. A search location parameter is passed to
' the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic1466)
' method, and you can see a desired location on the map. Note that there are 5
' overloads for the Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method, depending on your search criteria.
' 
' If you run this sample as is, you
' will get a warning message stating that the specified Bing Maps key is invalid.
' To learn about how to register a Bing Maps account and create a key for it,
' refer to How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5084

' Developer Express Code Central Example:
' How to search for a location on a map using a custom search panel
' 
' This example demonstrates how to find a city on a map using the Microsoft Bing
' Search data service.  Note that the built-in search panel is not applicable in
' this example, so the BingSearchDataProvider.ShowSearchPanel
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
' property is set to false.
' To find a city on the map, type it in the custom
' search panel and click the Go button. This handles the btnGo_Click event. A
' search location parameter is passed to the BingSearchDataProvider.Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic1466)
' method, and you can see a desired location on the map. Note that there are 5
' overloads for the Search
' (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
' method, depending on your search criteria.
' 
' If you run this sample as is, you
' will get a warning message stating that the specified Bing Maps key is invalid.
' To learn about how to register a Bing Maps account and create a key for it,
' refer to How to: Get a Bing Maps Key
' (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
' tutorial.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E5084


Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraMap
Namespace MapSearchExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim imageTilesLayer2 As New DevExpress.XtraMap.ImageTilesLayer()
			Dim openStreetMapDataProvider2 As New DevExpress.XtraMap.OpenStreetMapDataProvider()
			Dim informationLayer2 As New DevExpress.XtraMap.InformationLayer()
			Dim bingSearchDataProvider2 As New DevExpress.XtraMap.BingSearchDataProvider()
			Me.mapControl1 = New DevExpress.XtraMap.MapControl()
			Me.panel1 = New System.Windows.Forms.Panel()
			Me.lbLocation = New System.Windows.Forms.Label()
			Me.btnGo = New System.Windows.Forms.Button()
			Me.txtCityName = New System.Windows.Forms.TextBox()
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.panel1.SuspendLayout()
			Me.SuspendLayout()
			' 
			' mapControl1
			' 
			Me.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill
			imageTilesLayer2.DataProvider = openStreetMapDataProvider2
			informationLayer2.DataProvider = bingSearchDataProvider2
			Me.mapControl1.Layers.Add(imageTilesLayer2)
			Me.mapControl1.Layers.Add(informationLayer2)
			Me.mapControl1.Location = New System.Drawing.Point(0, 56)
			Me.mapControl1.LookAndFeel.SkinName = "VS2010"
			Me.mapControl1.LookAndFeel.UseDefaultLookAndFeel = False
			Me.mapControl1.Name = "mapControl1"
			Me.mapControl1.Size = New System.Drawing.Size(943, 560)
			Me.mapControl1.TabIndex = 0
			Me.mapControl1.CenterPoint = New GeoPoint(42.363236, -71.057853)

			Me.mapControl1.ZoomLevel = 11R
			' 
			' panel1
			' 
			Me.panel1.Controls.Add(Me.txtCityName)
			Me.panel1.Controls.Add(Me.btnGo)
			Me.panel1.Controls.Add(Me.lbLocation)
			Me.panel1.Dock = System.Windows.Forms.DockStyle.Top
			Me.panel1.Location = New System.Drawing.Point(0, 0)
			Me.panel1.Name = "panel1"
			Me.panel1.Size = New System.Drawing.Size(943, 56)
			Me.panel1.TabIndex = 1
			' 
			' lbLocation
			' 
			Me.lbLocation.AutoSize = True
			Me.lbLocation.Location = New System.Drawing.Point(16, 17)
			Me.lbLocation.Name = "lbLocation"
			Me.lbLocation.Size = New System.Drawing.Size(107, 13)
			Me.lbLocation.TabIndex = 0
			Me.lbLocation.Text = "Enter search location"
			' 
			' btnGo
			' 
			Me.btnGo.Location = New System.Drawing.Point(381, 12)
			Me.btnGo.Name = "btnGo"
			Me.btnGo.Size = New System.Drawing.Size(75, 23)
			Me.btnGo.TabIndex = 1
			Me.btnGo.Text = "Go"
			Me.btnGo.UseVisualStyleBackColor = True
'			Me.btnGo.Click += New System.EventHandler(Me.btnGo_Click);
			' 
			' txtCityName
			' 
			Me.txtCityName.Location = New System.Drawing.Point(129, 14)
			Me.txtCityName.Name = "txtCityName"
			Me.txtCityName.Size = New System.Drawing.Size(246, 20)
			Me.txtCityName.TabIndex = 2
			Me.txtCityName.Text = "Los-Angeles"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(943, 616)
			Me.Controls.Add(Me.mapControl1)
			Me.Controls.Add(Me.panel1)
			Me.Name = "Form1"
			Me.Text = "Map Searching"
			CType(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.panel1.ResumeLayout(False)
			Me.panel1.PerformLayout()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private mapControl1 As DevExpress.XtraMap.MapControl
		Private panel1 As System.Windows.Forms.Panel
		Private txtCityName As System.Windows.Forms.TextBox
		Private WithEvents btnGo As System.Windows.Forms.Button
		Private lbLocation As System.Windows.Forms.Label




	End Class
End Namespace

