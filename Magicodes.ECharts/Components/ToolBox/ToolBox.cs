// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : ToolBox.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.CommonDefinitions;

namespace Magicodes.ECharts.Components.ToolBox
{
    /// <summary>
    ///     工具箱，每个图表最多仅有一个工具箱
    /// </summary>
    public class ToolBox
    {
        /// <summary>
        ///     辅助工具箱
        /// </summary>
        public ToolBox()
        {
            Show = true;
            Orient = Orients.horizontal;
            X = Align.right;
            Y = VerticalAlign.top;
            BorderWidth = 0;
            Padding = 5;
            ShowTitle = true;
            Feature = new ToolBoxFeature();
        }

        /// <summary>
        ///     显示策略，可选为：true（显示） | false（隐藏）
        /// </summary>
        public bool Show { get; set; }

        /// <summary>
        ///     摆放方式，可选值有：
        ///     'vertical'：竖直放置。
        ///     'horizontal'：水平放置。
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Orients Orient { get; set; }

        /// <summary>
        ///     水平安放位置，默认为全图居中，可选为：'center' | 'left' | 'right'
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public Align X { get; set; }

        /// <summary>
        ///     垂直安放位置，默认为全图顶端，可选为：'top' | 'bottom' | 'center'
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public VerticalAlign Y { get; set; }

        /// <summary>
        ///     工具箱边框线宽，单位px，默认为0（无边框）
        /// </summary>
        public int BorderWidth { get; set; }

        /// <summary>
        ///     工具箱内边距，单位px，默认各方向内边距为5，
        /// </summary>
        public int Padding { get; set; }

        /// <summary>
        ///     是否显示工具箱文字提示，默认启用
        /// </summary>
        public bool ShowTitle { get; set; }

        /// <summary>
        ///     启用功能集合
        /// </summary>
        public ToolBoxFeature Feature { get; set; }
    }
}