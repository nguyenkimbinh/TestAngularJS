using System.Web;
using System.Web.Optimization;

namespace TestAngularJS
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/TestAngularJS")
                .IncludeDirectory("~/Scripts/Controllers", "*.js")
                .Include("~/Scripts/TestAngularJS.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
