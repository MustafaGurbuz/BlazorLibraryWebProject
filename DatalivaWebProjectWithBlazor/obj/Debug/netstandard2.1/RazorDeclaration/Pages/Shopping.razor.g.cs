#pragma checksum "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Shopping.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdec362535b3d7e1b69423aba61b2ed1d1edd06f"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace DatalivaWebProjectWithBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#nullable restore
#line 2 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Shopping.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/shopping")]
    public partial class Shopping : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 142 "C:\Users\MUSTAFA\Desktop\WebProjectWithBlazor\DatalivaWebProjectWithBlazor\DatalivaWebProjectWithBlazor\Pages\Shopping.razor"
           
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


        int numberOfBook = 0;

        private async Task searchFromBook() =>
            await Http.GetFromJsonAsync<LibraryItem>("sample-data/kitap.json");


        void IncrementTheSize()
        {
            numberOfBook++;
        }
        void DecreaseTheSize()
        {
            if (numberOfBook > 0)
            {
                numberOfBook--;
            }
            else
            {
                numberOfBook = 0;
            }

        }
    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
