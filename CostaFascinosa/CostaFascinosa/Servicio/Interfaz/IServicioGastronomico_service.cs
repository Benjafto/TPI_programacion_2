﻿using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface IServicioGastronomico_service
    {
        List<ServiciosGastronomico> GetServiciosGastronomicos();

        ServiciosGastronomico GetServicioGastronomico(int id);

        bool add(ServiciosGastronomico servicioGastronomico);

        bool delete(int id);

        bool update(ServiciosGastronomico servicioGastronomico);
    }
}
