#pragma checksum "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc2fd9521d596e09ca339ac7f9784bbc1ffc308"
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
#line 2 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
using Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Game")]
    public partial class Game : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
 if(ActuelGrid.GameIsNotStarted()==true)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                  Start

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(2, "Start!");
            __builder.CloseElement();
#nullable restore
#line 7 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
 if(ActuelGrid.GameIsStarted()==true)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddContent(4, "Level:");
            __builder.AddContent(5, 
#nullable restore
#line 10 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                niveau.Niveau

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddContent(8, "choise ");
            __builder.AddContent(9, 
#nullable restore
#line 11 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                 ActuelGrid.TrueColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table");
#nullable restore
#line 13 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
     for (var i = 0; i < ActuelGrid.Column; i++)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "tr");
#nullable restore
#line 16 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
             for (var j = 0; j < ActuelGrid.Row; j++)
            {
                switch (ActuelGrid.grid[i][j].Color)
                {
                    case Colors.green:
                        if (Colors.green == ActuelGrid.TrueColor)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "td");
            __builder.AddAttribute(15, "class", "Green-cell");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                             ColorFounded

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "class", "Green-cell");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                             Failed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        break;
                    case Colors.blue:
                        if (Colors.blue == ActuelGrid.TrueColor)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "td");
            __builder.AddAttribute(21, "class", "Blue-cell");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 33 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                            ColorFounded

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "class", "Blue-cell");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                            Failed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        break;
                    case Colors.yellow:
                        if (Colors.yellow == ActuelGrid.TrueColor)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "td");
            __builder.AddAttribute(27, "class", "Yellow-cell");
            __builder.AddAttribute(28, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                              ColorFounded

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 44 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "class", "Yellow-cell");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                              Failed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 48 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        break;
                    case Colors.red:
                        if (Colors.red == ActuelGrid.TrueColor)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "td");
            __builder.AddAttribute(33, "class", "Red-cell");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                           ColorFounded

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "Red-cell");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                           Failed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        break;
                    case Colors.black:
                        if (Colors.black == ActuelGrid.TrueColor)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "td");
            __builder.AddAttribute(39, "class", "Black-cell");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                             ColorFounded

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 64 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "class", "Black-cell");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                             Failed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 68 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        break;
                    case Colors.grey:
                        if (Colors.grey == ActuelGrid.TrueColor)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(44, "td");
            __builder.AddAttribute(45, "class", "Grey-cell");
            __builder.AddAttribute(46, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                            ColorFounded

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "class", "Grey-cell");
            __builder.AddAttribute(49, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 77 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                            Failed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        break;
                    case Colors.orange:
                        if (Colors.orange == ActuelGrid.TrueColor)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "class", "Orange-cell");
            __builder.AddAttribute(52, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                              ColorFounded

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "class", "Orange-cell");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                              Failed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        break;
                    case Colors.purple:
                        if (Colors.purple== ActuelGrid.TrueColor)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "class", "Purple-cell");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                              ColorFounded

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "td");
            __builder.AddAttribute(60, "class", "Purple-cell");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                                                              Failed

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 98 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                        }
                        break;
                }
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 105 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
}
else if(ActuelGrid.GameIsOver()== true)
      {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(62, "<div class=\"GameOver\">Game Over</div><hr>\r\n        ");
            __builder.OpenElement(63, "button");
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 109 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
                          Start

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(65, "Play again ");
            __builder.CloseElement();
#nullable restore
#line 110 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
      }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\ASUS\Desktop\Emna\stage\ColorsGame\ColorsGame\Pages\Game.razor"
 
    Level niveau = new Level(); 
    static int chance = 0;
    Grid ActuelGrid = new Grid();
    protected override Task OnInitializedAsync()
    {
        ActuelGrid.InitialGrid();
        return base.OnInitializedAsync();
    }

    public void Start()
    {
        ActuelGrid.StartGame();
    }

    public void ColorFounded()
    {
        Console.WriteLine("coool");
        chance = 0;
        niveau.NextLevel(ActuelGrid); 
        ActuelGrid.RefreshGrid(niveau.Niveau);
    }

    public void Failed()
    {
        chance++;
        if(chance==2)
        {
            Console.WriteLine("Game over");
            niveau.Niveau = 1;
            ActuelGrid.GameOver();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
