#pragma checksum "C:\Users\pulsa\Desktop\projects\05_sending_object_to_view\my_project\Views\Home\GetProducts2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba0dc3998d03ca8ee01d4a2c79f14f4de077d514"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetProducts2), @"mvc.1.0.view", @"/Views/Home/GetProducts2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba0dc3998d03ca8ee01d4a2c79f14f4de077d514", @"/Views/Home/GetProducts2.cshtml")]
    #nullable restore
    public class Views_Home_GetProducts2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<(my_project.Models.User u, my_project.Models.Product p)>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h3>");
#nullable restore
#line 3 "C:\Users\pulsa\Desktop\projects\05_sending_object_to_view\my_project\Views\Home\GetProducts2.cshtml"
Write(Model.u.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<h3>");
#nullable restore
#line 5 "C:\Users\pulsa\Desktop\projects\05_sending_object_to_view\my_project\Views\Home\GetProducts2.cshtml"
Write(Model.p.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<(my_project.Models.User u, my_project.Models.Product p)> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
