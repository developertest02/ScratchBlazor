#pragma checksum "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenDataGridColumn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0dd61bb2c1648e4b87816dfe9c95556d67c661fb"
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
    public partial class RadzenDataGridColumn<TItem> : ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 4 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenDataGridColumn.razor"
 if (Columns != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __Blazor.Radzen.Blazor.RadzenDataGridColumn.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#line 6 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenDataGridColumn.razor"
                          this.Grid

#line default
#line hidden
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
                __Blazor.Radzen.Blazor.RadzenDataGridColumn.TypeInference.CreateCascadingValue_1(__builder2, 5, 6, 
#line 7 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenDataGridColumn.razor"
                              this

#line default
#line hidden
                , 7, (__builder3) => {
                    __builder3.AddMarkupContent(8, "\r\n            ");
#line 8 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenDataGridColumn.razor"
__builder3.AddContent(9, Columns);

#line default
#line hidden
                    __builder3.AddMarkupContent(10, "\r\n        ");
                }
                );
                __builder2.AddMarkupContent(11, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(12, "\r\n");
#line 11 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenDataGridColumn.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenDataGridColumn
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
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
