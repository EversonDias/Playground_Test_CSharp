using Calculadora.Services;

namespace CalculadoraTests;

public class CalculadoraTests
{

    private CalculadoraImp _calc;

    public CalculadoraTests()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void Soma()
    {
        // Arranger
        int a = 5;
        int b = 10;
        // Act
        int result = _calc.Soma(a, b);
        // Assert

        Assert.Equal(15, result);
    }

    [Fact]
    public void IsPar()
    {
        // Given or Arrange
        int num = 20;    
        // When or Act
        bool result = _calc.IsPar(num);
    
        // Then or Assert
        Assert.True(result);
    }

    [Theory]
    [InlineData(new int[] {2, 80, 108})]
    [InlineData(new int[] {6, 10, 30})]
    public void ListIsPar(int[] listNum)
    {
        Assert.All(listNum, num => Assert.True(_calc.IsPar(num)));
    }
}