Namespace MapControl_SearchPanel
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
            Me.imageTilesLayer3 = New DevExpress.XtraMap.ImageLayer()
            Me.bingMapDataProvider3 = New DevExpress.XtraMap.BingMapDataProvider()
            Me.informationLayer3 = New DevExpress.XtraMap.InformationLayer()
            Me.bingSearchDataProvider3 = New DevExpress.XtraMap.BingSearchDataProvider()
            Me.layoutControl1 = New DevExpress.XtraLayout.LayoutControl()
            Me.bSearch = New System.Windows.Forms.Button()
            Me.teKeyword = New DevExpress.XtraEditors.TextEdit()
            Me.mapControl1 = New DevExpress.XtraMap.MapControl()
            Me.layoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.layoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.lciKeyword = New DevExpress.XtraLayout.LayoutControlItem()
            Me.layoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.layoutControl1.SuspendLayout()
            DirectCast(Me.teKeyword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.lciKeyword, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' imageTilesLayer3
            ' 
            Me.imageTilesLayer3.DataProvider = Me.bingMapDataProvider3
            ' 
            ' informationLayer3
            ' 
            Me.informationLayer3.DataProvider = Me.bingSearchDataProvider3
            Me.informationLayer3.Name = "SearchLayer"
            ' 
            ' layoutControl1
            ' 
            Me.layoutControl1.Controls.Add(Me.bSearch)
            Me.layoutControl1.Controls.Add(Me.teKeyword)
            Me.layoutControl1.Controls.Add(Me.mapControl1)
            Me.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.layoutControl1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControl1.Name = "layoutControl1"
            Me.layoutControl1.Root = Me.layoutControlGroup1
            Me.layoutControl1.Size = New System.Drawing.Size(624, 441)
            Me.layoutControl1.TabIndex = 0
            Me.layoutControl1.Text = "layoutControl1"
            ' 
            ' bSearch
            ' 
            Me.bSearch.Location = New System.Drawing.Point(365, 4)
            Me.bSearch.Name = "bSearch"
            Me.bSearch.Size = New System.Drawing.Size(255, 20)
            Me.bSearch.TabIndex = 3
            Me.bSearch.Text = "Search"
            Me.bSearch.UseVisualStyleBackColor = True
            ' 
            ' teKeyword
            ' 
            Me.teKeyword.Location = New System.Drawing.Point(53, 4)
            Me.teKeyword.Name = "teKeyword"
            Me.teKeyword.Size = New System.Drawing.Size(308, 20)
            Me.teKeyword.StyleController = Me.layoutControl1
            Me.teKeyword.TabIndex = 1
            ' 
            ' mapControl1
            ' 
            Me.mapControl1.Layers.Add(Me.imageTilesLayer3)
            Me.mapControl1.Layers.Add(Me.informationLayer3)
            Me.mapControl1.Location = New System.Drawing.Point(4, 28)
            Me.mapControl1.Name = "mapControl1"
            Me.mapControl1.ShowSearchPanel = False
            Me.mapControl1.Size = New System.Drawing.Size(616, 409)
            Me.mapControl1.TabIndex = 0
            ' 
            ' layoutControlGroup1
            ' 
            Me.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True
            Me.layoutControlGroup1.GroupBordersVisible = False
            Me.layoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutControlItem1, Me.lciKeyword, Me.layoutControlItem2})
            Me.layoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.layoutControlGroup1.Name = "layoutControlGroup1"
            Me.layoutControlGroup1.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
            Me.layoutControlGroup1.Size = New System.Drawing.Size(624, 441)
            Me.layoutControlGroup1.TextVisible = False
            ' 
            ' layoutControlItem1
            ' 
            Me.layoutControlItem1.Control = Me.mapControl1
            Me.layoutControlItem1.Location = New System.Drawing.Point(0, 24)
            Me.layoutControlItem1.Name = "layoutControlItem1"
            Me.layoutControlItem1.Size = New System.Drawing.Size(620, 413)
            Me.layoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem1.TextVisible = False
            ' 
            ' lciKeyword
            ' 
            Me.lciKeyword.Control = Me.teKeyword
            Me.lciKeyword.Location = New System.Drawing.Point(0, 0)
            Me.lciKeyword.Name = "lciKeyword"
            Me.lciKeyword.Size = New System.Drawing.Size(361, 24)
            Me.lciKeyword.Text = "Keyword:"
            Me.lciKeyword.TextSize = New System.Drawing.Size(46, 13)
            ' 
            ' layoutControlItem2
            ' 
            Me.layoutControlItem2.Control = Me.bSearch
            Me.layoutControlItem2.Location = New System.Drawing.Point(361, 0)
            Me.layoutControlItem2.Name = "layoutControlItem2"
            Me.layoutControlItem2.Size = New System.Drawing.Size(259, 24)
            Me.layoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
            Me.layoutControlItem2.TextVisible = False
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(624, 441)
            Me.Controls.Add(Me.layoutControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.layoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.layoutControl1.ResumeLayout(False)
            DirectCast(Me.teKeyword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.mapControl1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.lciKeyword, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.layoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private layoutControl1 As DevExpress.XtraLayout.LayoutControl
        Private layoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Private WithEvents bSearch As System.Windows.Forms.Button
        Private teKeyword As DevExpress.XtraEditors.TextEdit
        Private mapControl1 As DevExpress.XtraMap.MapControl
        Private layoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Private lciKeyword As DevExpress.XtraLayout.LayoutControlItem
        Private layoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
        Private imageTilesLayer3 As DevExpress.XtraMap.ImageLayer
        Private bingMapDataProvider3 As DevExpress.XtraMap.BingMapDataProvider
        Private informationLayer3 As DevExpress.XtraMap.InformationLayer
        Private bingSearchDataProvider3 As DevExpress.XtraMap.BingSearchDataProvider

    End Class
End Namespace

