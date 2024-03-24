using Demo;
namespace DemoTest
{
    public class MaestraTest
    {
        [Fact]
        public void DeberiaVerificarElNombre()
        {
            
            Maestra maestra = new Maestra()
            {
                _nombre = "gilda",
                _edad = 2,
                _especialidad = "matematica"
            };
            

            var result = maestra.CaracteristicaCompleta;
            Assert.Equal("gilda 2 matematica", Printer.Print(maestra));
        }
    }
}