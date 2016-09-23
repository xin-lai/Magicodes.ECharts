// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : SeriesTypes.cs
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
    ///     图表类型
    /// </summary>
    public enum SeriesTypes
    {
        /// <summary>
        ///     折线/面积图
        /// </summary>
        line,

        /// <summary>
        ///     柱状/条形图
        /// </summary>
        bar,

        /// <summary>
        ///     饼图
        /// </summary>
        pie,

        /// <summary>
        ///     散点（气泡）图
        /// </summary>
        scatter,

        /// <summary>
        ///     带有涟漪特效动画的散点（气泡）图。利用动画特效可以将某些想要突出的数据进行视觉突出。
        /// </summary>
        effectScatter,

        /// <summary>
        ///     雷达图
        /// </summary>
        radar,

        /// <summary>
        ///     Treemap 是一种常见的表达『层级数据』『树状数据』的可视化形式。它主要用面积的方式，便于突出展现出『树』的各层级中重要的节点。
        /// </summary>
        treemap,

        /// <summary>
        ///     『箱形图』、『盒须图』、『盒式图』、『盒状图』、『箱线图』
        /// </summary>
        boxplot,

        /// <summary>
        ///     K线图
        /// </summary>
        candlestick,

        /// <summary>
        ///     热力图
        /// </summary>
        heatmap,

        /// <summary>
        ///     地图。
        /// </summary>
        map,

        /// <summary>
        ///     平行坐标系（Parallel Coordinates）
        /// </summary>
        parallel,

        /// <summary>
        ///     线图
        /// </summary>
        lines,

        /// <summary>
        ///     关系图
        /// </summary>
        graph,

        /// <summary>
        ///     桑基图
        /// </summary>
        sankey,

        /// <summary>
        ///     漏斗图
        /// </summary>
        funnel,

        /// <summary>
        ///     仪表盘
        /// </summary>
        gauge
    }
}