// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : LineSeries.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:13
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.ValueTypes;

namespace Magicodes.ECharts.Series
{
    /// <summary>
    ///     折线/面积图
    /// </summary>
    public class LineSeries : Series
    {
        public LineSeries()
        {
            Type = SeriesTypes.line;
        }

        /// <summary>
        ///     是否平滑曲线显示。
        /// </summary>
        public bool Smooth { get; set; }

        /// <summary>
        /// 标记的大小，可以设置成诸如 10 这样单一的数字，也可以用数组分开表示宽和高，例如 [20, 10] 表示标记宽为20，高为10。
        /// </summary>
        public INumberOrArrayNumberValue SymbolSize { get; set; }

        /// <summary>
        /// 是否开启 hover 在拐点标志上的提示动画效果。
        /// </summary>
        public bool? HoverAnimation { get; set; }

        


    }
}