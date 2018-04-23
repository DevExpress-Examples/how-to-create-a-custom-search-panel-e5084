
using DevExpress.XtraMap;
using System;
using System.Windows.Forms;

namespace MapSearchExample {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            // Specify the Bing key for a Bing search data provider.
            SearchProvider.BingKey = "INSERT_YOUR_BING_KEY_HERE";

            // Disable the built-in search panel.
            SearchProvider.ShowSearchPanel = false;

            // Handle the SearchCompleted event. 
            SearchProvider.SearchCompleted += OnSearchCompleted;
        }

        protected InformationLayer SearchLayer {
            get { return (InformationLayer)mapControl1.Layers[1]; }
        }
        protected BingSearchDataProvider SearchProvider {
            get { return (BingSearchDataProvider)SearchLayer.DataProvider; }
        }

        private void btnGo_Click(object sender, EventArgs e) {
            SearchProvider.Search(txtCityName.Text);
        }

        void OnSearchCompleted(object sender, BingSearchCompletedEventArgs e) {
            if (e.Error != null || e.Cancelled)
                return;

            SearchRequestResult result = e.RequestResult;
            if (result.ResultCode == RequestResultCode.Success) {
                LocationInformation region = result.SearchRegion;

                if (region != null) {
                    NavigateTo(region.Location);
                }
                else {
                    if (result.SearchResults.Count > 0)
                        NavigateTo(result.SearchResults[0].Location);
                }
            }

            if (result.ResultCode == RequestResultCode.BadRequest)
                MessageBox.Show("The Bing Search service does not work for this location.");
        }

        void NavigateTo(GeoPoint geoPoint) {
            mapControl1.CenterPoint = geoPoint;
        }
    }
}