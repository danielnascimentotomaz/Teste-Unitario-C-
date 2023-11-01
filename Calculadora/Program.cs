
using Calculadora.Service;

CalculadoraImpl calculadora = new CalculadoraImpl();

int x = 10;

int y = 5;

Console.WriteLine($"{x} + {y} = {calculadora.Somar(x,y)}");

