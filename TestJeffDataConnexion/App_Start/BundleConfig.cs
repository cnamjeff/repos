using System.Web;
using System.Web.Optimization;
using System.Web.UI.WebControls;

namespace TestJeffDataConnexion
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/DataTables/jquery.dataTables.min.js",
                        "~/Scripts/respond.js",
                        "~/Scripts/bootstrap.js",         
                        "~/Scripts/jquery.unobtrusive-ajax.js",                                                
                        "~/Scripts/moment-with-locales.min.js",
                        "~/Scripts/bootstrap-datetimepicker.js",
                   
                        "~/Scripts/VueLogin/Index.js"
                        ));


            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap.datetimepicker.css",
                      "~/Content/DataTables/css/jquery.dataTables.min.css",
                      "~/Content/bootstrap-theme.min.css",
                     "~/Content/bootstrap-datepicker.css",                    
                     "~/Content/bootstrap-datepicker.standalone.css",
                     "~/Content/bootstrap-datepicker3.css",
                     "~/Content/bootstrap-datepicker3.standalone.css",
                       "~/Content/daterangepicker.css" 
                      ));
        }
    }
}
