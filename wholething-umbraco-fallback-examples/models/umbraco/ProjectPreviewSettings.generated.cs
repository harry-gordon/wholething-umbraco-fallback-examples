//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Cms.Core.PublishedCache;
using Umbraco.Cms.Infrastructure.ModelsBuilder;
using Umbraco.Cms.Core;
using Umbraco.Extensions;

namespace Umbraco.Cms.Web.Common.PublishedModels
{
	/// <summary>Project Preview Settings</summary>
	[PublishedModel("projectPreviewSettings")]
	public partial class ProjectPreviewSettings : PublishedElementModel, IBlockVisibilitySettings, IItemNameSettings
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		public new const string ModelTypeAlias = "projectPreviewSettings";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ProjectPreviewSettings, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ProjectPreviewSettings(IPublishedElement content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Hide: Set this to true if you want to hide this block from the front end of the site
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[ImplementPropertyType("hide")]
		public virtual bool Hide => global::Umbraco.Cms.Web.Common.PublishedModels.BlockVisibilitySettings.GetHide(this, _publishedValueFallback);

		///<summary>
		/// Item Name: Enter a name for this item. This is just to help you organise the blocks in the list
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "9.0.1+bef1ccedca45b16a1a51178c45c2bec3302caf53")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("itemName")]
		public virtual string ItemName => global::Umbraco.Cms.Web.Common.PublishedModels.ItemNameSettings.GetItemName(this, _publishedValueFallback);
	}
}
