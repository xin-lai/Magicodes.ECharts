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
    }
}