// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : Tooltip.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.ECharts.Components.ToolTip
{
    /// <summary>
    ///     提示框组件
    /// </summary>
    public class Tooltip
    {
        public Tooltip()
        {
            Show = true;
            ShowContent = true;
        }

        /// <summary>
        ///     是否显示标题组件。
        /// </summary>
        public bool Show { get; set; }

        /// <summary>
        ///     是否显示提示框浮层，默认显示。只需tooltip触发事件或显示axisPointer而不需要显示内容时可配置该项为false。
        /// </summary>
        public bool ShowContent { get; set; }

        /// <summary>
        ///     触发类型。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TooltipTriggerTypes Trigger { get; set; }

        /// <summary>
        ///     提示框触发的条件
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TooltipTriggerEvents TriggerOn { get; set; }

        ////        模板变量有 {a}, {b}，{c}，{d}，{e}，分别表示系列名，数据名，数据值等。 在 trigger 为 'axis' 的时候，会有多个系列的数据，此时可以通过 {a0}, {a1}, {a2} 这种后面加索引的方式表示系列的索引。 不同图表类型下的 {a}，{b}，{c}，{d} 含义不一样。 其中变量{a}, {b}, {c}, {d}在不同图表类型下代表数据含义为：
        ////            折线（区域）图、柱状（条形）图、K线图 : {a}（系列名称），{b}（类目值），{c}（数值）, {d}（无）
        ////            散点图（气泡）图 : {a}（系列名称），{b}（数据名称），{c}（数值数组）, {d}（无）
        ////            地图 : {a}（系列名称），{b}（区域名称），{c}（合并数值）, {d}（无）
        ////            饼图、仪表盘、漏斗图: {a}（系列名称），{b}（数据项名称），{c}（数值）, {d}（百分比）
        ////            更多其它图表模板变量的含义可以见相应的图表的 label.normal.formatter 配置项。
        ////            示例：
        ////            formatter: '{b0}: {c0}<br />{b1}: {c1}'
        ////回调函数。
        ////    回调函数格式：
        ////    (params: Object|Array, ticket: string, callback: (ticket: string, html: string)) => string
        ////    第一个参数 params 是 formatter 需要的数据集。格式如下：
        ////    {
        ////        componentType: 'series',
        ////        // 系列类型
        ////        seriesType: string,
        ////        // 系列在传入的 option.series 中的 index
        ////        seriesIndex: number,
        ////        // 系列名称
        ////        seriesName: string,
        ////        // 数据名，类目名
        ////        name: string,
        ////        // 数据在传入的 data 数组中的 index
        ////        dataIndex: number,
        ////        // 传入的原始数据项
        ////        data: Object,
        ////        // 传入的数据值
        ////        value: number|Array,
        ////        // 数据图形的颜色
        ////        color: string,

        ////        // 饼图的百分比
        ////        percent: number,

        ////    }
        ////    在 trigger 为 'axis' 的时候 params 是多个系列的数据数组。
        ////    注： ECharts 2.x 使用数组表示各参数的方式不再支持。
        ////    第二个参数 ticket 是异步回调标识，配合第三个参数 callback 使用。 第三个参数 callback 是异步回调，在提示框浮层内容是异步获取的时候，可以通过 callback 传入上述的 ticket 和 html 更新提示框浮层内容。
        ////    示例：
        ////     formatter: function(params, ticket, callback)
        ////    {
        ////         $.get('detail?name=' + params.name, function(content) {
        ////            callback(ticket, toHTML(content));
        ////        });
        ////        return 'Loading';
        ////    }
        /// <summary>
        ///     提示框浮层内容格式器，支持字符串模板和回调函数两种形式。
        ///     字符串模板。
        /// </summary>
        public string Formatter { get; set; }

        /// <summary>
        ///     提示框浮层的背景颜色。
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        ///     提示框浮层的边框颜色。
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        ///     提示框浮层的边框宽。
        /// </summary>
        public int BorderWidth { get; set; }
    }
}