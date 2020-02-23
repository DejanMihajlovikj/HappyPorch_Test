//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace UmbracoTestProject.Core.Models
{
	/// <summary>Blogpost</summary>
	[PublishedContentModel("blogpost")]
	public partial class Blogpost : PublishedContentModel, INavigationBase
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "blogpost";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Blogpost(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Blogpost, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Content
		///</summary>
		[ImplementPropertyType("bodyText")]
		public Newtonsoft.Json.Linq.JToken BodyText
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("bodyText"); }
		}

		///<summary>
		/// Categories (tags)
		///</summary>
		[ImplementPropertyType("categories")]
		public IEnumerable<string> Categories
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("categories"); }
		}

		///<summary>
		/// Display Date
		///</summary>
		[ImplementPropertyType("displayDate")]
		public DateTime DisplayDate
		{
			get { return this.GetPropertyValue<DateTime>("displayDate"); }
		}

		///<summary>
		/// Excerpt: Introduction to your blog post. This is also used in the summaries on the front of the blog as well as the homepage
		///</summary>
		[ImplementPropertyType("excerpt")]
		public string Excerpt
		{
			get { return this.GetPropertyValue<string>("excerpt"); }
		}

		///<summary>
		/// Page Title: The title of the page, this is also the first text in a google search result. The ideal length is between 40 and 60 characters
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return this.GetPropertyValue<string>("pageTitle"); }
		}

		///<summary>
		/// Keywords: Keywords that describe the content of the page. This is consired optional since most modern search engines don't use this anymore
		///</summary>
		[ImplementPropertyType("keywords")]
		public IEnumerable<string> Keywords
		{
			get { return UmbracoTestProject.Core.Models.NavigationBase.GetKeywords(this); }
		}

		///<summary>
		/// Description: A brief description of the content on your page. This text is shown below the title in a google search result and also used for Social Sharing Cards. The ideal length is between 130 and 155 characters
		///</summary>
		[ImplementPropertyType("seoMetaDescription")]
		public string SeoMetaDescription
		{
			get { return UmbracoTestProject.Core.Models.NavigationBase.GetSeoMetaDescription(this); }
		}

		///<summary>
		/// Hide in Navigation: If you don't want this page to appear in the navigation, check this box
		///</summary>
		[ImplementPropertyType("umbracoNavihide")]
		public bool UmbracoNavihide
		{
			get { return UmbracoTestProject.Core.Models.NavigationBase.GetUmbracoNavihide(this); }
		}
	}
}