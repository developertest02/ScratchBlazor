#pragma checksum "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de52e6bf60c7d225400be2ad73d6c29fdcd813e9"
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
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
using Radzen;

#line default
#line hidden
#line 2 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
    public partial class RadzenCheckBox<TValue> : FormComponent<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 6 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.OpenElement(0, "div");
            __builder.AddMultipleAttributes(1, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                  Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "class", 
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                      GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(3, "onkeypress", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                                                  OnKeyPress

#line default
#line hidden
            ));
            __builder.AddEventPreventDefaultAttribute(4, "onkeypress", true);
            __builder.AddAttribute(5, "style", 
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                                                                                                Style

#line default
#line hidden
            );
            __builder.AddAttribute(6, "tabindex", 
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                                                                                                                  TabIndex

#line default
#line hidden
            );
            __builder.AddAttribute(7, "id", 
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                                                                                                                                 GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(8, (__value) => {
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
            Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "rz-helper-hidden-accessible");
            __builder.AddMarkupContent(12, "\r\n        ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "checkbox");
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                          Toggle

#line default
#line hidden
            ));
            __builder.AddAttribute(16, "value", 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                        CheckBoxValue

#line default
#line hidden
            );
            __builder.AddAttribute(17, "name", 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                                            Name

#line default
#line hidden
            );
            __builder.AddAttribute(18, "id", 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                                                     Name

#line default
#line hidden
            );
            __builder.AddAttribute(19, "checked", 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                                                                                   CheckBoxChecked

#line default
#line hidden
            );
            __builder.AddAttribute(20, "tabindex", "-1");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n    ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", 
#line 13 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                BoxClassList

#line default
#line hidden
            );
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 13 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                                       Toggle

#line default
#line hidden
            ));
            __builder.AddEventPreventDefaultAttribute(26, "onclick", true);
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "span");
            __builder.AddAttribute(29, "class", 
#line 14 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
                     IconClassList

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenCheckBox.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
