using MeuProjeto;
using System;
using Xunit;

namespace TesteMeuProjeto
{
    public class UnitTest1
    {
        public Calculadora ContruirClasse()
        {
            string data = "02/02/2020";
            Calculadora calc = new Calculadora("02/02/2020");
            return calc;
        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(4, 5, 9)]
        public void TestSomar(int a, int b, int resultado)
        {
            //Arrange
            Calculadora calc = ContruirClasse();
            //Act
            int resultadoCalculadora = calc.somar(a, b);
            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(7, 4, 3)]
        [InlineData(5, 6, -1)]
        public void TestSubtrair(int a, int b, int resultado)
        {
            //Arrange
            Calculadora calc = ContruirClasse();
            //Act
            int resultadoCalculadora = calc.subtrair(a, b);
            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(3, 4, 12)]
        [InlineData(2, 13, 26)]
        public void TestMultiplicar(int a, int b, int resultado)
        {
            //Arrange
            Calculadora calc = ContruirClasse();
            //Act
            int resultadoCalculadora = calc.multiplicar(a, b);
            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Theory]
        [InlineData(9, 3, 3)]
        [InlineData(48, 6, 8)]
        public void TestDividir(int a, int b, int resultado)
        {
            //Arrange
            Calculadora calc = ContruirClasse();
            //Act
            int resultadoCalculadora = calc.dividir(a, b);
            //Assert
            Assert.Equal(resultado, resultadoCalculadora);
        }

        [Fact]
        public void TestarDivisaoPorZero()
        {
            Calculadora calc = ContruirClasse();
            Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0));
        }

        [Fact]
        public void TestarHistorico()
        {
            Calculadora calc = ContruirClasse();

            calc.somar(1, 2);
            calc.somar(3, 4);
            calc.somar(5, 6);

            var lista = calc.historico();

            Assert.NotEmpty(calc.historico());
            Assert.Equal(3, lista.Count);
        }
    }
}