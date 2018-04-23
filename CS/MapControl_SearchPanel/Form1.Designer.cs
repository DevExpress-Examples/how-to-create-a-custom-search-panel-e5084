namespace MapControl_SearchPanel {
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
            if (disposing && (components != null)) {
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
            DevExpress.XtraMap.ImageTilesLayer imageTilesLayer3 = new DevExpress.XtraMap.ImageTilesLayer();
            DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider3 = new DevExpress.XtraMap.BingMapDataProvider();
            DevExpress.XtraMap.InformationLayer informationLayer3 = new DevExpress.XtraMap.InformationLayer();
            DevExpress.XtraMap.BingSearchDataProvider bingSearchDataProvider3 = new DevExpress.XtraMap.BingSearchDataProvider();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.bSearch = new System.Windows.Forms.Button();
            this.teKeyword = new DevExpress.XtraEditors.TextEdit();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciKeyword = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.teLocation = new DevExpress.XtraEditors.TextEdit();
            this.lciLocation = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teKeyword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKeyword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocation.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLocation)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.teLocation);
            this.layoutControl1.Controls.Add(this.bSearch);
            this.layoutControl1.Controls.Add(this.teKeyword);
            this.layoutControl1.Controls.Add(this.mapControl1);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = true;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.layoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(624, 441);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(504, 4);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(116, 20);
            this.bSearch.TabIndex = 3;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // teKeyword
            // 
            this.teKeyword.Location = new System.Drawing.Point(53, 4);
            this.teKeyword.Name = "teKeyword";
            this.teKeyword.Size = new System.Drawing.Size(197, 20);
            this.teKeyword.StyleController = this.layoutControl1;
            this.teKeyword.TabIndex = 1;
            // 
            // mapControl1
            // 
            imageTilesLayer3.DataProvider = bingMapDataProvider3;
            bingSearchDataProvider3.ShowSearchPanel = false;
            informationLayer3.DataProvider = bingSearchDataProvider3;
            informationLayer3.Name = "SearchLayer";
            this.mapControl1.Layers.Add(imageTilesLayer3);
            this.mapControl1.Layers.Add(informationLayer3);
            this.mapControl1.Location = new System.Drawing.Point(4, 28);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.Size = new System.Drawing.Size(616, 409);
            this.mapControl1.TabIndex = 0;
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.lciKeyword,
            this.layoutControlItem2,
            this.lciLocation});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.layoutControlGroup1.Size = new System.Drawing.Size(624, 441);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.mapControl1;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(620, 413);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // lciKeyword
            // 
            this.lciKeyword.Control = this.teKeyword;
            this.lciKeyword.Location = new System.Drawing.Point(0, 0);
            this.lciKeyword.Name = "lciKeyword";
            this.lciKeyword.Size = new System.Drawing.Size(250, 24);
            this.lciKeyword.Text = "Keyword:";
            this.lciKeyword.TextSize = new System.Drawing.Size(46, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.bSearch;
            this.layoutControlItem2.Location = new System.Drawing.Point(500, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(120, 24);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // teLocation
            // 
            this.teLocation.Location = new System.Drawing.Point(303, 4);
            this.teLocation.Name = "teLocation";
            this.teLocation.Size = new System.Drawing.Size(197, 20);
            this.teLocation.StyleController = this.layoutControl1;
            this.teLocation.TabIndex = 2;
            // 
            // lciLocation
            // 
            this.lciLocation.Control = this.teLocation;
            this.lciLocation.Location = new System.Drawing.Point(250, 0);
            this.lciLocation.Name = "lciLocation";
            this.lciLocation.Size = new System.Drawing.Size(250, 24);
            this.lciLocation.Text = "Location:";
            this.lciLocation.TextSize = new System.Drawing.Size(46, 13);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teKeyword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciKeyword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLocation.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLocation)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private System.Windows.Forms.Button bSearch;
        private DevExpress.XtraEditors.TextEdit teKeyword;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciKeyword;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.TextEdit teLocation;
        private DevExpress.XtraLayout.LayoutControlItem lciLocation;

    }
}

