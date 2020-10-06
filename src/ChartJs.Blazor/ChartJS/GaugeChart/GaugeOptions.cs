using System;
using ChartJs.Blazor.ChartJS.PieChart;

namespace ChartJs.Blazor.ChartJS.GaugeChart
{
    public class GaugeOptions : PieOptions
    {
        public GaugeOptions() : base(true)
        {
            Rotation = -Math.PI;
            Circumference = Math.PI;
        }

        public Needle Niddle { get; set; }

        public ValueLabel ValueLabel { get; set; }
    }
}
