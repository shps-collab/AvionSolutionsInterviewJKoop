using System.Web.Routing;
using Microsoft.AspNet.FriendlyUrls;

namespace NorthwindDbTest_CSharp
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            var settings = new FriendlyUrlSettings();
            settings.AutoRedirectMode = RedirectMode.Permanent;
            routes.EnableFriendlyUrls(settings);
            routes.MapPageRoute("Products", "Products", "~/pages/products/Products.aspx");
            routes.MapPageRoute("Details", "Products/Details", "~/pages/products/details/Details.aspx");
            //"{controller=Home}/{action=Index}/{id?}";)
        }
    }
}
