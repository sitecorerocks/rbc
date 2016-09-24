using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sitecore.Globalization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regal.Main.Web.SC.Models
{
    public partial interface IGlassBase
    {
        
        [SitecoreChildren(InferType = true)]
        IEnumerable<IGlassBase> Children { get; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        Guid TemplateId { get; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        string DisplayName { get; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        string ItemName { get; }
    }
}
