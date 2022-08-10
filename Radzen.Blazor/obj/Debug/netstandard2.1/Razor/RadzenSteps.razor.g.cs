#pragma checksum "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6ed5ca03b35ef3a956df8c03f03c6a682db0af9"
// <auto-generated/>
#pragma warning disable 1591
namespace Radzen.Blazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
using Radzen.Blazor;

#line default
#line hidden
#line 2 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#line 3 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#line 7 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
using System.Linq;

#line default
#line hidden
    public partial class RadzenSteps : RadzenComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#line 9 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
 if (Steps != null)
{

#line default
#line hidden
            __builder.AddContent(0, "    ");
            __Blazor.Radzen.Blazor.RadzenSteps.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#line 11 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                          this

#line default
#line hidden
            , 3, (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n        ");
#line 12 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
__builder2.AddContent(5, Steps);

#line default
#line hidden
                __builder2.AddMarkupContent(6, "\r\n    ");
            }
            );
            __builder.AddMarkupContent(7, "\r\n");
#line 14 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
}

#line default
#line hidden
#line 15 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
 if (Visible)
{

#line default
#line hidden
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "style", 
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                             Style

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(10, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                 Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(11, "class", 
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                     GetCssClass()

#line default
#line hidden
            );
            __builder.AddAttribute(12, "id", 
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                         GetId()

#line default
#line hidden
            );
            __builder.AddElementReferenceCapture(13, (__value) => {
#line 17 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
            Element = __value;

#line default
#line hidden
            }
            );
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "role", "tablist");
            __builder.AddMarkupContent(17, "\r\n");
#line 19 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
         for (var i = 0; i < steps.Count; i++)
        {
            var step = steps[i];
            

#line default
#line hidden
#line 22 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
             if (step.Visible)
            {

#line default
#line hidden
            __builder.AddContent(18, "                ");
            __builder.OpenElement(19, "li");
            __builder.AddAttribute(20, "class", 
#line 24 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                             $"rz-steps-item {(IsSelected(i, step) ? "rz-state-highlight rz-steps-current" : step.Disabled ? "rz-state-disabled" : "")}"

#line default
#line hidden
            );
            __builder.AddMultipleAttributes(21, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Collections.Generic.IEnumerable<global::System.Collections.Generic.KeyValuePair<string, object>>>(
#line 24 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                                                                                        step.Attributes

#line default
#line hidden
            ));
            __builder.AddAttribute(22, "style", 
#line 24 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                                                                                                                 step.Style

#line default
#line hidden
            );
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 25 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                   async (args) => { if (!step.Disabled) { await SelectStep(step, true); } }

#line default
#line hidden
            ));
            __builder.AddAttribute(26, "href", "javascript:void(0)");
            __builder.AddAttribute(27, "class", "rz-menuitem-link");
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "span");
            __builder.AddAttribute(30, "class", "rz-steps-number");
#line 26 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
__builder.AddContent(31, steps.Where(s => s.Visible).ToList().IndexOf(step) + 1);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
#line 27 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                         if (step.Template != null)
                        {
                            

#line default
#line hidden
#line 29 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
__builder.AddContent(33, step.Template(step));

#line default
#line hidden
#line 29 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                
                        }
                        else
                        {

#line default
#line hidden
            __builder.AddContent(34, "                            ");
            __builder.OpenElement(35, "span");
            __builder.AddAttribute(36, "class", "rz-steps-title");
#line 33 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
__builder.AddContent(37, step.Text);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n");
#line 34 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                        }

#line default
#line hidden
            __builder.AddContent(39, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
#line 37 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
            }

#line default
#line hidden
#line 37 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
             
        }

#line default
#line hidden
            __builder.AddContent(42, "    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
#line 41 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
     for (var i = 0; i < steps.Count; i++)
    {
        var step = steps[i];
        

#line default
#line hidden
#line 44 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
         if (step.Visible)
        {
            

#line default
#line hidden
#line 46 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
             if (IsSelected(i, step))
            {

#line default
#line hidden
            __builder.AddContent(44, "                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "rz-widget-content");
            __builder.AddMarkupContent(47, "\r\n");
#line 49 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                     if (step.ChildContent != null)
                    {
                        

#line default
#line hidden
#line 51 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
__builder.AddContent(48, step.ChildContent);

#line default
#line hidden
#line 51 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                          
                    }

#line default
#line hidden
            __builder.AddContent(49, "                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n");
#line 54 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
            }

#line default
#line hidden
#line 54 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
             
        }

#line default
#line hidden
#line 55 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
         
    }

#line default
#line hidden
#line 57 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
     if(ShowStepsButtons)
    {

#line default
#line hidden
            __builder.AddContent(51, "    ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "rz-steps-buttons");
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "class", 
#line 60 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                    $"rz-steps-prev {(IsFirstVisibleStep() ?  "rz-state-disabled" : "")}"

#line default
#line hidden
            );
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 60 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                       PrevStep

#line default
#line hidden
            ));
            __builder.AddAttribute(58, "href", "javascript:void(0)");
            __builder.AddMarkupContent(59, "<i class=\"rzi\">navigate_before</i>");
#line 60 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
__builder.AddContent(60, PreviousText);

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        ");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", 
#line 61 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                    $"rz-steps-next {(IsLastVisibleStep() ?  "rz-state-disabled" : "")}"

#line default
#line hidden
            );
            __builder.AddAttribute(64, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#line 61 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
                                                                                                      NextStep

#line default
#line hidden
            ));
            __builder.AddAttribute(65, "href", "javascript:void(0)");
#line 61 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
__builder.AddContent(66, NextText);

#line default
#line hidden
            __builder.AddMarkupContent(67, "<i class=\"rzi\">navigate_next</i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n");
#line 63 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
    }

#line default
#line hidden
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n");
#line 65 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSteps.razor"
}

#line default
#line hidden
        }
        #pragma warning restore 1998
    }
}
namespace __Blazor.Radzen.Blazor.RadzenSteps
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
