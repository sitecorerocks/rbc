





#pragma warning disable 1591
#pragma warning disable 0108
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Team Development for Sitecore.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;   
using System.Collections.Generic;   
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Fields;
using Sitecore.Globalization;
using Sitecore.Data;



namespace Regal.Main.Web.SC.Models
{

	public partial interface IGlassBase{
		
		[SitecoreId]
		Guid Id { get; }

		[SitecoreInfo(SitecoreInfoType.Name)]
        string Name { get; set; }

		[SitecoreInfo(SitecoreInfoType.Language)]
        Language Language{ get; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        int Version { get; }

		[SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; }

		[SitecoreInfo(SitecoreInfoType.TemplateName)]
        string TemplateName { get; }

		[SitecoreInfo(SitecoreInfoType.Url)]
        string Url { get; }

        [SitecoreInfo(SitecoreInfoType.Path)]
        string Path { get; }
	}

	public abstract partial class GlassBase : IGlassBase{
		
		[SitecoreId]
		public virtual Guid Id{ get; private set;}

		[SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string Name { get; set; }

		[SitecoreInfo(SitecoreInfoType.Language)]
        public virtual Language Language{ get; private set; }

        [SitecoreInfo(SitecoreInfoType.Version)]
        public virtual int Version { get; private set; }

		[SitecoreInfo(SitecoreInfoType.Url)]
        public virtual string Url { get; private set; }

		[SitecoreInfo(SitecoreInfoType.TemplateId)]
        public virtual Guid TemplateId { get; private set; }

		[SitecoreInfo(SitecoreInfoType.TemplateName)]
        public virtual string TemplateName { get; private set; }

    	[SitecoreInfo(SitecoreInfoType.Path)]
        public virtual string Path { get; private set; }
	}
}
namespace Regal.Main.Web.SC.Models.sitecore.templates.RegalMain.Base
{


 	/// <summary>
	/// IMetadata Interface
	/// <para></para>
	/// <para>Path: /sitecore/templates/RegalMain/Base/Metadata</para>	
	/// <para>ID: 819db06e-a185-44ed-aee6-c5cf5e6abb79</para>	
	/// </summary>
	[SitecoreType(TemplateId=IMetadataConstants.TemplateIdString )] //, Cachable = true
	public partial interface IMetadata : IGlassBase 
	{
								/// <summary>
					/// The MetaDescription field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: e7e30446-5eee-4920-9d1a-b21a502de0ce</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IMetadataConstants.MetaDescriptionFieldName)]
					string MetaDescription  {get; set;}
			
								/// <summary>
					/// The MetaKeywords field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: b1d89957-2cea-4a70-ab93-4d2da580e2cd</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IMetadataConstants.MetaKeywordsFieldName)]
					string MetaKeywords  {get; set;}
			
								/// <summary>
					/// The MetaTitle field.
					/// <para></para>
					/// <para>Field Type: Single-Line Text</para>		
					/// <para>Field ID: df268d4f-5ceb-48a4-82c0-1547061bc811</para>
					/// <para>Custom Data: </para>
					/// </summary>
					[SitecoreField(IMetadataConstants.MetaTitleFieldName)]
					string MetaTitle  {get; set;}
			
				}


	public static partial class IMetadataConstants{

			public const string TemplateIdString = "819DB06E-A185-44ED-AEE6-C5CF5E6ABB79";
			public static readonly ID TemplateId = new ID(TemplateIdString);
			public const string TemplateName = "Metadata";

					
			public static readonly ID MetaDescriptionFieldId = new ID("e7e30446-5eee-4920-9d1a-b21a502de0ce");
			public const string MetaDescriptionFieldName = "MetaDescription";
			
					
			public static readonly ID MetaKeywordsFieldId = new ID("b1d89957-2cea-4a70-ab93-4d2da580e2cd");
			public const string MetaKeywordsFieldName = "MetaKeywords";
			
					
			public static readonly ID MetaTitleFieldId = new ID("df268d4f-5ceb-48a4-82c0-1547061bc811");
			public const string MetaTitleFieldName = "MetaTitle";
			
			

	}

	
	/// <summary>
	/// Metadata
	/// <para></para>
	/// <para>Path: /sitecore/templates/RegalMain/Base/Metadata</para>	
	/// <para>ID: 819db06e-a185-44ed-aee6-c5cf5e6abb79</para>	
	/// </summary>
	[SitecoreType(TemplateId=IMetadataConstants.TemplateIdString)] //, Cachable = true
	public partial class Metadata  : GlassBase, IMetadata 
	{
	   
						/// <summary>
				/// The MetaDescription field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: e7e30446-5eee-4920-9d1a-b21a502de0ce</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IMetadataConstants.MetaDescriptionFieldName)]
				public virtual string MetaDescription  {get; set;}
					
						/// <summary>
				/// The MetaKeywords field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: b1d89957-2cea-4a70-ab93-4d2da580e2cd</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IMetadataConstants.MetaKeywordsFieldName)]
				public virtual string MetaKeywords  {get; set;}
					
						/// <summary>
				/// The MetaTitle field.
				/// <para></para>
				/// <para>Field Type: Single-Line Text</para>		
				/// <para>Field ID: df268d4f-5ceb-48a4-82c0-1547061bc811</para>
				/// <para>Custom Data: </para>
				/// </summary>
				[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Team Development for Sitecore - GlassItem.tt", "1.0")]
				[SitecoreField(IMetadataConstants.MetaTitleFieldName)]
				public virtual string MetaTitle  {get; set;}
					
			
	}
}
