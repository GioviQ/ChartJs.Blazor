using System.Collections.Generic;
using ChartJs.Blazor.ChartJS.Common;
using ChartJs.Blazor.ChartJS.Common.Enums;
using ChartJs.Blazor.Util;

namespace ChartJs.Blazor.ChartJS.GaugeChart
{
    /// <inheritdoc/>
    public class GaugeDataset : GaugeDataset<double>
    {
        /// <inheritdoc/>
        public GaugeDataset() : base() { }

        /// <inheritdoc/>
        public GaugeDataset(IEnumerable<double> data) : base(data) { }
    }

    /// <summary>
    /// Represents a dataset for a Gauge chart.
    /// </summary>
    public class GaugeDataset<T> : Dataset<T>
    {
        /// <summary>
        /// Creates a new instance of <see cref="GaugeDataset{T}"/>.
        /// </summary>
        public GaugeDataset() : base(ChartType.Gauge) { }

        /// <summary>
        /// Creates a new instance of <see cref="GaugeDataset{T}"/> with initial data.
        /// </summary>
        /// <inheritdoc cref="GaugeDataset(bool)"/>
        public GaugeDataset(IEnumerable<T> data) : this()
        {
            AddRange(data);
        }

        /// <summary>
        /// Creates a new instance of <see cref="GaugeDataset{T}"/> with
        /// a custom <see cref="ChartType"/>. Use this constructor when
        /// you implement a Gauge-like chart.
        /// </summary>
        /// <param name="type">The <see cref="ChartType"/> to use instead of <see cref="ChartType.Gauge"/>.</param>
        protected GaugeDataset(ChartType type) : base(type) { }

        /// <summary>
        /// Gets or sets the background color of the arcs.
        /// This property should usually be indexed, otherwise it's hard to distinguish the individual arcs.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public IndexableOption<string> BackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the border alignment. When <see cref="BorderAlign.Center" /> is set,
        /// the borders of arcs next to each other will overlap. When <see cref="BorderAlign.Inner" />
        /// is set, it is guaranteed that all the borders will not overlap.
        /// </summary>
        public IndexableOption<BorderAlign> BorderAlign { get; set; }

        /// <summary>
        /// Gets or sets the border color of the arcs.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public IndexableOption<string> BorderColor { get; set; }

        /// <summary>
        /// Gets or sets the border width of the arcs (in pixels).
        /// </summary>
        public IndexableOption<int> BorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the background color of the arcs when hovered.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public IndexableOption<string> HoverBackgroundColor { get; set; }

        /// <summary>
        /// Gets or sets the border color of the arcs when hovered.
        /// <para>See <see cref="ColorUtil"/> for working with colors.</para>
        /// </summary>
        public IndexableOption<string> HoverBorderColor { get; set; }

        /// <summary>
        /// Gets or sets the border width of the arcs when hovered (in pixels).
        /// </summary>
        public IndexableOption<int> HoverBorderWidth { get; set; }

        /// <summary>
        /// Gets or sets the relative thickness of the dataset.
        /// Providing a value for <see cref="Weight"/> will cause the Gauge dataset to be
        /// drawn with a thickness relative to the sum of all the dataset weight values.
        /// </summary>
        public int? Weight { get; set; }

        public double Value { get; set; }
    }
}
