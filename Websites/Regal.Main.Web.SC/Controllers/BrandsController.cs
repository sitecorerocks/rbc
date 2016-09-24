using Regal.Main.Web.SC.Models;
using Regal.Main.Web.SC.Repositories;
using Sitecore.Diagnostics;
using Sitecore.Mvc.Presentation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Regal.Main.Web.SC.Controllers
{
    public class BrandsController : Controller
    {
        private readonly IBrandsRepository _brandsRepository;

        public BrandsController()
            : this(new BrandsRepository(RenderingContext.Current.Rendering.Item))
        {
        }

        public BrandsController(IBrandsRepository brandRepository)
        {
            Assert.ArgumentNotNull(brandRepository, "brandRepository");
            _brandsRepository = brandRepository;
        }

        public ActionResult GetBrands()
        {
            Assert.ArgumentNotNull(_brandsRepository, "_brandsRepository");
            BrandsViewModel brandsViewModel = _brandsRepository.GetBrandViewModel();
            return View("~/Views/RegalMain/Renderings/Pages/Brands/BrandsListing.cshtml", brandsViewModel);
        }
    }
}