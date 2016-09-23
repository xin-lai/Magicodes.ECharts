// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : MarkPoint.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:13
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System.Collections.Generic;
using Magicodes.ECharts.CommonDefinitions;

namespace Magicodes.ECharts.Series.Mark
{
    /// <summary>
    ///     图表标注
    /// </summary>
    public class MarkPoint
    {
        /// <summary>
        ///     标记的图形。ECharts 提供的标记类型包括 'circle', 'rect', 'roundRect', 'triangle', 'diamond', 'pin', 'arrow',也可以通过 'image://url'
        ///     设置为图片，其中 url 为图片的链接。
        ///     在 ECharts 3 里可以通过 'path://' 将图标设置为任意的矢量路径。这种方式相比于使用图片的方式，不用担心因为缩放而产生锯齿或模糊，而且可以设置为任意颜色。路径图形会自适应调整为合适（如果是 symbol 的话就是
        ///     symbolSize）的大小。路径的格式参见 SVG PathData。可以从 Adobe Illustrator 等工具编辑导出。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Symbols Symbol { get; set; }

        /// <summary>
        ///     标注的数据数组
        /// </summary>
        public List<MarkData> Data { get; set; }
    }
}