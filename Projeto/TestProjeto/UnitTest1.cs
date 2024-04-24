using Projeto;

namespace TestProjeto
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5,5,10)]
        [InlineData(9, 6, 15)]
        [InlineData(99, 1, 100)]

        public void TestSomar(int v1, int v2, int resultado)
        {
            Calculadora cal = new Calculadora();

            int resultadoCalculadora = cal.Somar(v1, v2);


            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(10, 5, 5)]
        [InlineData(9, 6, 3)]
        [InlineData(99, 1, 98)]
        public void TestSubtrair(int v1, int v2, int resultado)
        {

            Calculadora cal = new Calculadora();

            int resultadoCalculadora = cal.Subtrair(v1, v2);


            Assert.Equal(resultado, resultadoCalculadora);


        }


        [Theory]
        [InlineData(10, 5, 50)]
        [InlineData(9, 6, 54)]
        [InlineData(99, 1, 99)]
        public void TestMultiplicar(int v1, int v2, int resultado)
        {

            Calculadora cal = new Calculadora();

            int resultadoCalculadora = cal.Multiplicar(v1, v2);


            Assert.Equal(resultado, resultadoCalculadora);


        }


        [Theory]
        [InlineData(10, 5, 2)]
        [InlineData(24, 6, 4)]
        [InlineData(99, 3, 33)]
        public void TestDividir(int v1, int v2, int resultado)
        {

            Calculadora cal = new Calculadora();

            int resultadoCalculadora = cal.Dividir(v1, v2);


            Assert.Equal(resultado, resultadoCalculadora);


        }


        [Fact]
        public void TestPorDividir() 
        {
            Calculadora calc = new Calculadora();

            Assert.Throws<DivideByZeroException>(

                () => calc.Dividir(2, 0)
            );
        
        }


        [Fact]
        public void TestHistorico()
        {
            Calculadora calc = new Calculadora();

            calc.Somar(1, 2);
            calc.Subtrair(10, 2);
            calc.Multiplicar(5, 3);
            calc.Dividir(10, 2);

            var lista= calc.Historico();

            Assert.NotEmpty(lista);
            Assert.Equal(3, lista.Count);
        }

    }
}