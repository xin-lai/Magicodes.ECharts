// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : TooltipTriggerTypes.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

namespace Magicodes.ECharts.Components.ToolTip
{
    /// <summary>
    ///     提示框组件触发类型
    /// </summary>
    public enum TooltipTriggerTypes
    {
        /// <summary>
        ///     数据项图形触发，主要在散点图，饼图等无类目轴的图表中使用。
        /// </summary>
        item,

        /// <summary>
        ///     坐标轴触发，主要在柱状图，折线图等会使用类目轴的图表中使用。
        /// </summary>
        axis
    }
}