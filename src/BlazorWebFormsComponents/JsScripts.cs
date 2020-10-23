namespace BlazorWebFormsComponents
{

	/// <summary>
	/// A collection of the names of the JavaScript scripts available in
	/// the project so that we do not pass magic strings around
	/// </summary>
	internal static class JsScripts
	{
		/// <summary>
		/// Scripts that run in the Page JavaScript object
		/// </summary>
		internal static class Page
		{
			/// <summary>
			/// Reference to JS file that contains the Page scripts
			/// </summary>
			public const string ScriptURI = "./_content/Fritz.BlazorWebFormsComponents/js/Basepage.js";

			/// <summary>
			/// Script to be run after the page is rendered
			/// </summary>
			public static readonly string OnAfterRender = "OnAfterRender";

		}

	}
}
