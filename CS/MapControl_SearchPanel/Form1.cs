using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace MapControl_SearchPanel {
    public partial class Form1 : Form {
        InformationLayer SearchLayer { get { return (InformationLayer)mapControl1.Layers["SearchLayer"]; } }
        BingSearchDataProvider SearchProvider { get { return (BingSearchDataProvider)SearchLayer.DataProvider; } }

        public Form1() {
            InitializeComponent();
            SearchLayer.DataRequestCompleted += SearchLayer_DataRequestCompleted;
        }

        void SearchLayer_DataRequestCompleted(object sender, RequestCompletedEventArgs e) {
            mapControl1.ZoomToFitLayerItems();
        }

        private void bSearch_Click(object sender, EventArgs e) {
            SearchProvider.Search(teKeyword.Text);
        }
    }
}
