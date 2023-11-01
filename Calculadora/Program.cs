
using Calculadora.Service;

CalculadoraImpl calculadora = new CalculadoraImpl();

int x = 10;

int y = 5;

Console.WriteLine($"{x} + {y} = {calculadora.Somar(x,y)}");

Console.WriteLine("============================================");

ValidadacaoString validacao = new ValidadacaoString();

string nome = "José";

Console.WriteLine($"Total de letra do nome de {nome} é {validacao.ContarCaracteres(nome)}");

