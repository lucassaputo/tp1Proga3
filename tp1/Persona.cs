using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp1
{
    public class Persona
    {
        public int id {  get; set; }
        public int dni {  get; set; }
        public string nombre { get; set; }
        public string apellido {  get; set; }
        public int genero {  get; set; }
        public Domicilio domicilio { get; set; }
        public Telefono telefono { get; set; }
        public DateTime fechaIngreso { get; set; }
        public DateTime fechaEgreso { get; set; }
    }
}
