#pragma checksum "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66c412d285cfbf2455a93a33e4fedf9c2c29e899"
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
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
using Radzen;

#line default
#line hidden
#line 2 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
using System.Linq.Dynamic.Core;

#line default
#line hidden
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 4 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#line 5 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
using Microsoft.AspNetCore.Components.Rendering;

#line default
#line hidden
    public partial class RadzenListBox<TValue> : DropDownBase<TValue>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                 Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(3, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                     Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(4, "class", 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                         GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(5, "tabindex", 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                                                   TabIndex

#line default
#line hidden
            );
            __builder.AddAttribute(6, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                                                                          OnKeyDown

#line default
#line hidden
            ));
            __builder.AddAttribute(7, "id", 
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                                                                                          GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(8, (__value) => {
#line 10 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "rz-helper-hidden-accessible");
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "name", 
#line 12 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                          Name

#line default
#line hidden
            );
            __builder.AddAttribute(15, "readonly", 
#line 12 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                           ReadOnly

#line default
#line hidden
            );
            __builder.AddAttribute(16, "disabled", 
#line 12 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                Disabled

#line default
#line hidden
            );
            __builder.AddAttribute(17, "type", "text");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#line 14 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
         if (AllowFiltering || Multiple)
        {

#line default
#line hidden
            __builder.AddContent(20, "            ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", " rz-listbox-header rz-helper-clearfix rz-listbox-header-w-checkbox");
            __builder.AddMarkupContent(23, "\r\n");
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                 if (Multiple)
                {

#line default
#line hidden
            __builder.AddContent(24, "                    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "rz-chkbox ");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 19 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                       SelectAll

#line default
#line hidden
            ));
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "rz-helper-hidden-accessible");
            __builder.AddMarkupContent(31, "\r\n                            ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "id", 
#line 21 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                         $"{UniqueID}sa"

#line default
#line hidden
            );
            __builder.AddAttribute(34, "readonly", "readonly");
            __builder.AddAttribute(35, "type", "checkbox");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", 
#line 23 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                      IsAllSelected() ? "rz-chkbox-box rz-state-active" : "rz-chkbox-box"

#line default
#line hidden
            );
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "span");
            __builder.AddAttribute(42, "class", 
#line 24 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                           IsAllSelected() ? "rz-chkbox-icon rzi rzi-check" : "rz-chkbox-icon"

#line default
#line hidden
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n");
#line 27 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                     if (!AllowFiltering && !string.IsNullOrEmpty(Placeholder))
                    {

#line default
#line hidden
            __builder.AddContent(46, "                        ");
            __builder.OpenElement(47, "label");
            __builder.AddAttribute(48, "for", 
#line 29 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                      $"{UniqueID}sa"

#line default
#line hidden
            );
            __builder.AddAttribute(49, "class", "rz-dropdown-label rz-inputtext");
            __builder.AddAttribute(50, "style", "width:100%;");
#line 29 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
__builder.AddContent(51, Placeholder);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n");
#line 30 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                    }

#line default
#line hidden
#line 30 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                     
                }

#line default
#line hidden
#line 32 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                 if (AllowFiltering)
                {

#line default
#line hidden
            __builder.AddContent(53, "                    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "rz-listbox-filter-container");
            __builder.AddMarkupContent(56, "\r\n                        ");
            __builder.OpenElement(57, "input");
            __builder.AddAttribute(58, "id", 
#line 35 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                    SearchID

#line default
#line hidden
            );
            __builder.AddAttribute(59, "disabled", 
#line 35 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                        Disabled

#line default
#line hidden
            );
            __builder.AddAttribute(60, "class", "rz-inputtext");
            __builder.AddAttribute(61, "role", "textbox");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "placeholder", 
#line 35 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                                                                                                Placeholder

#line default
#line hidden
            );
            __builder.AddAttribute(64, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#line 36 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                            (args) => OnFilter(args)

#line default
#line hidden
            ));
            __builder.AddAttribute(65, "onkeydown", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#line 36 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                                     (args) => OnFilterKeyPress(args)

#line default
#line hidden
            ));
            __builder.AddAttribute(66, "value", 
#line 36 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                                                                                searchText

#line default
#line hidden
            );
            __builder.AddEventStopPropagationAttribute(67, "onkeydown", 
#line 36 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                                                                                                                                        true

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(68, (__value) => {
#line 35 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                                                     search = __value;

#line default
#line hidden
            }
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        <span class=\"rz-listbox-filter-icon rzi rzi-search\"></span>\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#line 39 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                }

#line default
#line hidden
            __builder.AddContent(71, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n");
#line 41 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
        }

#line default
#line hidden
#line 42 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
         if (View != null)
        {

#line default
#line hidden
            __builder.AddContent(73, "            ");
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "rz-listbox-list-wrapper");
            __builder.AddMarkupContent(76, "\r\n                ");
            __builder.OpenElement(77, "ul");
            __builder.AddAttribute(78, "class", "rz-listbox-list");
            __builder.AddElementReferenceCapture(79, (__value) => {
#line 45 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
                          list = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(80, "\r\n                    ");
#line 46 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
__builder.AddContent(81, RenderItems());

#line default
#line hidden
            __builder.AddMarkupContent(82, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(84, "\r\n");
#line 49 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
        }

#line default
#line hidden
            __builder.AddContent(85, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n");
#line 51 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenListBox.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
