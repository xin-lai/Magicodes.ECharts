namespace Magicodes.ECharts.Axis
{
    public class LineStyle
    {
        /// <summary>
        /// 坐标轴线线的颜色。
        /// </summary>
        public string Color { get; set; }
        public double? Width { get; set; }
        /// <summary>
        /// 坐标轴线线的类型。
        /// </summary>
        public LineStyleTypes Type { get; set; }
    }
}