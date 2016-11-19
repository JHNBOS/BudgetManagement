using Invoice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Invoice
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            ModelBinders.Binders.Add(typeof(decimal), new DecimalModelBinder());
            ModelBinders.Binders.Add(typeof(decimal?), new DecimalModelBinder());

            System.Globalization.CultureInfo newCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();

            newCulture.DateTimeFormat.ShortDatePattern = "dd-MM-yyyy";
            newCulture.DateTimeFormat.DateSeparator = "-";

            newCulture.NumberFormat.CurrencyDecimalSeparator = ",";
            newCulture.NumberFormat.NumberDecimalSeparator = ",";
            newCulture.NumberFormat.CurrencyGroupSeparator = ".";
            newCulture.NumberFormat.NumberGroupSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = newCulture;
        }

    }
}
