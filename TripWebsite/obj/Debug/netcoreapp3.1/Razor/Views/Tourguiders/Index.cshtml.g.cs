#pragma checksum "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/Tourguiders/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c46d37e81fd647276b57a405eae3e76f93afd01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tourguiders_Index), @"mvc.1.0.view", @"/Views/Tourguiders/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/_ViewImports.cshtml"
using TripWebsite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/_ViewImports.cshtml"
using TripWebsite.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c46d37e81fd647276b57a405eae3e76f93afd01", @"/Views/Tourguiders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35d663464c6666e89a53ea2ad31bcee169efaab6", @"/Views/_ViewImports.cshtml")]
    public class Views_Tourguiders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/Tourguiders/Index.cshtml"
  
    var Tourguiders = (List<TourguidersModel>)ViewData["Tourguiders"];
    Layout = "WebLayout";


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <div class=\"row bg\">\n        <h1 class=\"topheader2\">how to take trip with . .</h1>\n    </div>\n    <div class=\"row\">\n");
#nullable restore
#line 13 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/Tourguiders/Index.cshtml"
         foreach (var Tourguider in Tourguiders)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"clo-sm-2\">\n                <div class=\"flip-card\">\n                    <div class=\"flip-card-inner\">\n                        <div class=\"flip-card-front\">\n                            <img");
            BeginWriteAttribute("src", " src=\"", 519, "\"", 540, 1);
#nullable restore
#line 19 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/Tourguiders/Index.cshtml"
WriteAttributeValue("", 525, Tourguider.Img, 525, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:500px;height:450px;\">\n                        </div>\n                        <div class=\"flip-card-back\">\n                            <h1>");
#nullable restore
#line 22 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/Tourguiders/Index.cshtml"
                           Write(Tourguider.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n                            <p>");
#nullable restore
#line 23 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/Tourguiders/Index.cshtml"
                          Write(Tourguider.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                            <p>Phone number:");
#nullable restore
#line 24 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/Tourguiders/Index.cshtml"
                                       Write(Tourguider.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                </div>\n            </div>\n");
#nullable restore
#line 29 "/Users/afra/Desktop/BootCamp Refrence/Dot Net/DotNet Projects/TripWebsite/TripWebsite/Views/Tourguiders/Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
