// ======================================================================
// 
//         Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//         All rights reserved
// 
//         filename :TimelineOptions.cs
//         description :
// 
//         created by 李文强 at  2016/09/17 19:16
//         Blog：http://www.cnblogs.com/codelove/
//         Home：http://xin-lai.com
// 
// ======================================================================

using System.Collections.Generic;

namespace Magicodes.ECharts
{
    /// <summary>
    ///     timeline配置项
    ///     timeline 和其他组件有些不同，它需要操作『多个option』
    /// </summary>
    public class TimelineOptions
    {
        /// <summary>
        ///     baseOption 是一个 『原子option』，options 数组中的每一项也是一个 『原子option』。
        /// </summary>
        public EChartsOption BaseOption { get; set; }

        /// <summary>
        /// </summary>
        public List<EChartsOption> Options { get; set; }
    }
}