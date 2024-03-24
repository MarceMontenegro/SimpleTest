using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interfaz;
namespace Demo
{
    public class Alumno: Persona, Icarteriztica
    {

        public string _dedicacion { get; set; }

        public string CaracteristicaCompleta
        {
            get
            {
                return $"{base._nombre} {base._edad} {_dedicacion}".Trim();
            }

        }
    }
}
