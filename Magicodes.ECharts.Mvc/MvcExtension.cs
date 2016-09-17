using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Magicodes.ECharts.Mvc.Results;

namespace Magicodes.ECharts.Mvc
{
    public static class MvcExtension
    {
        /// <summary>
        /// 返回符合Echart的结果
        /// </summary>
        /// <param name="controller">控制器对象</param>
        /// <param name="option">EChartsOption对象</param>
        /// <param name="behavior">是否允许HttpGet请求</param>
        /// <returns></returns>
        public static JavaScriptJsonResult ToEChartResult(this Controller controller, EChartsOption option,
                   JsonRequestBehavior behavior = JsonRequestBehavior.AllowGet)
        {
            return new JavaScriptJsonResult()
            {
                Data = option,
                ContentEncoding = null,
                ContentType = null,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}
