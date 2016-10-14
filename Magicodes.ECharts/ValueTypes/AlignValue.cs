// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : AlignValue.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:13
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using Magicodes.ECharts.CommonDefinitions;
using Magicodes.ECharts.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.ECharts.ValueTypes
{
    /// <summary>
    ///     水平对齐值
    /// </summary>
    [JsonConverter(typeof(ValueConverter<Align>))]
    public class AlignValue : ILeftValue, IValue<Align>
    {
        public AlignValue(Align value)
        {
            Value = value;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public Align Value { get; set; }
    }
}