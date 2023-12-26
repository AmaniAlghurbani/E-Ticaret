using MVC.AMANİ.SİTESİ.Entity;
using System.Data.Entity;
using System.Web.Mvc;
using System.Web.Routing;
using MVC.AMANİ.SİTESİ.Identity;


namespace MVC.AMANİ.SİTESİ
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            Database.SetInitializer(new DataInitializer());
            Database.SetInitializer(new IdentityInitializer());

        }
    }
}
