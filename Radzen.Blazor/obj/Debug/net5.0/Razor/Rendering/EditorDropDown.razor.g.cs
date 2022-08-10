#pragma checksum "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b76c343e1edb82af4bb5acd06a772309e374cd04"
// <auto-generated/>
#pragma warning disable 1591
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
#line 2 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
using Microsoft.JSInterop;

#line default
#line hidden
    public partial class EditorDropDown : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "title", 
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
            Title

#line default
#line hidden
            );
            __builder.AddAttribute(2, "class", 
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                                       Class

#line default
#line hidden
            );
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                                                       Toggle

#line default
#line hidden
            ));
            __builder.AddEventPreventDefaultAttribute(4, "onmousedown", true);
            __builder.AddMultipleAttributes(5, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                                                                                                       Attributes

#line default
#line hidden
            ));
            __builder.AddElementReferenceCapture(6, (__value) => {
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                        Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "rz-html-editor-dropdown-value");
            __builder.AddMarkupContent(10, "\r\n");
#line 5 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
         if (SelectedItem != null)
        {
            

#line default
#line hidden
#line 7 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
__builder.AddContent(11, SelectedItem.Text);

#line default
#line hidden
#line 7 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                              
        }
        else
        {
            

#line default
#line hidden
#line 11 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
__builder.AddContent(12, Placeholder);

#line default
#line hidden
#line 11 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                        
        }

#line default
#line hidden
            __builder.AddContent(13, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddEventPreventDefaultAttribute(16, "onclick", true);
            __builder.AddAttribute(17, "tabindex", "-1");
            __builder.AddAttribute(18, "class", "rz-html-editor-dropdown-trigger");
            __builder.AddAttribute(19, "disabled", 
#line 14 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                                                                                                    Editor.Disabled

#line default
#line hidden
            );
            __builder.AddMarkupContent(20, "<i class=\"rzi\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.OpenComponent<Radzen.Blazor.Rendering.Popup>(22);
            __builder.AddAttribute(23, "class", "rz-html-editor-dropdown-items");
            __builder.AddAttribute(24, "Style", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 15 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                                                                   PopupStyle

#line default
#line hidden
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n        ");
                __Blazor.Radzen.Blazor.Rendering.EditorDropDown.TypeInference.CreateCascadingValue_0(__builder2, 27, 28, 
#line 16 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                               this

#line default
#line hidden
                , 29, (__builder3) => {
                    __builder3.AddMarkupContent(30, "\r\n            ");
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
__builder3.AddContent(31, ChildContent);

#line default
#line hidden
                    __builder3.AddMarkupContent(32, "\r\n        ");
                }
                );
                __builder2.AddMarkupContent(33, "\r\n    ");
            }
            ));
            __builder.AddComponentReferenceCapture(34, (__value) => {
#line 15 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
                Popup = (Radzen.Blazor.Rendering.Popup)__value;

#line default
#line hidden
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#line 21 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\EditorDropDown.razor"
       
    [CascadingParameter]
    public RadzenHtmlEditor Editor { get; set; }

    Popup Popup { get; set; } 

    [Parameter]
    public string Title { get; set; }

    [Parameter]
    public RenderFragment ChildContent { get; set; }

    [Parameter]
    public string PopupStyle { get; set; }

    [Parameter]
    public string Placeholder { get; set; }

    async Task Toggle()
    {
        if (!Editor.Disabled)
        {
            await Popup.ToggleAsync(Element);
        }
    }

    [Parameter]
    public string Value { get; set; }

    internal EditorDropDownItem SelectedItem { get; set; }

    [Parameter]
    public EventCallback<string> ValueChanged { get; set; }

    [Parameter]
    public EventCallback<string> Change { get; set; }

    internal async Task Select(EditorDropDownItem item, bool change)
    {
        if (SelectedItem != item && !Editor.Disabled)
        {
            SelectedItem = item;

            if (change)
            {
                await Popup.CloseAsync();
                await ValueChanged.InvokeAsync(item?.Value);
                await Change.InvokeAsync(item?.Value);
            }

            StateHasChanged();
        }
    }

    string Class
    {
        get
        {
            var classList = new List<string>() { "rz-html-editor-dropdown" };

            if (Editor.Disabled)
            {
                classList.Add("rz-disabled");
            }

            return string.Join(" ", classList);
        }
    }

#line default
#line hidden
    }
}
namespace __Blazor.Radzen.Blazor.Rendering.EditorDropDown
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
