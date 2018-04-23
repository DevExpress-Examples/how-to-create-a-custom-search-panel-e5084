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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapSearchExample {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
