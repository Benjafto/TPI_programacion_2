﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CostaFascinosa.Data;

public partial class Turno
{
    public int IdTurno { get; set; }

    public string Turno1 { get; set; }

    public string FranjaHoraria { get; set; }

    public virtual ICollection<Actividade> Actividades { get; set; } = new List<Actividade>();

    public virtual ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();

    public virtual ICollection<ServiciosGastronomico> ServiciosGastronomicos { get; set; } = new List<ServiciosGastronomico>();
}