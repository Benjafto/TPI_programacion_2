﻿using CostaFascinosa.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CostaFascinosa.Repository.Interfaz
{
    public interface ITiposServicio_repository
    {
        List<TiposServicio> GetTiposServicios();

        TiposServicio GetTipoServicio(int id);

        bool add(TiposServicio tipoServicio);

        bool delete(int id);

        bool update(TiposServicio tipoServicio);
    }
}
