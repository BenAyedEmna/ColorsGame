#pragma checksum "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48de74c6920d6225f95e9904d7c7e3764a5f91e8"
// <auto-generated/>
#pragma warning disable 1591
namespace ColorsGame.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using ColorsGame;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\_Imports.razor"
using ColorsGame.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Counter.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 5 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Counter.razor"
     Count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Counter.razor"
                  StartCountdown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(5, "Start Timer");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Counter.razor"
            
    private int Count { get; set; } = 10;

    void StartCountdown()
    {
        var timer = new Timer(new TimerCallback(_ =>
        {
            if (Count > 0)
            {
                Count--;
                InvokeAsync(() =>
                {

                    StateHasChanged();
                });
            }
        }), null, 1000, 1000);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
