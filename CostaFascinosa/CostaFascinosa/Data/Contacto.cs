﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace CostaFascinosa.Data;

public partial class Contacto
{
    public int IdContacto { get; set; }

    public int? IdPasajero { get; set; }

    public int? IdTipoContacto { get; set; }

    public string Contacto1 { get; set; }

    public virtual Pasajero IdPasajeroNavigation { get; set; }

    public virtual TipoContacto IdTipoContactoNavigation { get; set; }
}