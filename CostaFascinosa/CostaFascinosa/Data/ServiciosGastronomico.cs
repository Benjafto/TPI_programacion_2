﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CostaFascinosa.Data;

public partial class ServiciosGastronomico
{
    public int IdServicio { get; set; }

    public string Nombre { get; set; }

    public string Descripcion { get; set; }

    public int? IdTipoServicio { get; set; }

    public int? IdTematica { get; set; }

    public int? IdPreferencia { get; set; }

    public byte[] AptoCeliaquia { get; set; }

    public int? IdDestinatario { get; set; }

    public int? IdCodVestimenta { get; set; }

    public int? IdTurnoApertura { get; set; }

    public int? IdZona { get; set; }

    public int? CupoMax { get; set; }

    public byte[] RequiereReserva { get; set; }

    public virtual CodVestimenta IdCodVestimentaNavigation { get; set; }

    public virtual Destinatario IdDestinatarioNavigation { get; set; }

    public virtual PreferenciasAlimenticia IdPreferenciaNavigation { get; set; }

    public virtual Tematica IdTematicaNavigation { get; set; }

    public virtual TiposServicio IdTipoServicioNavigation { get; set; }

    public virtual Turno IdTurnoAperturaNavigation { get; set; }

    public virtual Zona IdZonaNavigation { get; set; }
    [JsonIgnore]
    public virtual ICollection<ProductosGastronomico> ProductosGastronomicos { get; set; } = new List<ProductosGastronomico>();
    [JsonIgnore]
    public virtual ICollection<ResenasServicio> ResenasServicios { get; set; } = new List<ResenasServicio>();
    [JsonIgnore]
    public virtual ICollection<ReservasServicio> ReservasServicios { get; set; } = new List<ReservasServicio>();
}