// ======================================================================
//  
//          Copyright (C) 2016-2020 湖南心莱信息科技有限公司    
//          All rights reserved
//  
//          filename : ValueConverter.cs
//          description :
//  
//          created by 李文强 at  2016/09/23 9:12
//          Blog：http://www.cnblogs.com/codelove/
//          GitHub ： https://github.com/xin-lai
//          Home：http://xin-lai.com
//  
// ======================================================================

using System;
using Magicodes.ECharts.ValueTypes;
using Newtonsoft.Json;
using System.Text;

namespace Magicodes.ECharts.JsonConverter
{
    public class ValueConverter<T> : Newtonsoft.Json.JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var iv = value as IValue<T>;
            if (iv == null) return;
            //如果是字符串数组
            if (iv.Value is double[])
            {
                var values = iv.Value as double[];
                var sb = new StringBuilder("[");
                foreach (var item in values)
                {
                    sb.Append(item).Append(",");
                }
                writer.WriteValue(sb.ToString().TrimEnd(',') + "]");
                return;
            }
            writer.WriteValue(iv.Value.ToString());
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue,
            JsonSerializer serializer)
        {
            var obj = Activator.CreateInstance(objectType) as IValue<T>;
            obj.Value = (T)reader.Value;
            return obj;
        }

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IValue<T>);
        }
    }
}