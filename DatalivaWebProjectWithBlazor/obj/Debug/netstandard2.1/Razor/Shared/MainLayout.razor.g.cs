#pragma checksum "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e0a3b719868adef46f0acab6e5475ab4fe78e40"
// <auto-generated/>
#pragma warning disable 1591
namespace DatalivaWebProjectWithBlazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using DatalivaWebProjectWithBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\_Imports.razor"
using DatalivaWebProjectWithBlazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "sidebar");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.OpenComponent<DatalivaWebProjectWithBlazor.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "main");
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "top-row px-4");
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "class", "btn btn-primary");
            __builder.AddAttribute(14, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Shared\MainLayout.razor"
                                                  LoginUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(15, "Login");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-danger");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Shared\MainLayout.razor"
                                                 RegisterUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(20, "Register");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "content px-4");
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.AddContent(26, 
#nullable restore
#line 15 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Shared\MainLayout.razor"
      

    private void LoginUser ()
    {
        _navigationManager.NavigateTo("/login",true);
    }
    private void RegisterUser()
    {
        _navigationManager.NavigateTo("/register", true);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
    }
}
#pragma warning restore 1591