// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : StringValue.cs
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
    ///     字符串值
    /// </summary>
    [JsonConverter(typeof(ValueConverter<string>))]
    public class StringValue : ILeftValue, ITopValue, IRightValue, IBottomValue, ISymbolValue, IValue<string>
    {
        public string Value { get; set; }
    }
}