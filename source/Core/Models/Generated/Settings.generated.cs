//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v8.8.0
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
using Umbraco.ModelsBuilder.Embedded;

namespace Our.Umbraco.NonProfitFramework.Core.Models
{
	// Mixin Content Type with alias "settings"
	/// <summary>Settings</summary>
	public partial interface ISettings : IPublishedContent
	{
		/// <summary>Redir</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		global::Umbraco.Core.Models.PublishedContent.IPublishedContent UmbracoInternalRedirectId { get; }
	}

	/// <summary>Settings</summary>
	[PublishedModel("settings")]
	public partial class Settings : PublishedContentModel, ISettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const string ModelTypeAlias = "settings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Settings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public Settings(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Redir
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		[ImplementPropertyType("umbracoInternalRedirectId")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent UmbracoInternalRedirectId => GetUmbracoInternalRedirectId(this);

		/// <summary>Static getter for Redir</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "8.8.0")]
		public static global::Umbraco.Core.Models.PublishedContent.IPublishedContent GetUmbracoInternalRedirectId(ISettings that) => that.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("umbracoInternalRedirectId");
	}
}
