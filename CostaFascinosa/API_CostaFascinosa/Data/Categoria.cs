﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace API_CostaFascinosa.Data;

public partial class Categoria
{
    public int IdCategoria { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<Actividade> Actividades { get; set; } = new List<Actividade>();

    public virtual ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();
}