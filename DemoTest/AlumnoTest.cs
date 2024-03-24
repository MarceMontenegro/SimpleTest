using Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    public class AlumnoTest
    {
        [Fact]
        public void DeberiaComprobarElNombre()
        {
            var alumno = new Alumno()
            {
                _nombre = "pablo",
                _edad = 2,
            };

            Assert.Equal("pablo 2", Printer.Print(alumno));

        }
    }
}
