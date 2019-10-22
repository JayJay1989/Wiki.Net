﻿#region

using System;
using Newtonsoft.Json;

#endregion

namespace CreepysinStudios.WikiDotNet
{
	/// <summary>
	///     A single search result from a wikipedia search
	/// </summary>

	//Todo Add what categories the article falls into
	//!Make things readonly if possible
	public sealed class WikiSearchResult
	{
		/// <summary>
		///     The last time this page was edited
		/// </summary>
		[JsonProperty("timestamp")] public readonly DateTime LastEdited;

		/// <summary>
		///     The numerical ID that corresponds internally (in Wikipedia's servers) to this page
		/// </summary>
		[JsonProperty("pageid")] public readonly int PageId;

		/// <summary>
		///     A preview of the page
		/// </summary>
		[JsonProperty("snippet")] public readonly string Preview;

		/// <summary>
		///     (Possibly) How large the entire page is (assumed in bytes). Unknown what this actually is/does.
		/// </summary>
		[JsonProperty("size")] public readonly int Size;

		/// <summary>
		///     The title of this page
		/// </summary>
		[JsonProperty("title")] public readonly string Title;

		/// <summary>
		///     How many words are in the article
		/// </summary>
		[JsonProperty("wordcount")] public readonly int WordCount;

		/// <summary>
		///     The URL that can be used to access the article online. Created using the Page ID
		/// </summary>
		public string Url => $"https://en.wikipedia.org/?curid={PageId}";
	}
}