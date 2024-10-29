﻿using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface ICordinadore_service
    {
        List<Coordinadore> GetCoordinadores();

        Coordinadore GetCoordinador(int id);

        bool add(Coordinadore cordinador);

        bool delete(int id);

        bool update(Coordinadore cordinador);
    }
}
