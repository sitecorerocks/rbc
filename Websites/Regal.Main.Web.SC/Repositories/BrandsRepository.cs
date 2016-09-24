using Glass.Mapper.Sc;
using Regal.Main.Web.SC.Models;
using Regal.Main.Web.SC.Models.sitecore.templates.User_Defined.Regal_Beloit.Pages;
using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Regal.Main.Web.SC.Repositories
{
    public class BrandsRepository : IBrandsRepository
    {
        public IGlassBase ContextItem { get; set; }
        private SitecoreContext _context;

        public BrandsRepository(Item contextItem)
        {
            _context = new SitecoreContext();
            ContextItem = _context.GetItem<IGlassBase>(contextItem.ID.Guid);
        }

        public BrandsViewModel GetBrandViewModel()
        {
            BrandsViewModel brandsViewModel = new BrandsViewModel { Brands = GetBrands().ToList() };
            return brandsViewModel;
        }

        private IEnumerable<IBrand_Details_Page> GetBrands()
        {
            if (ContextItem != null)
            {
                foreach (var brand in ContextItem.Children)
                {
                    yield return _context.GetItem<IBrand_Details_Page>(brand.Id);
                }
            }
        }
    }
}