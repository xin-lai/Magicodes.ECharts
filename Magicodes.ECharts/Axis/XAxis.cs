// ======================================================================
// 
//         Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//         All rights reserved
// 
//         filename :XAxis.cs
//         description :
// 
//         created by 李文强 at  2016/09/17 19:15
//         Blog：http://www.cnblogs.com/codelove/
//         Home：http://xin-lai.com
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
    }
}