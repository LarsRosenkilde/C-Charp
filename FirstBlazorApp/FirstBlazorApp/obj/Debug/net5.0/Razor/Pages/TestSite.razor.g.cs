#pragma checksum "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\Pages\TestSite.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1dee0f0db43de935b644cf7186c25e8bcb00001e"
// <auto-generated/>
#pragma warning disable 1591
namespace FirstBlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using FirstBlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\_Imports.razor"
using FirstBlazorApp.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/test")]
    public partial class TestSite : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Razor Progressive Web Application</h1><br>\r\n");
            __builder.AddMarkupContent(1, "<p>\r\n    1. This is a program that runs inside your browser <br>\r\n    2. It uses your computer hardware as power, not the internet <br>\r\n    3. It works offline, and on every device with a browser installed <br></p>\r\n\r\n");
            __builder.OpenElement(2, "p");
            __builder.AddMarkupContent(3, "Please enter your name: \r\n    ");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\Pages\TestSite.razor"
                  InstantValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InstantValue = __value, InstantValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n");
            __builder.OpenElement(8, "p");
            __builder.AddMarkupContent(9, "\r\n    Instant: ");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\Pages\TestSite.razor"
              InstantValue

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(11, " <br>\r\n    Greeting: ");
            __builder.AddContent(12, 
#nullable restore
#line 16 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\Pages\TestSite.razor"
               EnteredVal

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(13, " <br>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-primary");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\Pages\TestSite.razor"
                                          SubmitText

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Click Me!");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Anonymous\Documents\Programming\GitHub\C-Charp\FirstBlazorApp\FirstBlazorApp\Pages\TestSite.razor"
       
    private string InstantValue { get; set; }
    private string EnteredVal = "";

    private void SubmitText()
    {
        EnteredVal = $"Well hello there {InstantValue} !";
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
