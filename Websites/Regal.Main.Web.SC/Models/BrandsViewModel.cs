using Regal.Main.Web.SC.Models.sitecore.templates.User_Defined.Regal_Beloit.Pages;
using Sitecore.Data.Items;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Regal.Main.Web.SC.Models
{
    public class BrandsViewModel : RenderingModel
    {
        public List<IBrand_Details_Page> Brands { get; set; }
    }
}