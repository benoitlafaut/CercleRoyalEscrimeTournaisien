using System;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace CercleRoyalEscrimeTournaisien
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Models.MainModel.ScreenToShow = Models.TypeScreenToShow.ScreenBannier;
            Models.MainModel.DateCurrent = DateTime.Now;
            Models.MainModel.NumeroAlbumCurrent = 12;
            Models.MainModel.NumeroPhotoOfAlbumCurrent = 1;
            Models.MainModel.HasPubAlreadyShowed = true;

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
