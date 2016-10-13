// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : Title.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.CommonDefinitions;
using Magicodes.ECharts.ValueTypes;

namespace Magicodes.ECharts.Components.Title
{
    /// <summary>
    ///     标题
    /// </summary>
    public class Title
    {
        public Title(string text)
        {
            Show = true;
            Text = text;
        }

        /// <summary>
        ///     是否显示标题组件。
        /// </summary>
        public bool Show { get; set; }

        /// <summary>
        ///     主标题文本，支持使用 \n 换行。
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     主标题文本超链接。
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        ///     副标题文本，支持使用 \n 换行
        /// </summary>
        public string Subtext { get; set; }

        /// <summary>
        ///     副标题文本超链接。
        /// </summary>
        public string Sublink { get; set; }

        /// <summary>
        ///     grid 组件离容器左侧的距离。
        ///     left 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'left', 'center', 'right'。
        ///     如果 left 的值为'left', 'center', 'right'，组件会根据相应的位置自动对齐。
        /// </summary>
        public ILeftValue Left { get; set; }

        /// <summary>
        ///     grid 组件离容器上侧的距离。
        ///     top 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比，也可以是 'top', 'middle', 'bottom'。
        ///     如果 top 的值为'top', 'middle', 'bottom'，组件会根据相应的位置自动对齐。
        /// </summary>
        public ITopValue Top { get; set; }

        /// <summary>
        ///     grid 组件离容器右侧的距离。
        ///     right 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        ///     默认自适应。
        /// </summary>
        public IRightValue Right { get; set; }

        /// <summary>
        ///     grid 组件离容器下侧的距离。
        ///     bottom 的值可以是像 20 这样的具体像素值，可以是像 '20%' 这样相对于容器高宽的百分比。
        ///     默认自适应。
        /// </summary>
        public IBottomValue Bottom { get; set; }

        /// <summary>
        ///     标题背景色，默认透明。
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        ///     标题的边框颜色。支持的颜色格式同 backgroundColor。
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        ///     标题的边框线宽。
        /// </summary>
        public int BorderWidth { get; set; }

        /// <summary>
        ///     标题文本水平对齐
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public TextAlign? TextAlign { get; set; }
    }
}