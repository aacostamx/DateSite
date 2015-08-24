using System.Collections.Generic;

namespace EntidadDS
{
    public class Perfil
    {
        public int perfilID { get; set; }
        public string enBuscaDe { get; set; }
        public string descripcionCorta { get; set; }

        public Miembro miembro { get; set; }
        public Localizacion localizacion { get; set; }
        public ICollection <Intereses> intereses { get; set; }
    }
}