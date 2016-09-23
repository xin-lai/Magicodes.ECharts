// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : LegendData.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.CommonDefinitions;

namespace Magicodes.ECharts.Components.Legend
{
    /// <summary>
    ///     图例的数据
    /// </summary>
    public class LegendData
    {
        public LegendData(string name)
        {
            Name = name;
        }

        /// <summary>
        ///     名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     图形，比如circle
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        ///     文本样式
        /// </summary>
        public TextStyles TextStyle { get; set; }
    }
}