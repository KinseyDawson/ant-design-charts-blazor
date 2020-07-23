using System.Text.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Text;

namespace AntDesign.Charts
{
    public interface ILegendMarkerStyle : IGraphicStyle
    {
        [JsonPropertyName("r")]
        public int? R { get; set; }
    }

    public class LegendMarkerStyle : ILegendMarkerStyle
    {
[JsonPropertyName("r")]
public int? R { get; set; }
[JsonPropertyName("fill")]
public string Fill { get; set; }
[JsonPropertyName("fillOpacity")]
public decimal? FillOpacity { get; set; }
[JsonPropertyName("stroke")]
public string Stroke { get; set; }
[JsonPropertyName("lineWidth")]
public int? LineWidth { get; set; }
[JsonPropertyName("lineDash")]
public int[] LineDash { get; set; }
[JsonPropertyName("lineOpacity")]
public int? LineOpacity { get; set; }
[JsonPropertyName("opacity")]
public int? Opacity { get; set; }
[JsonPropertyName("shadowColor")]
public string ShadowColor { get; set; }
[JsonPropertyName("shadowBlur")]
public int? ShadowBlur { get; set; }
[JsonPropertyName("shadowOffsetX")]
public int? ShadowOffsetX { get; set; }
[JsonPropertyName("shadowOffsetY")]
public int? ShadowOffsetY { get; set; }
[JsonPropertyName("cursor")]
public string Cursor { get; set; }
    }
}


