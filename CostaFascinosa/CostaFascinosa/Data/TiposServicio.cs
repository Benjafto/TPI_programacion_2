﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CostaFascinosa.Data;

public partial class TiposServicio
{
    public int IdTipoServicio { get; set; }

    public string TipoServicio { get; set; }
    [JsonIgnore]
    public virtual ICollection<ServiciosGastronomico> ServiciosGastronomicos { get; set; } = new List<ServiciosGastronomico>();
}