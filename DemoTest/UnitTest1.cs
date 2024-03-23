using Demo;
namespace DemoTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Printer print = new Printer();
            Maestra maestra = new Maestra()
            {
                _nombre = "gilda",
                _edad = 2,
                _especialidad = "matematica"
            };
            

            var result = maestra.CaracteristicaCompleta;
            Assert.Equal("gilda 2 matematica",result);
        }
    }
}