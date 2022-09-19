﻿using System.Text.Json.Serialization;

namespace dotnetcore6_rpg.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Knight=1,
        Mage=2,
        Cleric=3
    }
}
