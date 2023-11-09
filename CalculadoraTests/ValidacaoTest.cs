using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTests
{
    public class ValidacaoTest
    {
        private ValidacoesString _validacoes;

        public ValidacaoTest()
        {
            _validacoes = new ValidacoesString();
        }

        [Theory]
        [InlineData("Ola", 3)]
        [InlineData("Muito", 5)]
        [InlineData("a", 1)]
        public void TestString(string text, int length)
        {

            // Act
            int result = _validacoes.ContarCaracteres(text);

            // Assert
            Assert.Equal(length, result);
        }       
    }
}