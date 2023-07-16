using System;
using System.Collections.Generic;

#nullable disable

namespace Imperium.Models
{
    public partial class Casa
    {
        public Casa()
        {
            Comentarios = new HashSet<Comentario>();
        }

        public int Idcasa { get; set; }
        public string Nombre { get; set; }
        public string Precio { get; set; }
        public string DescripcionPropiedad { get; set; }
        public string RentaOventa { get; set; }
        public string TipoVivienda { get; set; }
        public string Superficie { get; set; }
        public string Caracteristicas { get; set; }
        public string Coordenadas { get; set; }
        public string Imagen { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }
    }
}
