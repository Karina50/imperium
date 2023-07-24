using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Imperium.Models
{
    public partial class Contacto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Causa { get; set; }
        public string Comentario { get; set; }
        public string Correo { get; set; }
    }
}
