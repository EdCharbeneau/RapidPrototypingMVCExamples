/****** Installation Instructions ******

1. Update the Layout

Open the /Views/_ViewStart.cshtml
Change the Layout to _Foundation.cshtml like the example below:

@{
    //This is the default MVC template
    //Layout = "~/Views/Shared/_Layout.cshtml";
    
    //This is the Foundation MVC template
    Layout = "~/Views/Shared/_Foundation.cshtml";
}

2. Remove the default theme

Once the ViewStart has been updated. Replace the default Index.cshtml.

Rename ~/Views/Home/Index.cshtml to Index.cshtml.exclude (or delete the file)
Rename ~/Views/Home/Foundation_Index.cshtml to Index.cshtml
Rename ~/Content/Site.css to Site.css.exclude (or delete the file)

3. Add Bundling and Minification

Add this to Application_Start in Global.asax:

#if !DEBUG    
            //TODO: Add your favorite bootstrapper framework
            Bundles_Startup.BundleCss();
            Bundles_Startup.BundleJs();
#endif

4.

You are now ready to begin building your MVC project using Foundation.

/****** Related Nuget packages ******
Want to rapid prototype and wire frame directly from code using Html Helpers? 
Try the prototyping package on nuget. It works great with Foundation.
http://www.nuget.org/packages/Prototyping_MVC

Having trouble with media queries? Debug them with this simple CSS file.
http://nuget.org/packages/CSS_Media_Query_Debugger

/****** Documentation ******
Docs http://foundation.zurb.com/docs/
A Crashcourse in Responsive Design http://www.slideshare.net/edcharbeneauii/a-crash-course-in-responsive-design-12007229

Follow us:
Ed Charbeneau http://twitter.com/#!/edcharbeneau
Foundation Zurb http://twitter.com/#!/foundationzurb


/****** Package Information ******
Files added during install:

~/Bootstrap
~/Bootstrap/Bundles_Startup.cs

~/Content/core
~/Content/core/forms.css
~/Content/core/globals.css
~/Content/core/grid.css
~/Content/core/orbit.css
~/Content/core/reveal.css
~/Content/core/typography.css
~/Content/core/ui.css

~/Content/app.css
~/Content/ie.css
~/Content/mobile.css

~/Content/themes/foundation/misc
~/Content/themes/foundation/misc/button-gloss.png
~/Content/themes/foundation/misc/button-overlay.png
~/Content/themes/foundation/misc/custom-form-sprites.png
~/Content/themes/foundation/misc/input-bg.png
~/Content/themes/foundation/misc/input-bg-outset.png
~/Content/themes/foundation/misc/modal-gloss.png
~/Content/themes/foundation/misc/table-sorter.png

~/Content/themes/foundation/orbit
~/Content/themes/foundation/orbit/bullets.jpg
~/Content/themes/foundation/orbit/left-arrow.png
~/Content/themes/foundation/orbit/loading.gif
~/Content/themes/foundation/orbit/mask-black.png
~/Content/themes/foundation/orbit/pause-black.png
~/Content/themes/foundation/orbit/right-arrow.png
~/Content/themes/foundation/orbit/rotator-black.png
~/Content/themes/foundation/orbit/timer-black.png

~/Scripts/app.js
~/Scripts/jquery.customforms.js
~/Scripts/jquery.min.js
~/Scripts/jquery.orbit-1.3.0.js
~/Scripts/jquery.placeholder.min.js
~/Scripts/jquery.reveal.js
~/Scripts/jquery.tooltips.js
~/Scripts/modernizr.foundation.js

~/humans.txt
~/robots.txt
~/MIT-LICENSE.txt
~/README.txt (this file)

~/Views/Home/Foundation_Index.cshtml

~/Views/Shared/_Foundation.cshtml

Dependencies:
Microsoft.Web.Optimization

Change Log:

Version 0.4.221
Updated Foundation version 2.2.1
    Ref. Zurb Docs "Numerous bug fixes and tweaks to cement Foundation 2 and let us move into Foundation 3."

Version 0.4.220
Corrected Nuget package

Version 0.3.220
Updated Foundation version 2.2.0
Changed Foundation_Index.cshtml to a functional demo page
CSS files are now bundled in order to ensure the correct output

Version 0.3.2151
Hot fixed jquery.tooltips.js

Version 0.3.215
Updated to Foundation version 2.1.5
Updated Installation instructions

Version 0.3.214
Fixed inactive tabs do not hide. (updated app.js pulled from Zurb)
Updated jquery.customforms.js to current zurb version
Updated grid.css to current zurb version

Version 0.2.214
Fixed javascript errors related to bundling process. (only visible when running in release mode with out debugging)
Changed the bundling (aka minification process). Js files are now bundled in order to ensure jQuery is bundled first.
Changed js and css bundle output to "~/core.min.js" | "~/Content/core/min.css"
Changed _Foundation.cshtml to reflect the new bundlinig process
Added a scripts RenderSection to _Foundation.cshtml for defining inlne scripts | page only scripts.

Version 0.1.214
Fixed missinig javascript files from nuget package
Updated to foundation ver 2.1.4

Version 0.1.213
Fixed missinig javascript files from nuget package
Updated to foundation ver 2.1.3

Note: version scheme <major>.<minor>.<foundation version>
foundation version represents the foundation version less the "." for example 2.1.4 would be #.#.214