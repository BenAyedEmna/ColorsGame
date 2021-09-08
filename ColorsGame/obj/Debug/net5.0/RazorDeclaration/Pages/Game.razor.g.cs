// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Game")]
    public partial class Game : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
 
    Level niveau = new Level();
    Grid ActuelGrid = new Grid();
    protected override Task OnInitializedAsync()
    {
        ActuelGrid.InitialGrid();
        niveau.Counter = 10;
        return base.OnInitializedAsync();
    }

    public void Start()
    {
        ActuelGrid.StartGame();
    }

    public void ColorFounded()
    {
        Console.WriteLine("coool");
        niveau.NextLevel(ActuelGrid);
        ActuelGrid.RefreshGrid(niveau.Niveau);
        if (niveau.Niveau > 6)
        {
            ActuelGrid.StartCountingTime();
        }
    }

    public void Failed()
    {
        niveau.Chance++;
        if (niveau.Chance == 2)
        {
            Console.WriteLine("Game over");
            ActuelGrid.GameOver();
            niveau.Niveau = 1;
        }
    }

    private int Count;
    public void StartCountdown()
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

    public void SwitchPlace()
    {
        Count = niveau.Counter;
        StartCountdown();
        if (Count == 0)
        {
            for (var k = 0; k < ActuelGrid.Column; k++)
            {
                for (var l = 0; l < ActuelGrid.Row; l++)
                {
                    ActuelGrid.grid[k][l].Color = ActuelGrid.FalseColor;
                }
            }
            ActuelGrid.RandomCellColored();
            SwitchPlace();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
