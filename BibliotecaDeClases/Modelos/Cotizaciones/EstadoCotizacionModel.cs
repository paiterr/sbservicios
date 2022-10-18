﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClases.Modelos.Cotizaciones
{
   public class EstadoCotizacionModel
    {
        public int ID { get; set; }
        public string Estado { get; set; }

        public string  Descripcion { get; set; }

        public string CreadoPor { get; set; }

        public string EditadoPor { get; set; }

        public DateTime CreadoEn { get; set; }

        public DateTime EditadoEn { get; set; }



    }

}
