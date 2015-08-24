using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadDS
{
    public class Miembro
    {
        public int miembroID { get; set; }
        public DateTime ultimaVisita { get; set; }
        public DateTime fCreacion { get; set; }

        public Perfil perfil { get; set; }

        public Miembro()
        {
                
        }
    }
}
