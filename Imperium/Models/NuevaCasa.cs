using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Imperium.Models
{
    public class NuevaCasa
    {
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string DescripcionPropiedad { get; set; }
        public string RentaOventa { get; set; }
        public string TipoVivienda { get; set; }
        public string Superficie { get; set; }
        public string Caracteristicas { get; set; }
        public string Coordenadas { get; set; }
        public IFormFile Imagen { get; set; }

    }
}
