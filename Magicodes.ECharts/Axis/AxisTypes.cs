// ======================================================================
// 
//         Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//         All rights reserved
// 
//         filename :AxisTypes.cs
//         description :
// 
//         created by 李文强 at  2016/09/17 19:15
//         Blog：http://www.cnblogs.com/codelove/
//         Home：http://xin-lai.com
// 
// ======================================================================

namespace Magicodes.ECharts.Axis
{
    /// <summary>
    ///     坐标轴类型
    /// </summary>
    public enum AxisTypes
    {
        /// <summary>
        ///     数值轴，适用于连续数据。
        /// </summary>
        value,

        /// <summary>
        ///     类目轴，适用于离散的类目数据，为该类型时必须通过 data 设置类目数据。
        /// </summary>
        category,

        /// <summary>
        ///     时间轴，适用于连续的时序数据，与数值轴相比时间轴带有时间的格式化，在刻度计算上也有所不同，例如会根据跨度的范围来决定使用月，星期，日还是小时范围的刻度。
        /// </summary>
        time,

        /// <summary>
        ///     对数轴。适用于对数数据。
        /// </summary>
        log
    }
}