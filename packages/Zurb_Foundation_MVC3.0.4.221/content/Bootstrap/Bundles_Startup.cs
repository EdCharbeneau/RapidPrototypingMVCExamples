using System;
using System.Linq;
using Microsoft.Web.Optimization;

public static class Bundles_Startup
{
    public static void BundleJs()
    {
        Bundle jsBundle = new Bundle("~/core.min.js", typeof(JsMinify));
        jsBundle.AddFile("~/Scripts/jquery.min.js"); //Always leave on top
        jsBundle.AddFile("~/Scripts/modernizr.foundation.js");
        jsBundle.AddFile("~/Scripts/jquery.reveal.js");
        jsBundle.AddFile("~/Scripts/jquery.orbit-1.4.0.js");
        jsBundle.AddFile("~/Scripts/jquery.customforms.js");
        jsBundle.AddFile("~/Scripts/jquery.placeholder.min.js");
        jsBundle.AddFile("~/Scripts/jquery.tooltips.js");
        BundleTable.Bundles.Add(jsBundle);
    }

    public static void BundleCss()
    {
        Bundle cssBundle = new Bundle("~/Content/core/min.css", typeof(CssMinify));
        cssBundle.AddFile("~/Content/core/globals.css");
        cssBundle.AddFile("~/Content/core/typography.css");
        cssBundle.AddFile("~/Content/core/grid.css");
        cssBundle.AddFile("~/Content/core/ui.css");
        cssBundle.AddFile("~/Content/core/forms.css");
        cssBundle.AddFile("~/Content/core/orbit.css");
        cssBundle.AddFile("~/Content/core/reveal.css");
        BundleTable.Bundles.Add(cssBundle);
    }
}
