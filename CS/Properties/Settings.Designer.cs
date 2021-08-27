﻿// Developer Express Code Central Example:
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

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MapSearchExample.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
    }
}