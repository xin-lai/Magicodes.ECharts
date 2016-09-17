// ======================================================================
// 
//         Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//         All rights reserved
// 
//         filename :SymbolValue.cs
//         description :
// 
//         created by 李文强 at  2016/09/17 19:16
//         Blog：http://www.cnblogs.com/codelove/
//         Home：http://xin-lai.com
// 
// ======================================================================

using Magicodes.ECharts.CommonDefinitions;
using Magicodes.ECharts.JsonConverter;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Magicodes.ECharts.ValueTypes
{
    /// <summary>
    ///     标记的图形
    /// </summary>
    [JsonConverter(typeof(ValueConverter<Symbols>))]
    public class SymbolValue : ISymbolValue, IValue<Symbols>
    {
        public SymbolValue(Symbols value)
        {
            Value = value;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public Symbols Value { get; set; }
    }
}