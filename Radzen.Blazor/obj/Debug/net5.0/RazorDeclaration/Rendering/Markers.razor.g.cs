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
    public partial class Markers<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 14 "E:\Dev\radzen-blazor\Radzen.Blazor\Rendering\Markers.razor"
       
    [CascadingParameter]
    public RadzenChart Chart { get; set;}

    [Parameter]
    public IEnumerable<TItem> Data { get; set; }

    [Parameter]
    public Func<TItem, double> Category { get; set; }
    
    [Parameter]
    public Func<TItem, double> Value { get; set; }

    [Parameter]
    public MarkerType MarkerType { get; set; }

    [Parameter]
    public string Stroke { get; set; }

    [Parameter]
    public string Fill { get; set; }

    [Parameter]
    public double StrokeWidth { get; set; }

    [Parameter]
    public double Size { get; set; }

    private double x1;
    private double x2;

    private double y1;
    private double y2;

    private bool InPlotArea(double x, double y)
    {
        return x >= x1 && x <= x2 && y >= y1 && y <= y2;
    }

    protected override void OnParametersSet()
    {
        var categoryTicks = Chart.CategoryScale.Ticks(Chart.CategoryAxis.TickDistance);

        x1 = Chart.CategoryScale.Scale(categoryTicks.Start);
        x2 = Chart.CategoryScale.Scale(categoryTicks.End);

        var valueTicks = Chart.ValueScale.Ticks(Chart.ValueAxis.TickDistance);

        y1 = Chart.ValueScale.Scale(valueTicks.End);
        y2 = Chart.ValueScale.Scale(valueTicks.Start);
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
