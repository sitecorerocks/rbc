using Regal.Main.Web.SC.Models;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Regal.Main.Web.SC.Repositories
{
    public interface IBrandsRepository
    {
        BrandsViewModel GetBrandViewModel();

    }
}