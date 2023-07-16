using System;
using System.Collections.Generic;

#nullable disable

namespace Imperium.Models
{
    public partial class Comentario
    {
        public int Id { get; set; }
        public int? RegistroUserIduser { get; set; }
        public int? CasaIdcasa { get; set; }
        public string Comentario1 { get; set; }

        public virtual Casa CasaIdcasaNavigation { get; set; }
        public virtual RegistroUser RegistroUserIduserNavigation { get; set; }
    }
}
