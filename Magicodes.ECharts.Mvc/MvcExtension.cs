// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : MvcExtension.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:13
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.Mvc.Results;
using System.Web.Mvc;

namespace Magicodes.ECharts.Mvc
{
    public static class MvcExtension
    {
        /// <summary>
        ///     返回符合Echart的结果
        /// </summary>
        /// <param name="controller">控制器对象</param>
        /// <param name="option">EChartsOption对象</param>
        /// <param name="behavior">是否允许HttpGet请求</param>
        /// <returns></returns>
        public static JavaScriptJsonResult ToEChartResult(this Controller controller, EChartsOption option,
            JsonRequestBehavior behavior = JsonRequestBehavior.AllowGet)
        {
            return new JavaScriptJsonResult
            {
                Data = option,
                ContentEncoding = null,
                ContentType = null,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}