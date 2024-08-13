<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576270/22.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5084)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Map for WinForms - How to Create a Custom Search Panel

This example shows how to use the Microsoft Bing Search data service to find a location on a map.

If you run this sample as is, you get a warning message stating that the specified Bing Maps key is invalid. Register your Bing Maps account, create a key for it, and add the generated key to the [BingMapDataProvider.BingKey](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.BingMapDataProvider.BingKey) property:

```cs
public Form1() {
	InitializeComponent();
	// ...
	mapControl1.Layers.Add(new ImageLayer() {
		DataProvider = new BingMapDataProvider() {
			BingKey = "YOUR BING KEY",
			Kind = BingMapKind.Area
		}
	});
}
```

> See the following article for details: [How to get a Bing Maps key](https://docs.devexpress.com/WindowsForms/15102/controls-and-libraries/map-control/examples/general/how-to-get-a-bing-maps-key).

The built-in search panel is not used in this example, so the [MapControl.SearchPanelOptions.Visible](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.MapSearchPanelOptions.Visible) property is set to `false`.

A search location parameter is passed to the [BingSearchDataProvider.Search](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.BingSearchDataProvider.Search.overloads) method, and you can see a desired location on the map. You can select from the overloads for the `Search()` method depending on your search criteria.

## Files to Review

* [Form1.cs](./CS/MapControl_SearchPanel/Form1.cs) (VB: [Form1.vb](./VB/MapControl_SearchPanel/Form1.vb))

## Documentation

- [BingSearchDataProvider.Search](https://docs.devexpress.com/WindowsForms/DevExpress.XtraMap.BingSearchDataProvider.Search.overloads)
- [How to get a Bing Maps key](https://docs.devexpress.com/WindowsForms/15102/controls-and-libraries/map-control/examples/general/how-to-get-a-bing-maps-key)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-create-a-custom-search-panel-e5084&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=how-to-create-a-custom-search-panel-e5084&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
