#pragma checksum "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf971bfcfbebc740fee1e7196aea5bb30fb32b56"
// <auto-generated/>
#pragma warning disable 1591
namespace FirstBlazorApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using FirstBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using FirstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-6v4rzgve31");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-6v4rzgve31");
            __builder.OpenComponent<FirstBlazorApp.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-6v4rzgve31");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-6v4rzgve31><a href=\"http://blazor.net\" target=\"_blank\" class=\"ml-md-auto\" b-6v4rzgve31>About</a></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-6v4rzgve31");
            __builder.AddContent(15, 
#nullable restore
#line 14 "C:\Users\Anonymous\Documents\Programming\C#\FirstBlazorApp\FirstBlazorApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
