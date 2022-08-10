// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 1 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSeriesDataLabels.razor"
using Radzen.Blazor.Rendering;

#line default
#line hidden
    public partial class RadzenSeriesDataLabels : RadzenChartComponentBase, IChartSeriesOverlay
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#line 5 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSeriesDataLabels.razor"
       
    IChartSeries series;

    [CascadingParameter]
    protected IChartSeries Series 
    { 
        get
        {
            return series;
        }
        set
        {
            if (!value.Overlays.Contains(this))
            {
                series = value;
                series.Overlays.Add(this);
            }
        }
    }

    public RenderFragment Render(ScaleBase categoryScale, ScaleBase valueScale)
    {
        return builder =>
        {
            builder.OpenRegion(0);
            foreach (var label in series.GetDataLabels(OffsetX, OffsetY))
            {
                builder.AddContent(1,
                    

#line default
#line hidden
        (__builder2) => {
            __builder2.OpenElement(0, "g");
            __builder2.AddMarkupContent(1, "\r\n                        ");
            __builder2.OpenElement(2, "Text");
            __builder2.AddAttribute(3, "@key", 
#line 34 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSeriesDataLabels.razor"
                                      $"{label.Position}-{Chart.Series.IndexOf(series)}"

#line default
#line hidden
            );
            __builder2.AddAttribute(4, "Value", 
#line 35 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSeriesDataLabels.razor"
                                    label.Text

#line default
#line hidden
            );
            __builder2.AddAttribute(5, "Position", 
#line 35 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSeriesDataLabels.razor"
                                                           label.Position

#line default
#line hidden
            );
            __builder2.AddAttribute(6, "TextAnchor", 
#line 35 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSeriesDataLabels.razor"
                                                                                        label.TextAnchor

#line default
#line hidden
            );
            __builder2.AddAttribute(7, "Class", "rz-series-data-label");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(8, "\r\n                    ");
            __builder2.CloseElement();
            __builder2.AddMarkupContent(9, "\r\n");
        }
#line 37 "E:\Dev\radzen-blazor\Radzen.Blazor\RadzenSeriesDataLabels.razor"
                    );
            }
            builder.CloseRegion();
        };
    }

    protected override bool ShouldRefreshChart(ParameterView parameters)
    {
        return parameters.DidParameterChange(nameof(Visible), Visible);
    }
    
    public bool Contains(double mouseX, double mouseY, int tolerance)
    {
        return false;
    }

    public RenderFragment RenderTooltip(double mouseX, double mouseY, double marginLeft, double marginTop)
    {
        return null;
    }

#line default
#line hidden
    }
}
#pragma warning restore 1591
