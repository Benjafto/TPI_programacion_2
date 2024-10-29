﻿using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Servicio.Interfaz
{
    public interface IEstado_service
    {
        List<Estado> GetEstados();

        Estado GetEstado(int id);

        bool add(Estado estado);

        bool delete(int id);

        bool update(Estado estado);
    }
}
