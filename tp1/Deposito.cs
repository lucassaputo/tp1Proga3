using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Deposito
    {
        public int id {  get; set; }
        public int superficie { get; set; }
        public Domicilio domicilio { get; set; }
        public Telefono telefono { get; set; }
    }
}
