using System;
using System.Collections.Generic;

#nullable disable

namespace Imperium.Models
{
    public partial class RegistroUser
    {
        public RegistroUser()
        {
            Comentarios = new HashSet<Comentario>();
        }

        public int Iduser { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Contra { get; set; }
        public string Rol { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Localidad { get; set; }
        public string Fotografia { get; set; }

        public virtual ICollection<Comentario> Comentarios { get; set; }
    }
}
