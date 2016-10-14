// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : Legend.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System.ComponentModel;
using Magicodes.ECharts.CommonDefinitions;
using Magicodes.ECharts.Components.ToolTip;
using Magicodes.ECharts.ValueTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.ECharts.Components.Legend
{
    /// <summary>
    ///     图例组件
    /// </summary>
    public class Legend
    {
        public Legend()
        {
            Show = true;
        }

        /// <summary>
        ///     是否显示图例组件。
        /// </summary>
        [DefaultValue(true)]
        public bool Show { get; set; }

        /// <summary>
        ///     图例列表的布局朝向。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Orients Orient { get; set; }

        public int Padding { get; set; }

        /// <summary>
        ///     图例组件离容器左侧的距离。
        ///     left 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'。
        ///     如果 left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。
        /// </summary>
        public ILeftValue Left { get; set; }

        /// <summary>
        ///     图例组件离容器上侧的距离。
        ///     top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。
        ///     如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。
        /// </summary>
        public ITopValue Top { get; set; }

        /// <summary>
        ///     图例组件离容器右侧的距离。
        ///     right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        ///     默认自适应。
        /// </summary>
        public IRightValue Right { get; set; }

        /// <summary>
        ///     图例组件离容器下侧的距离。
        ///     bottom 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        ///     默认自适应。
        /// </summary>
        public IBottomValue Bottom { get; set; }

        /// <summary>
        ///     图例组件的宽度。默认自适应。
        /// </summary>
        public string Width { get; set; }

        ////    使用字符串模板，模板变量为图例名称 {name}
        ////        formatter: 'Legend {name}'
        ////    使用回调函数
        ////    formatter: function(name)
        ////    {
        ////        return 'Legend ' + name;
        ////    }
        /// <summary>
        ///     图例文本的内容格式器，支持字符串模板和回调函数两种形式。
        ///     示例：
        /// </summary>
        public string Formatter { get; set; }

        /// <summary>
        ///     图例选择的模式，默认开启图例选择，可以设成 false 关闭。
        ///     除此之外也可以设成 'single' 或者 'multiple' 使用单选或者多选模式。
        /// </summary>
        [DefaultValue(true)]
        public string SelectedMode { get; set; }

        ////示例：
        ////selected: {
        ////    // 选中'系列1'
        ////    '系列1': true,
        ////    // 不选中'系列2'
        ////    '系列2': false
        ////}
        /// <summary>
        ///     图例选中状态表。
        /// </summary>
        public object Selected { get; set; }

        //// legend: {
        ////    formatter: function(name)
        ////        {
        ////            return echarts.format.truncateText(name, 40, '14px Microsoft Yahei', '…');
        ////        },
        ////    tooltip: {
        ////        show: true
        ////    }
        ////}
        /// <summary>
        ///     图例的 tooltip 配置，配置项同 tooltip。默认不显示，可以在 legend 文字很多的时候对文字做裁剪并且开启 tooltip，如下示例：
        /// </summary>
        public Tooltip Tooltip { get; set; }

        /// <summary>
        ///     图例的数据数组。数组项通常为一个字符串，每一项代表一个系列的 name（如果是饼图，也可以是饼图单个数据的 name）。图例组件会自动获取对应系列的颜色，图形标记（symbol）作为自己绘制的颜色和标记，特殊字符串
        ///     ''（空字符串）或者 '\n' (换行字符串)用于图例的换行。
        /// </summary>
        public LegendData[] Data { get; set; }
    }
}