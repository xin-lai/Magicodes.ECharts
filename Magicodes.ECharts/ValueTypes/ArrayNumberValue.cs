using Magicodes.ECharts.JsonConverter;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magicodes.ECharts.ValueTypes
{
    /// <summary>
    /// 小数数组
    /// </summary>
    [JsonConverter(typeof(ValueConverter<double[]>))]
    public class ArrayNumberValue : IValue<double[]>, INumberOrArrayNumberValue
    {
       public double[] Value { get; set; }
    }
}
