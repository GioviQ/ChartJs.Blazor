using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.ChartJS.Common.Enums;

namespace ChartJs.Blazor.ChartJS.GaugeChart
{
    /// <summary>
    /// Config for a <see cref="GaugeConfig"/>.
    /// </summary>
    public class GaugeConfig : ConfigBase<GaugeOptions>
    {
        /// <summary>
        /// Creates a new instance of <see cref="GaugeConfig"/>.
        /// </summary>
        public GaugeConfig() : base(ChartType.Gauge)
        {
        }
    }
}
