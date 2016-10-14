// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : NumberValue.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:13
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.JsonConverter;
using Newtonsoft.Json;

namespace Magicodes.ECharts.ValueTypes
{
    /// <summary>
    ///     数值
    /// </summary>
    [JsonConverter(typeof(ValueConverter<double>))]
    public class NumberValue : ILeftValue, ITopValue, IRightValue, IBottomValue, IValue<double>, INumberOrArrayNumberValue, INumberOrStringValue
    {
        public NumberValue(double? value = null)
        {
            if (value.HasValue)
            {
                Value = value.Value;
            }
        }
        public double Value { get; set; }
    }
}