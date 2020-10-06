using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.Util;

namespace ChartJs.Blazor.ChartJS.GaugeChart
{
    public class Needle
    {
        public double RadiusPercentage { get; set; } = 2;

        public double WidthPercentage { get; set; } = 3.2;

        public double LengthPercentage { get; set; } = 80;

        public IndexableOption<string> Color { get; set; } = ColorUtil.ColorString(0, 0, 0, 1);
    }
}
