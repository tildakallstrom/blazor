#pragma checksum "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "efa572dfe82061e76f10b737d17e5bdc921f366e"
// <auto-generated/>
#pragma warning disable 1591
namespace mom1._3.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using mom1._3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\_Imports.razor"
using mom1._3.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"top-row pl-4 navbar navbar-dark\">\r\n    <a class=\"navbar-brand\" href>Moment 1.3</a>\r\n</div>\r\n\r\n    ");
            __builder.OpenElement(1, "ul");
            __builder.AddAttribute(2, "class", "flex-column");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "class", "nav-item px-3");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(7);
            __builder.AddAttribute(8, "class", "nav-link");
            __builder.AddAttribute(9, "href", "");
            __builder.AddAttribute(10, "Match", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 7 "C:\Users\tilda\OneDrive\Desktop\Skola\.NET\Mom1\mom1.3\mom1.3\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "nav-item px-3");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(18);
            __builder.AddAttribute(19, "class", "nav-link");
            __builder.AddAttribute(20, "href", "counter");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item px-3");
            __builder.AddMarkupContent(27, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(28);
            __builder.AddAttribute(29, "class", "nav-link");
            __builder.AddAttribute(30, "href", "fetchdata");
            __builder.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(32, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
