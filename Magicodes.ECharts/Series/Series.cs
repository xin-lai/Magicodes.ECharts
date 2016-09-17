// ======================================================================
// 
//         Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//         All rights reserved
// 
//         filename :Series.cs
//         description :
// 
//         created by 李文强 at  2016/09/17 19:16
//         Blog：http://www.cnblogs.com/codelove/
//         Home：http://xin-lai.com
// 
// ======================================================================

using System.Collections.Generic;
using Magicodes.ECharts.Series.Mark;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.ECharts.Series
{
    /// <summary>
    ///     系列列表。每个系列通过 type 决定自己的图表类型
    /// </summary>
    public class Series
    {
        /// <summary>
        ///     系列名称，用于tooltip的显示，legend 的图例筛选，在 setOption 更新数据和配置项时用于指定对应的系列。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     类型
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public SeriesTypes Type { get; set; }

        /// <summary>
        ///     图形上的文本标签，可用于说明图形的一些数据信息，比如值，名称等，label选项在 ECharts 2.x 中放置于itemStyle.normal下，在 ECharts 3 中为了让整个配置项结构更扁平合理，label 被拿出来跟
        ///     itemStyle 平级，并且跟 itemStyle 一样拥有 normal, emphasis 两个状态。
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        ///     系列中的数据内容数组。数组项通常为具体的数据项。数据格式有下面几种情况:
        ///     1.在坐标系一个轴为类目轴的时候，数据可以是一维的数值，数组长度等于所使用类目轴文本标签数组 xAxis.data 的长度，并且他们间是一一对应的，如下：[12, 34, 56, 10, 23]
        ///     2.在坐标系两个轴都为数值轴的时候，每个数据项需要是一个数组，并且至少有两个值表示直角坐标系上的 x、y 或者极坐标系上的 radius、angle，如下： [[3.4, 4.5, 15], [4.2, 2.3, 20],
        ///     [10.8, 9.5, 30], [7.2, 8.8, 18]]。每一项数值数组从第三个值开始可以表示数据的其它维度，配合 visualMap 组件可以将指定的一个或多个维度映射到颜色，大小等多个图形属性上。
        ///     3.在坐标系两个轴都为类目轴的时候，每个数据项也需要是一个数组，单个数据项至少要有两个值表示在两个轴上类目的索引或者类目的名称，如下： [[0, 0, 2], ['星期一', 2, 1], [2, 1, 2], [3, 3,
        ///     5]]。每一项数值数组从第三个值开始可以表示数据的其它维度，配合 visualMap 组件可以将指定的一个或多个维度映射到颜色，大小等多个图形属性上。
        ///     当某类目对应数据不存在时（ps：不存在不代表值为 0），可用-表示，无数据在折线图中表现为该点是断开的，在其它图中表示为图形不存在。
        /// </summary>
        public List<object> Data { get; set; }

        /// <summary>
        ///     图表标注。
        /// </summary>
        public MarkPoint MarkPoint { get; set; }

        /// <summary>
        ///     图表标线
        /// </summary>
        public MarkLine MarkLine { get; set; }

        /// <summary>
        ///     对应yAxis数组里的对应的坐标 默认0
        /// </summary>
        public int YAxisIndex { get; set; }
    }
}