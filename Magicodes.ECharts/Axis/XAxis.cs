// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : XAxis.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System.Collections.Generic;
using Magicodes.ECharts.CommonDefinitions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.ECharts.Axis
{
    /// <summary>
    ///     直角坐标系 grid 中的 x 轴，单个 grid 组件最多只能放上下两个 x 轴。
    /// </summary>
    public class XAxis
    {
        /// <summary>
        ///     x 轴的位置。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public XAxisPosition Position { get; set; }

        /// <summary>
        ///     坐标轴类型。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AxisTypes Type { get; set; }

        /// <summary>
        ///     坐标轴名称。
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     坐标轴名称显示位置。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public NameLocations NameLocation { get; set; }

        /// <summary>
        ///     类目数据，在类目轴（type: 'category'）中有效。
        /// </summary>
        public List<object> Data { get; set; }

        /// <summary>
        ///     坐标轴刻度标签的相关设置。
        /// </summary>
        public Label AxisLabel { get; set; }

        /// <summary>
        /// 坐标轴两边留白策略，类目轴和非类目轴的设置和表现不一样。
        /// 类目轴中 boundaryGap 可以配置为 true 和 false。默认为 true，这时候刻度只是作为分隔线，标签和数据点都会在两个刻度之间的带(band)中间。
        /// 非类目轴，包括时间，数值，对数轴，boundaryGap是一个两个值的数组，分别表示数据最小值和最大值的延伸范围，可以直接设置数值或者相对的百分比，在设置 min 和 max 后无效。
        /// </summary>
        public bool? BoundaryGap { get; set; }
        /// <summary>
        /// 坐标轴轴线相关设置。
        /// </summary>
        public AxisLine AxisLine { get; set; }

        /// <summary>
        /// x 轴所在的 grid 的索引，默认位于第一个 grid。
        /// </summary>
        public double? GridIndex { get; set; }
    }
}