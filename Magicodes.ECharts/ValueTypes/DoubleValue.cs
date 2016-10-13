// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : DoubleValue.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:13
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.JsonConverter;

namespace Magicodes.ECharts.ValueTypes
{
    /// <summary>
    ///     小数值
    /// </summary>
    [JsonConverter(typeof(ValueConverter<double>))]
    public class DoubleValue : ILeftValue, ITopValue, IRightValue, IBottomValue, IValue<double>
    {
        public double Value { get; set; }
    }
}