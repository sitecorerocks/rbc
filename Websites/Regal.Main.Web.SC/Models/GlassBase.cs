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
    public partial class GlassBase : IGlassBase
    {

        [SitecoreChildren(InferType = true)]
        public virtual IEnumerable<IGlassBase> Children { get; protected set; }

        [SitecoreInfo(SitecoreInfoType.TemplateId)]
        public Guid TemplateId { get; protected set; }

        [SitecoreInfo(SitecoreInfoType.DisplayName)]
        public virtual string DisplayName { get; protected set; }

        [SitecoreInfo(SitecoreInfoType.Name)]
        public virtual string ItemName { get; protected set; }
    }
}
