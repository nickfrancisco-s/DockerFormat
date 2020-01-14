﻿// <auto-generated />
//
// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using DockerFormat;
//
//    var language = Language.FromJson(jsonString);

namespace DockerFormat
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Language
    {
        [JsonProperty("Types")]
        public List<TypeElement> Types { get; set; }
    }

    public partial class TypeElement
    {
        [JsonProperty("Type")]
        public string Type { get; set; }

        [JsonProperty("Color")]
        public string Color { get; set; }

        [JsonProperty("defs")]
        public List<Def> Defs { get; set; }
    }

    public partial class Def
    {
        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("Help")]
        public string Help { get; set; }
    }

    public partial class Language
    {
        public static Language FromJson(string json) 
        { 
            return  JsonConvert.DeserializeObject<Language>(json, DockerFormat.Converter.Settings);
        }
    }

    public static class Serialize
    {
        public static string ToJson(this Language self) 
        {
            return JsonConvert.SerializeObject(self, DockerFormat.Converter.Settings);
        }
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
