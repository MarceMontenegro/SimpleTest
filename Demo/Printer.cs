using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demo.Interfaz;
namespace Demo
{
    public  class Printer
    {
       public string Print(Icarteriztica any)
        {
            return any.CaracteristicaCompleta;
        }
    }
}
