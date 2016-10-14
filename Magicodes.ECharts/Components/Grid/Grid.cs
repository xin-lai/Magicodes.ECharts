using Magicodes.ECharts.ValueTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.ECharts.Components.Grid
{
    /// <summary>
    /// 直角坐标系内绘图网格，单个 grid 内最多可以放置上下两个 X 轴，左右两个 Y 轴。可以在网格上绘制折线图，柱状图，散点图（气泡图）。
    /// 在 ECharts 2.x 里单个 echarts 实例中最多只能存在一个 grid 组件，在 ECharts 3 中可以存在任意个 grid 组件。
    /// </summary>
    public class Grid
    {
        /// <summary>
        /// 是否显示直角坐标系网格。
        /// </summary>
        public bool? Show { get; set; }
        /// <summary>
        /// 所有图形的 zlevel 值。
        /// zlevel用于 Canvas 分层，不同zlevel值的图形会放置在不同的 Canvas 中，Canvas 分层是一种常见的优化手段。我们可以把一些图形变化频繁（例如有动画）的组件设置成一个单独的zlevel。需要注意的是过多的 Canvas 会引起内存开销的增大，在手机端上需要谨慎使用以防崩溃。
        /// zlevel 大的 Canvas 会放在 zlevel 小的 Canvas 的上面。
        /// </summary>
        public int Zlevel { get; set; }

        /// <summary>
        ///     grid 组件离容器左侧的距离。
        ///     left 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'。
        ///     如果 left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。
        /// </summary>
        public ILeftValue Left { get; set; }

        /// <summary>
        ///     grid 组件离容器上侧的距离。
        ///     top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。
        ///     如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。
        /// </summary>
        public ITopValue Top { get; set; }

        /// <summary>
        ///     grid 组件离容器右侧的距离。
        ///     right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        ///     默认自适应。
        /// </summary>
        public IRightValue Right { get; set; }

        /// <summary>
        ///     grid 组件离容器下侧的距离。
        ///     bottom 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        ///     默认自适应。
        /// </summary>
        public IBottomValue Bottom { get; set; }

        /// <summary>
        ///     grid 组件的宽度。默认自适应。
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// grid 组件的高度。默认自适应。
        /// </summary>
        public string Height { get; set; }

        /// <summary>
        /// grid 区域是否包含坐标轴的刻度标签，在无法确定坐标轴标签的宽度，容器有比较小无法预留较多空间的时候，可以设为 true 防止标签溢出容器。
        /// </summary>
        public bool? ContainLabel { get; set; }

        /// <summary>
        /// 网格背景色，默认透明。
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        /// 网格的边框颜色。支持的颜色格式同 backgroundColor。
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        /// 图形阴影的模糊大小。该属性配合 shadowColor,shadowOffsetX, shadowOffsetY 一起设置图形的阴影效果。
        /// </summary>

        public double? ShadowBlur { get; set; }


        /// <summary>
        /// 阴影颜色。支持的格式同color。
        /// </summary>
        public string ShadowColor { get; set; }

        /// <summary>
        /// 阴影水平方向上的偏移距离。
        /// </summary>
        public double? ShadowOffsetX { get; set; }

        /// <summary>
        /// 阴影垂直方向上的偏移距离。
        /// </summary>
        public double? ShadowOffsetY { get; set; }

    }
}
