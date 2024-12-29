using System.Web.Optimization;

namespace CercleRoyalEscrimeTournaisien
{
    public class BundleConfig
    {
        // Pour plus d'informations sur le regroupement, visitez https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include("~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include("~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/bootstrapMoi.css"));

            bundles.Add(new StyleBundle("~/Content/css").Include("~/Content/AdministrationPage.css"));

            bundles.Add(new StyleBundle("~/styles/NosCoursCss")
                .Include("~/Content/NosCours.css",
                         "~/Content/NosCoursMultiColor.css",
                         "~/Content/MainPage.css",
                         "~/Content/5d93eb1089.css"));

            bundles.Add(new ScriptBundle("~/bundles/NosCoursJS")
                .Include("~/Scripts/mainPage.js",
                         "~/Scripts/NosCours.js"));

            bundles.Add(new ScriptBundle("~/bundles/ReadEpub28012024JS")
                .Include("~/Scripts/ReadEpub28012024.js"));

            bundles.Add(new ScriptBundle("~/bundles/DicoJS")
               .Include("~/Scripts/dico.js"));

            bundles.Add(new StyleBundle("~/styles/DicoCss")
               .Include("~/Content/Dico.css"));

            bundles.Add(new ScriptBundle("~/bundles/Epub122024JS")
            .Include("~/Scripts/Epub122024.js"));

            bundles.Add(new StyleBundle("~/styles/Epub122024Css")
               .Include("~/Content/Epub122024.css"));
        }
    }
}
