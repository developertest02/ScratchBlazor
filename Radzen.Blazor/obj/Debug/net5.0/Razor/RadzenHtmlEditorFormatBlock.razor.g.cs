#pragma checksum "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c2c0c47f3eaa6d813e8691f1b5aaf41ce2f945f"
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
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenHtmlEditorFormatBlock : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Radzen.Blazor.Rendering.EditorDropDown>(0);
            __builder.AddAttribute(1, "Title", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
                       Title

#line default
#line hidden
            ));
            __builder.AddAttribute(2, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
                                    Editor.State.FormatBlock

#line default
#line hidden
            ));
            __builder.AddAttribute(3, "Change", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, 
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
                                                                     OnChange

#line default
#line hidden
            )));
            __builder.AddAttribute(4, "Placeholder", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
                                                                                            Placeholder

#line default
#line hidden
            ));
            __builder.AddAttribute(5, "PopupStyle", "width: 200px; max-height: 200px; overflow: auto;");
            __builder.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.EditorDropDownItem>(8);
                __builder2.AddAttribute(9, "Text", "Normal");
                __builder2.AddAttribute(10, "Value", "p");
                __builder2.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(12, "\r\n        ");
                    __builder3.OpenElement(13, "p");
                    __builder3.AddAttribute(14, "style", "margin:0");
#line 6 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
__builder3.AddContent(15, context.Text);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(16, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.EditorDropDownItem>(18);
                __builder2.AddAttribute(19, "Text", "Heading 1");
                __builder2.AddAttribute(20, "Value", "h1");
                __builder2.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(22, "\r\n        ");
                    __builder3.OpenElement(23, "h1");
#line 9 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
__builder3.AddContent(24, context.Text);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(25, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(26, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.EditorDropDownItem>(27);
                __builder2.AddAttribute(28, "Text", "Heading 2");
                __builder2.AddAttribute(29, "Value", "h2");
                __builder2.AddAttribute(30, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(31, "\r\n        ");
                    __builder3.OpenElement(32, "h2");
#line 12 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
__builder3.AddContent(33, context.Text);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(34, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.EditorDropDownItem>(36);
                __builder2.AddAttribute(37, "Text", "Heading 3");
                __builder2.AddAttribute(38, "Value", "h3");
                __builder2.AddAttribute(39, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(40, "\r\n        ");
                    __builder3.OpenElement(41, "h3");
#line 15 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
__builder3.AddContent(42, context.Text);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(43, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.EditorDropDownItem>(45);
                __builder2.AddAttribute(46, "Text", "Heading 4");
                __builder2.AddAttribute(47, "Value", "h4");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n        ");
                    __builder3.OpenElement(50, "h4");
#line 18 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
__builder3.AddContent(51, context.Text);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(52, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.EditorDropDownItem>(54);
                __builder2.AddAttribute(55, "Text", "Heading 5");
                __builder2.AddAttribute(56, "Value", "h5");
                __builder2.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(58, "\r\n        ");
                    __builder3.OpenElement(59, "h5");
#line 21 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
__builder3.AddContent(60, context.Text);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(61, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(62, "\r\n    ");
                __builder2.OpenComponent<Radzen.Blazor.Rendering.EditorDropDownItem>(63);
                __builder2.AddAttribute(64, "Text", "Heading 6");
                __builder2.AddAttribute(65, "Value", "h6");
                __builder2.AddAttribute(66, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Radzen.Blazor.Rendering.EditorDropDownItem>)((context) => (__builder3) => {
                    __builder3.AddMarkupContent(67, "\r\n        ");
                    __builder3.OpenElement(68, "h6");
#line 24 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenHtmlEditorFormatBlock.razor"
__builder3.AddContent(69, context.Text);

#line default
#line hidden
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(70, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(71, "\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
