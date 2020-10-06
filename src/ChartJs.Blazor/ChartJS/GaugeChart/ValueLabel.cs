using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.Util;

namespace ChartJs.Blazor.ChartJS.GaugeChart
{
    public class ValueLabel
    {
        public bool Display { get; set; } = true;

        public double? FontSize { get; set; }

        public IndexableOption<string> Color { get; set; } = ColorUtil.ColorString(255, 255, 255, 1);

        public IndexableOption<string> BackgroundColor { get; set; } = ColorUtil.ColorString(0, 0, 0, 1);

        public double BorderRadius { get; set; } = 5;

        public Padding Padding { get; set; }

        public double BottomMarginPercentage { get; set; } = 5;
    }

    public class Padding
    {
        public int Top { get; set; } = 5;

        public int Right { get; set; } = 5;

        public int Bottom { get; set; } = 5;

        public int Left { get; set; } = 5;
    }
}
