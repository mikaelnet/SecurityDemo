using System.Web;
using System.Web.Optimization;

namespace SecurityDemo
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/static/js/jquery-{version}.js"));

			bundles.Add(new ScriptBundle("~/bundles/style").Include(
						"~/static/css/style.css"));
        }
    }
}
