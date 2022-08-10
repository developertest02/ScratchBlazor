// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Radzen.Blazor.Rendering
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
    public partial class EditorColorPicker : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorColorPicker.razor"
       
    [CascadingParameter]
    public RadzenHtmlEditor Editor { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public string Icon { get; set; }

    [Parameter]
    public string Value { get; set; }

    [Parameter]
    public bool ShowHSV { get; set; } = true;

    [Parameter]
    public bool ShowRGBA { get; set; } = true;

    [Parameter]
    public bool ShowColors { get; set; } = true;

    [Parameter]
    public bool ShowButton { get; set; } = true;

    [Parameter]
    public string HexText { get; set; } = "Hex";

    [Parameter]
    public string RedText { get; set; } = "R";

    [Parameter]
    public string GreenText { get; set; } = "G";

    [Parameter]
    public string BlueText { get; set; } = "B";

    [Parameter]
    public string AlphaText { get; set; } = "A";

    [Parameter]
    public string ButtonText { get; set; } = "OK";

    [Parameter]
    public EventCallback<string> Change { get; set; }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    async Task OnChange(string value)
    {
        await Editor.RestoreSelectionAsync();
        await ValueChanged.InvokeAsync(value);
        await Change.InvokeAsync(value);
    }

    async Task OnOpen()
    {
        await Editor.SaveSelectionAsync();
    }

    async Task OnClick()
    {
        await Change.InvokeAsync(Value);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
