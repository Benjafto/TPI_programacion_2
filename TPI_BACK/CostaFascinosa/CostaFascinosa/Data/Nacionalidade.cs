﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CostaFascinosa.Data;

public partial class Nacionalidade
{
    public int IdNacionalidad { get; set; }

    public string Descripcion { get; set; }

    public virtual ICollection<Coordinadore> Coordinadores { get; set; } = new List<Coordinadore>();

    public virtual ICollection<Pasajero> Pasajeros { get; set; } = new List<Pasajero>();
}