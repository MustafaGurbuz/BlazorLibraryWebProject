#pragma checksum "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70bb68aebaf082f28fb70ba96129d4766c28c895"
// <auto-generated/>
#pragma warning disable 1591
namespace DatalivaWebProjectWithBlazor.Pages
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""row TopPart"">
    <div class=""col-md-2 LinkAboutSpan"">
        <div class=""HeaderPart"">
            <span class=""oi oi-circle-check"" aria-hidden=""true""></span>
        </div>

    </div>
    <div class=""col-md-10 no-gutters LinkAboutUs"">
        <div class=""HeaderPart"">
            <h1> HOME </h1>
        </div>
    </div>
</div>
    <br>
    ");
            __builder.AddMarkupContent(1, "<div class=\"row\">\r\n        <div class=\"col-md-12 IndexPage\">\r\n            <h1> > Library Application</h1>\r\n\r\n            <p>This component shows us how many book there is on the system.</p>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-success");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
                                              RouteToLoginPage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Add a New Book");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n\r\n");
#nullable restore
#line 30 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
     if (book == null)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.AddMarkupContent(8, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 33 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(9, "        ");
            __builder.OpenElement(10, "table");
            __builder.AddAttribute(11, "class", "table");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.AddMarkupContent(13, "<thead>\r\n                <tr>\r\n                    <th>ID</th>\r\n                    <th>Book</th>\r\n                    <th>Author</th>\r\n                    <th>Publisher</th>\r\n                </tr>\r\n            </thead>\r\n            ");
            __builder.OpenElement(14, "tbody");
            __builder.AddMarkupContent(15, "\r\n");
#nullable restore
#line 46 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
                 foreach (var bk in book)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(16, "                    ");
            __builder.OpenElement(17, "tr");
            __builder.AddMarkupContent(18, "\r\n                        ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 49 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
                             bk.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 50 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
                             bk.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 51 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
                             bk.Author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.OpenElement(28, "td");
            __builder.AddContent(29, 
#nullable restore
#line 52 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
                             bk.Publisher

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 54 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
#nullable restore
#line 57 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(35, "\r\n\r\n    ");
            __builder.AddMarkupContent(36, @"<div class=""row"">
        <div class=""col-md-12 no-gutters"">
            <div class=""middlesideOne"">
                <h1>From Turkish Author</h1>
                <p>
                    >> Kiralık Konak, Yakup Kadri Karaosmanoğlu'nun Osmanlı Devleti'nin çöküş döneminde,
                    İstanbul'da batılılaşma ile geleneksel değerlerin,
                    kuşaklar arasında farklılaşan değer yargılarının,
                    yaşam biçimlerinin çatışmasını irdeleyen bir romanıdır.
                    İlk yayınlanma tarihi: 1922'dir.
                </p>
            </div>
        </div>
    </div>
    <br>
    ");
            __builder.AddMarkupContent(37, @"<div class=""row"" id=""rowOne"">
        <div class=""col-md-6 no-gutters"">
            <div class=""leftsideTwo"">
                <h2>Most liked books</h2>
                <p>
                    >> Satranç, Stefan Zweig'in Brezilya'daki sürgünde yazdığı ve en tanınmış eserlerindendir.
                    İlk baskısı 250 adet olarak 1942 yılında Buenos Aires'te çıkan hikâyenin,
                    İngilizce tercümesi 1944'te New York'ta yayımlandı.
                    Satranç, Almanya'da 1.200.000'den fazla sattı.
                </p>
            </div>
        </div>
        <div class=""col-md-6 no-gutters"">
            <div class=""rightsideTwo"">
                <h2>Most visited books</h2>
                <p>
                    >> Bin Dokuz Yüz Seksen Dört, George Orwell tarafından kaleme alınmış alegorik bir politik romandır.
                    Hikâyesi distopik bir dünyada geçer. Distopya romanlarının ünlülerindendir.
                    Özellikle kitapta tanımlanan Big Brother kavramı günümüzde de sıklıkla kullanılmaktadır
                </p>
            </div>
        </div>
    </div>

    ");
            __builder.AddMarkupContent(38, "<div class=\"footer\">\r\n        <div class=\"section\">Adress</div>\r\n        <div class=\"section\">Contact Number</div>\r\n        <div class=\"section\">Email Adress</div>\r\n        <div class=\"section\">About Us</div>\r\n    </div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 106 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Index.razor"
           
        private void RouteToLoginPage()
        {
            _navigationManager.NavigateTo("/login", true);
        }

        private LibraryItem[] book;

        protected override async Task OnInitializedAsync()
        {
            book = await Http.GetFromJsonAsync<LibraryItem[]>("sample-data/kitap.json");
        }

        public class LibraryItem
        {
            public int Id { get; set; }

            public string Title { get; set; }

            public string Author { get; set; }

            public string Publisher { get; set; }
        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager _navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
