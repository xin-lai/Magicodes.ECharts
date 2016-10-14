using Magicodes.ECharts.ValueTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.ECharts.Components.DataZoom
{
    /// <summary>
    /// dataZoom 组件 用于区域缩放，从而能自由关注细节的数据信息，或者概览数据整体，或者去除离群点的影响。
    /// </summary>
    public abstract class DataZoom
    {
        public DataZoom()
        {
            this.Show = true;
            this.Type = "inside";
        }
        public bool Show { get; set; }
        public string Id { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        protected string Type { get; set; }
        /// <summary>
        /// 数据过滤模式
        /// 当『只有 X 轴 或 只有 Y 轴受 dataZoom 组件控制』时，常使用 filterMode: 'filter'，这样能使另一个轴自适应过滤后的数值范围。
        /// 当『X 轴 Y 轴分别受 dataZoom 组件控制』时：
        ///     如果 X 轴和 Y 轴是『同等地位的、不应互相影响的』，比如在『双数值轴散点图』中，那么两个轴可都设为 fiterMode: 'empty'。
        ///     如果 X 轴为主，Y 轴为辅，比如在『柱状图』中，需要『拖动 dataZoomX 改变 X 轴过滤柱子时，Y 轴的范围也自适应剩余柱子的高度』，『拖动 dataZoomY 改变 Y 轴过滤柱子时，X 轴范围不受影响』，那么就 X轴设为 fiterMode: 'filter'，Y 轴设为 fiterMode: 'empty'，即主轴 'filter'，辅轴 'empty'。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public FilterModes? FilterMode { get; set; }
        /// <summary>
        /// 数据窗口范围的起始百分比。范围是：0 ~ 100。表示 0% ~ 100%。
        /// </summary>
        public int? Start { get; set; }
        /// <summary>
        /// 数据窗口范围的结束百分比。范围是：0 ~ 100。
        /// </summary>
        public int? End { get; set; }
        /// <summary>
        /// 数据窗口范围的起始数值。如果设置了 dataZoom-slider.start 则 startValue 失效。
        /// dataZoom-slider.startValue 和 dataZoom-slider.endValue 共同用 绝对数值 的形式定义了数据窗口范围。
        /// 注意，如果轴的类型为 category，则 startValue 既可以设置为 axis.data 数组的 index，也可以设置为数组值本身。 但是如果设置为数组值本身，会在内部自动转化为数组的 index。
        /// </summary>
        public INumberOrStringValue StartValue { get; set; }
        /// <summary>
        /// 数据窗口范围的结束数值。如果设置了 dataZoom-slider.end 则 endValue 失效。
        /// dataZoom-slider.startValue 和 dataZoom-slider.endValue 共同用 绝对数值 的形式定义了数据窗口范围。
        /// 注意，如果轴的类型为 category，则 endValue 即可以设置为 axis.data 数组的 index，也可以设置为数组值本身。 但是如果设置为数组值本身，会在内部自动转化为数组的 index。
        /// </summary>
        public INumberOrStringValue EndValue { get; set; }
        /// <summary>
        /// 设置 dataZoom-inside 组件控制的 y轴（即yAxis，是直角坐标系中的概念，参见 grid）。
        /// 不指定时，当 dataZoom-inside.orient 为 'vertical'时，默认控制和 dataZoom 平行的第一个 yAxis。但是不建议使用默认值，建议显式指定。
        /// 如果是 number 表示控制一个轴，如果是 Array 表示控制多个轴。
        /// </summary>
        public INumberOrArrayNumberValue XAxisIndex { get; set; }
    }
    /// <summary>
    /// 数据过滤模式
    /// </summary>
    public enum FilterModes
    {
        /// <summary>
        /// 当前数据窗口外的数据，被 过滤掉。即会影响其他轴的数据范围。
        /// </summary>
        filter,
        /// <summary>
        /// 当前数据窗口外的数据，被 设置为空。即不会影响其他轴的数据范围。
        /// </summary>
        empty
    }
    /// <summary>
    /// 内置型数据区域缩放组件（dataZoomInside）
    /// </summary>
    public class DataZoomInside : DataZoom
    {
        public DataZoomInside():base()
        {
            this.Type = "inside";
        }
    }
    /// <summary>
    /// 滑动条型数据区域缩放组件（dataZoomSlider）
    /// </summary>
    public class DataZoomSlider: DataZoom
    {
        public DataZoomSlider() : base()
        {
            this.Type = "slider";
        }
        /// <summary>
        /// 组件的背景颜色。
        /// </summary>
        public string BackgroundColor { get; set; }
        /// <summary>
        /// 拖动时，是否实时更新系列的视图。如果设置为 false，则只在拖拽结束的时候更新。
        /// </summary>
        public bool? Realtime { get; set; }

        /// <summary>
        /// 是否显示label，即拖拽时候显示详细数值信息。
        /// </summary>
        public bool? ShowDetail { get; set; }
    }
}
