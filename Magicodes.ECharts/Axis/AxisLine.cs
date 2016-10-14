using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.ECharts.Axis
{
    public class AxisLine
    {
        /// <summary>
        /// 是否显示坐标轴轴线。
        /// </summary>
        public bool? Show { get; set; }
        /// <summary>
        /// X 轴或者 Y 轴的轴线是否在另一个轴的 0 刻度上，只有在另一个轴为数值轴且包含 0 刻度时有效。
        /// </summary>
        public bool? OnZero { get; set; }
        /// <summary>
        /// 坐标轴线
        /// </summary>
        public LineStyle LineStyle { get; set; }
    }
}
