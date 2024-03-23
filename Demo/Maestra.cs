using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interfaz;
namespace Demo
{
    public class Maestra : Persona, Icarteriztica
    {

        public string _especialidad { get; set; }
        

        public string FullName()
        {
            return $"{base._nombre} {base._edad}";
        }

        public string CaracteristicaCompleta
        {
            get{
                return $"{base._nombre} {base._edad} {_especialidad}";
            }
            
        }

    }
}
