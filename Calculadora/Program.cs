using Calculadora.Services;

var c = new CalculadoraImp();

int num1 = 5;
int num2 = 10;

Console.WriteLine($"{num1} + {num2} = {c.Soma(num1, num2)}");
