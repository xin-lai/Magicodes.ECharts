using Magicodes.ECharts;
using Magicodes.ECharts.Axis;
using Magicodes.ECharts.Components.Title;
using Magicodes.ECharts.Mvc.Results;
using Magicodes.ECharts.Series;
using Magicodes.ECharts.Series.Mark;
using Magicodes.ECharts.ValueTypes;
using Magicodes.ECharts.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Magicodes.ECharts.CommonDefinitions;

namespace Magicodes.ECharts.Demo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ChartDemo()
        {
            return View();
        }
        /// <summary>
        ///     获取粉丝分布统计数据
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public JavaScriptJsonResult UserAreaChart()
        {
            var provinces = new List<object>() { "岳阳", "长沙", "北京", "上海", "武汉", "贵州" };
            var valueList = new List<object>() { 50, 100, 130, 39, 31, 66 };
            var chartOptions = new EChartsOption
            {
                Title = new Title("粉丝分布统计图") { Left = new AlignValue(Align.center) },
                Series = new Series.Series[]
                {
                    new BarSeries
                    {
                        Name = "粉丝分布",
                        Data = valueList,
                        MarkPoint = new MarkPoint
                        {
                            Data = new List<MarkData>
                            {
                                new MarkData {Type = MarkPointDataTypes.max, Name = "最大值"},
                                new MarkData {Type = MarkPointDataTypes.min, Name = "最小值"}
                            }
                        },
                        MarkLine = new MarkLine
                        {
                            Data = new List<MarkData>
                            {
                                new MarkData {Type = MarkPointDataTypes.average, Name = "平均值"}
                            }
                        }
                    }
                },
                XAxis = new XAxis[1] { new XAxis { Type = AxisTypes.category, Data = provinces } },
                YAxis = new YAxis[1] { new YAxis { Type = AxisTypes.value } }
            };
            return this.ToEChartResult(chartOptions);
        }
    }
}