#pragma checksum "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenColorPickerItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a0060eaa73e9133e528feaad572daa0b2e1d5d5"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
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
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenColorPickerItem.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenColorPickerItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "rz-colorpicker-item");
            __builder.AddAttribute(2, "style", "background-color:" + " " + (
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenColorPickerItem.razor"
                                                           Background

#line default
#line hidden
            ));
            __builder.AddEventPreventDefaultAttribute(3, "onmousedown", true);
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenColorPickerItem.razor"
                                                                                                             OnClick

#line default
#line hidden
            ));
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
