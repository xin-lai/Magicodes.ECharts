// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : Label.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

namespace Magicodes.ECharts.CommonDefinitions
{
    /// <summary>
    ///     标签
    /// </summary>
    public class Label
    {
        public Label()
        {
            Show = true;
        }

        /// <summary>
        ///     是否显示刻度标签。
        /// </summary>
        public bool Show { get; set; }

        ////    // 使用字符串模板，模板变量为刻度默认标签 {value}
        ////    formatter: '{value} kg'

        ////    // 使用函数模板，函数参数分别为刻度数值（类目），刻度的索引
        ////    formatter: function (value, index) {
        ////        // 格式化成月/日，只在第一个刻度显示年份
        ////        var date = new Date(value);
        ////        var texts = [(date.getMonth() + 1), date.getDate()];
        ////        if (index === 0) {
        ////            texts.unshift(date.getYear());
        ////        }
        ////        return texts.join('/');
        ////    }
        /// <summary>
        ///     刻度标签的内容格式器，支持字符串模板和回调函数两种形式。
        ///     示例：
        /// </summary>
        public string Formatter { get; set; }
    }
}