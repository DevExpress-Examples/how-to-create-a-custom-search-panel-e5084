// Developer Express Code Central Example:
// How to search for a location on a map using a custom search panel
// 
// This example demonstrates how to find a city on a map using the Microsoft Bing
// Search data service. Note that the built-in search panel is not applicable in
// this example, so the BingSearchDataProvider.ShowSearchPanel
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
// property is set to false.
// To find a city on the map, type it in the custom
// search panel and click the Go button. A search location parameter is passed to
// the BingSearchDataProvider.Search
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic1466)
// method, and you can see a desired location on the map. Note that there are 5
// overloads for the Search
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
// method, depending on your search criteria.
// 
// If you run this sample as is, you
// will get a warning message stating that the specified Bing Maps key is invalid.
// To learn about how to register a Bing Maps account and create a key for it,
// refer to How to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5084

// Developer Express Code Central Example:
// How to search for a location on a map using a custom search panel
// 
// This example demonstrates how to find a city on a map using the Microsoft Bing
// Search data service.  Note that the built-in search panel is not applicable in
// this example, so the BingSearchDataProvider.ShowSearchPanel
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_ShowSearchPaneltopic)
// property is set to false.
// To find a city on the map, type it in the custom
// search panel and click the Go button. This handles the btnGo_Click event. A
// search location parameter is passed to the BingSearchDataProvider.Search
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic1466)
// method, and you can see a desired location on the map. Note that there are 5
// overloads for the Search
// (http://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingSearchDataProvider_Searchtopic)
// method, depending on your search criteria.
// 
// If you run this sample as is, you
// will get a warning message stating that the specified Bing Maps key is invalid.
// To learn about how to register a Bing Maps account and create a key for it,
// refer to How to: Get a Bing Maps Key
// (http://documentation.devexpress.com/#WindowsForms/CustomDocument15102)
// tutorial.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E5084

using DevExpress.XtraMap;
namespace MapSearchExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer2 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider2 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            DevExpress.XtraMap.InformationLayer informationLayer2 = new DevExpress.XtraMap.InformationLayer();
            DevExpress.XtraMap.BingSearchDataProvider bingSearchDataProvider2 = new DevExpress.XtraMap.BingSearchDataProvider();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbLocation = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.txtCityName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            imageTilesLayer2.DataProvider = openStreetMapDataProvider2;         
            informationLayer2.DataProvider = bingSearchDataProvider2;
            this.mapControl1.Layers.Add(imageTilesLayer2);
            this.mapControl1.Layers.Add(informationLayer2);
            this.mapControl1.Location = new System.Drawing.Point(0, 56);
            this.mapControl1.LookAndFeel.SkinName = "VS2010";
            this.mapControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(943, 560);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.CenterPoint = new GeoPoint(42.363236, -71.057853);

            this.mapControl1.ZoomLevel = 11D;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCityName);
            this.panel1.Controls.Add(this.btnGo);
            this.panel1.Controls.Add(this.lbLocation);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(943, 56);
            this.panel1.TabIndex = 1;
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(16, 17);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(107, 13);
            this.lbLocation.TabIndex = 0;
            this.lbLocation.Text = "Enter search location";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(381, 12);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 23);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // txtCityName
            // 
            this.txtCityName.Location = new System.Drawing.Point(129, 14);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Size = new System.Drawing.Size(246, 20);
            this.txtCityName.TabIndex = 2;
            this.txtCityName.Text = "Los-Angeles";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 616);
            this.Controls.Add(this.mapControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Map Searching";
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtCityName;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Label lbLocation;




    }
}

