//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder.Embedded v14.2.0+1b21caa
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
	/// <summary>Service-Details</summary>
	[PublishedModel("serviceDetails")]
	public partial class ServiceDetails : PublishedContentModel
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const string ModelTypeAlias = "serviceDetails";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public new static IPublishedContentType GetModelContentType(IPublishedSnapshotAccessor publishedSnapshotAccessor)
			=> PublishedModelUtility.GetModelContentType(publishedSnapshotAccessor, ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[return: global::System.Diagnostics.CodeAnalysis.MaybeNull]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(IPublishedSnapshotAccessor publishedSnapshotAccessor, Expression<Func<ServiceDetails, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(publishedSnapshotAccessor), selector);
#pragma warning restore 0109

		private IPublishedValueFallback _publishedValueFallback;

		// ctor
		public ServiceDetails(IPublishedContent content, IPublishedValueFallback publishedValueFallback)
			: base(content, publishedValueFallback)
		{
			_publishedValueFallback = publishedValueFallback;
		}

		// properties

		///<summary>
		/// Page Title
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("pageTitle")]
		public virtual string PageTitle => this.Value<string>(_publishedValueFallback, "pageTitle");

		///<summary>
		/// serviceContentButtonText
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentButtonText")]
		public virtual string ServiceContentButtonText => this.Value<string>(_publishedValueFallback, "serviceContentButtonText");

		///<summary>
		/// serviceContentHeadline-1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentHeadline1")]
		public virtual string ServiceContentHeadline1 => this.Value<string>(_publishedValueFallback, "serviceContentHeadline1");

		///<summary>
		/// serviceContentHeadline-2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentHeadline2")]
		public virtual string ServiceContentHeadline2 => this.Value<string>(_publishedValueFallback, "serviceContentHeadline2");

		///<summary>
		/// serviceContentHeadline-3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentHeadline3")]
		public virtual string ServiceContentHeadline3 => this.Value<string>(_publishedValueFallback, "serviceContentHeadline3");

		///<summary>
		/// serviceContentHeadline-4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentHeadline4")]
		public virtual string ServiceContentHeadline4 => this.Value<string>(_publishedValueFallback, "serviceContentHeadline4");

		///<summary>
		/// serviceContentHeadline-5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentHeadline5")]
		public virtual string ServiceContentHeadline5 => this.Value<string>(_publishedValueFallback, "serviceContentHeadline5");

		///<summary>
		/// serviceContentHeadline-6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentHeadline6")]
		public virtual string ServiceContentHeadline6 => this.Value<string>(_publishedValueFallback, "serviceContentHeadline6");

		///<summary>
		/// serviceContentImg-1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentImg1")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceContentImg1 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceContentImg1");

		///<summary>
		/// serviceContentImg-2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentImg2")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceContentImg2 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceContentImg2");

		///<summary>
		/// serviceContentImg-3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentImg3")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceContentImg3 => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceContentImg3");

		///<summary>
		/// serviceContentText-1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText1")]
		public virtual string ServiceContentText1 => this.Value<string>(_publishedValueFallback, "serviceContentText1");

		///<summary>
		/// serviceContentText-10
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText10")]
		public virtual string ServiceContentText10 => this.Value<string>(_publishedValueFallback, "serviceContentText10");

		///<summary>
		/// serviceContentText-11
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText11")]
		public virtual string ServiceContentText11 => this.Value<string>(_publishedValueFallback, "serviceContentText11");

		///<summary>
		/// serviceContentText-12
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText12")]
		public virtual string ServiceContentText12 => this.Value<string>(_publishedValueFallback, "serviceContentText12");

		///<summary>
		/// serviceContentText-13
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText13")]
		public virtual string ServiceContentText13 => this.Value<string>(_publishedValueFallback, "serviceContentText13");

		///<summary>
		/// serviceContentText-14
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText14")]
		public virtual string ServiceContentText14 => this.Value<string>(_publishedValueFallback, "serviceContentText14");

		///<summary>
		/// serviceContentText-15
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText15")]
		public virtual string ServiceContentText15 => this.Value<string>(_publishedValueFallback, "serviceContentText15");

		///<summary>
		/// serviceContentText-16
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText16")]
		public virtual string ServiceContentText16 => this.Value<string>(_publishedValueFallback, "serviceContentText16");

		///<summary>
		/// serviceContentText-17
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText17")]
		public virtual string ServiceContentText17 => this.Value<string>(_publishedValueFallback, "serviceContentText17");

		///<summary>
		/// serviceContentText-18
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText18")]
		public virtual string ServiceContentText18 => this.Value<string>(_publishedValueFallback, "serviceContentText18");

		///<summary>
		/// serviceContentText-2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText2")]
		public virtual string ServiceContentText2 => this.Value<string>(_publishedValueFallback, "serviceContentText2");

		///<summary>
		/// serviceContentText-3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText3")]
		public virtual string ServiceContentText3 => this.Value<string>(_publishedValueFallback, "serviceContentText3");

		///<summary>
		/// serviceContentText-4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText4")]
		public virtual string ServiceContentText4 => this.Value<string>(_publishedValueFallback, "serviceContentText4");

		///<summary>
		/// serviceContentText-5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText5")]
		public virtual string ServiceContentText5 => this.Value<string>(_publishedValueFallback, "serviceContentText5");

		///<summary>
		/// serviceContentText-6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText6")]
		public virtual string ServiceContentText6 => this.Value<string>(_publishedValueFallback, "serviceContentText6");

		///<summary>
		/// serviceContentText-7
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText7")]
		public virtual string ServiceContentText7 => this.Value<string>(_publishedValueFallback, "serviceContentText7");

		///<summary>
		/// serviceContentText-8
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText8")]
		public virtual string ServiceContentText8 => this.Value<string>(_publishedValueFallback, "serviceContentText8");

		///<summary>
		/// serviceContentText-9
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceContentText9")]
		public virtual string ServiceContentText9 => this.Value<string>(_publishedValueFallback, "serviceContentText9");

		///<summary>
		/// serviceDetailsMainHeadline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsMainHeadline")]
		public virtual string ServiceDetailsMainHeadline => this.Value<string>(_publishedValueFallback, "serviceDetailsMainHeadline");

		///<summary>
		/// serviceDetailsMainImg
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsMainImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceDetailsMainImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceDetailsMainImg");

		///<summary>
		/// serviceDetailsMainLink-1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsMainLink1")]
		public virtual string ServiceDetailsMainLink1 => this.Value<string>(_publishedValueFallback, "serviceDetailsMainLink1");

		///<summary>
		/// serviceDetailsMainLink-2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsMainLink2")]
		public virtual string ServiceDetailsMainLink2 => this.Value<string>(_publishedValueFallback, "serviceDetailsMainLink2");

		///<summary>
		/// serviceDetailsMainLink-3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsMainLink3")]
		public virtual string ServiceDetailsMainLink3 => this.Value<string>(_publishedValueFallback, "serviceDetailsMainLink3");

		///<summary>
		/// serviceDetailsProjectHeadline
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsProjectHeadline")]
		public virtual string ServiceDetailsProjectHeadline => this.Value<string>(_publishedValueFallback, "serviceDetailsProjectHeadline");

		///<summary>
		/// serviceDetailsProjectImg
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsProjectImg")]
		public virtual global::Umbraco.Cms.Core.Models.MediaWithCrops ServiceDetailsProjectImg => this.Value<global::Umbraco.Cms.Core.Models.MediaWithCrops>(_publishedValueFallback, "serviceDetailsProjectImg");

		///<summary>
		/// serviceDetailsProjectText-1
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsProjectText1")]
		public virtual string ServiceDetailsProjectText1 => this.Value<string>(_publishedValueFallback, "serviceDetailsProjectText1");

		///<summary>
		/// serviceDetailsProjectText-2
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsProjectText2")]
		public virtual string ServiceDetailsProjectText2 => this.Value<string>(_publishedValueFallback, "serviceDetailsProjectText2");

		///<summary>
		/// serviceDetailsProjectText-3
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsProjectText3")]
		public virtual string ServiceDetailsProjectText3 => this.Value<string>(_publishedValueFallback, "serviceDetailsProjectText3");

		///<summary>
		/// serviceDetailsProjectText-4
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsProjectText4")]
		public virtual string ServiceDetailsProjectText4 => this.Value<string>(_publishedValueFallback, "serviceDetailsProjectText4");

		///<summary>
		/// serviceDetailsProjectText-5
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsProjectText5")]
		public virtual string ServiceDetailsProjectText5 => this.Value<string>(_publishedValueFallback, "serviceDetailsProjectText5");

		///<summary>
		/// serviceDetailsProjectText-6
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder.Embedded", "14.2.0+1b21caa")]
		[global::System.Diagnostics.CodeAnalysis.MaybeNull]
		[ImplementPropertyType("serviceDetailsProjectText6")]
		public virtual string ServiceDetailsProjectText6 => this.Value<string>(_publishedValueFallback, "serviceDetailsProjectText6");
	}
}