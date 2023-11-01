using Calculadora.Service;

namespace Calculadorateste;


public class Calculadorateste
{
    //Instânciando a classe CalculadoraImpl
    private CalculadoraImpl calculadora;
    public Calculadorateste(){
        calculadora = new CalculadoraImpl();
    }


    [Fact] // para marcar um método como um teste. 
    public void DeveSomar5Com10Retornar15()
    {
          // Arrange (Preparação)
          

            // Act (Ação)
          

            // Assert (Afirmação)
           



    }
}