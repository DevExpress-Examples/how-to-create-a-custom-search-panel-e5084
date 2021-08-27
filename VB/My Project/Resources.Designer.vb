﻿' Developer Express Code Central Example:
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

'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.18051
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System
Namespace My


	''' <summary>
	'''   A strongly-typed resource class, for looking up localized strings, etc.
	''' </summary>
	' This class was auto-generated by the StronglyTypedResourceBuilder
	' class via a tool like ResGen or Visual Studio.
	' To add or remove a member, edit your .ResX file then rerun ResGen
	' with the /str option, or rebuild your VS project.
	<Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0"), Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
	Friend Class Resources

		Private Shared resourceMan As Global.System.Resources.ResourceManager

		Private Shared resourceCulture As Global.System.Globalization.CultureInfo

		<Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")> _
		Friend Sub New()
		End Sub

		''' <summary>
		'''   Returns the cached ResourceManager instance used by this class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
			Get
				If Object.ReferenceEquals(resourceMan, Nothing) Then
					Dim temp As New Global.System.Resources.ResourceManager("Resources", GetType(Resources).Assembly)
					resourceMan = temp
				End If
				Return resourceMan
			End Get
		End Property

		''' <summary>
		'''   Overrides the current thread's CurrentUICulture property for all
		'''   resource lookups using this strongly typed resource class.
		''' </summary>
		<Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
			Get
				Return resourceCulture
			End Get
			Set(ByVal value As System.Globalization.CultureInfo)
				resourceCulture = value
			End Set
		End Property
	End Class
End Namespace