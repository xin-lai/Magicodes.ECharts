// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : TimeLine.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System.Collections.Generic;
using Magicodes.ECharts.Axis;
using Magicodes.ECharts.CommonDefinitions;
using Magicodes.ECharts.ValueTypes;

namespace Magicodes.ECharts.Components.TimeLine
{
    /// <summary>
    ///     timeline 组件，提供了在多个 ECharts option 间进行切换、播放等操作的功能。
    /// </summary>
    public class TimeLine
    {
        public TimeLine()
        {
            Show = true;
            Type = TimeLineTypes.slider;
            AxisType = AxisTypes.time;
            Loop = true;
            PlayInterval = 2000;
            Realtime = true;
        }

        /// <summary>
        ///     是否显示 timeline 组件。如果设置为false，不会显示，但是功能还存在。
        /// </summary>
        public bool Show { get; set; }

        /// <summary>
        ///     这个属性目前只支持为 slider，不需要更改。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TimeLineTypes Type { get; set; }

        /// <summary>
        ///     坐标轴类型。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AxisTypes AxisType { get; set; }

        /// <summary>
        ///     表示当前选中项是哪项。比如，currentIndex 为 0 时，表示当前选中项为 timeline.data[0]（即使用 options[0]）。
        /// </summary>
        public int CurrentIndex { get; set; }

        /// <summary>
        ///     表示是否自动播放。
        /// </summary>
        public bool AutoPlay { get; set; }

        /// <summary>
        ///     表示是否反向播放。
        /// </summary>
        public bool Rewind { get; set; }

        /// <summary>
        ///     表示是否循环播放。
        /// </summary>
        public bool Loop { get; set; }

        /// <summary>
        ///     表示播放的速度（跳动的间隔），单位毫秒（ms）。
        /// </summary>
        public int PlayInterval { get; set; }

        /// <summary>
        ///     拖动圆点的时候，是否实时更新视图。
        /// </summary>
        public bool Realtime { get; set; }

        /// <summary>
        ///     表示『播放』按钮的位置。可选值：'left'、'right'。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ControlPositions ControlPosition { get; set; }

        /// <summary>
        ///     gtimeline组件离容器左侧的距离。
        ///     left 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'。
        ///     如果 left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。
        /// </summary>
        public ILeftValue Left { get; set; }

        /// <summary>
        ///     timeline组件离容器上侧的距离。
        ///     top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。
        ///     如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。
        /// </summary>
        public ITopValue Top { get; set; }

        /// <summary>
        ///     timeline组件离容器右侧的距离。
        ///     right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        ///     默认自适应。
        /// </summary>
        public IRightValue Right { get; set; }

        /// <summary>
        ///     timeline组件离容器下侧的距离。
        ///     bottom 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        ///     默认自适应。
        /// </summary>
        public IBottomValue Bottom { get; set; }

        /// <summary>
        ///     摆放方式，可选值有：
        ///     'vertical'：竖直放置。
        ///     'horizontal'：水平放置。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Orients Orient { get; set; }

        /// <summary>
        ///     是否反向放置 timeline，反向则首位颠倒过来。
        /// </summary>
        public bool Inverse { get; set; }

        /// <summary>
        ///     timeline标记的图形。
        ///     ECharts 提供的标记类型包括 'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow'
        ///     也可以通过 'image://url' 设置为图片，其中 url 为图片的链接。
        ///     在 ECharts 3 里可以通过 'path://' 将图标设置为任意的矢量路径。这种方式相比于使用图片的方式，不用担心因为缩放而产生锯齿或模糊，而且可以设置为任意颜色。路径图形会自适应调整为合适（如果是 symbol 的话就是
        ///     symbolSize）的大小。路径的格式参见 SVG PathData。可以从 Adobe Illustrator 等工具编辑导出。
        /// </summary>
        public ISymbolValue Symbol { get; set; }

        /// <summary>
        ///     timeline标记的大小，可以设置成诸如 10 这样单一的数字，也可以用数组分开表示宽和高，例如 [20, 10] 表示标记宽为20，高为10。
        ///     [ default: 10 ]
        /// </summary>
        public int? SymbolSize { get; set; }

        /// <summary>
        ///     timeline 数据。Array 的每一项，可以是直接的数值。 如果需要对每个数据项单独进行样式定义，则数据项写成 Object。Object中，value属性为数值。
        /// </summary>
        public List<object> Data { get; set; }
    }
}