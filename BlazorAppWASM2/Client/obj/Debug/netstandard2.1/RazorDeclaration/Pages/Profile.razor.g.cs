#pragma checksum "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a93b755838d309ca055622a50d2293607e5059a"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorAppWASM2.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\_Imports.razor"
using BlazorAppWASM2.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\_Imports.razor"
using BlazorAppWASM2.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\Pages\Profile.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\Pages\Profile.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\Pages\Profile.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\Pages\Profile.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\source\experiments\BlazorAppWASM2\BlazorAppWASM2\Client\Pages\Profile.razor"
      

    string accessToken = "";

    protected override async Task OnInitializedAsync()
    {
        var tokenResult = await TokenProvider.RequestAccessToken();

        if (tokenResult.TryGetToken(out var token))
        {
            accessToken = token.Value;
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAccessTokenProvider TokenProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
