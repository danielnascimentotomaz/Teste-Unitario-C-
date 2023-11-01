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

          int numero1 = 5;
          int numero2 = 10;
          int resultadoEsperado = 15;
          
          

            // Act (Ação)

            int resultadoReal = calculadora.Somar(numero1, numero2);
          

            // Assert (Afirmação)

            Assert.Equal(resultadoEsperado, resultadoReal);
            //

             

    }

    [Fact]
    public void VariosCasoDeTeste(){

         // Arrange (Preparação)

          int numero1 = 5;
          int numero2 = 10;

         // Act (Ação)

           int resultadoReal = calculadora.Somar(numero1, numero2);
          

        // Assert (Afirmação)

           Assert.True(resultadoReal > 0);
           Assert.False(resultadoReal < 0);

          
           // Verifique se um valor está dentro de um intervalo ou fora dele.
           Assert.InRange(resultadoReal, 1, 100);
    }

    [Fact]
    public void DeverVerificarSe4EhParRetornartrue(){

      // Arrange (Preparação)
      int numero = 4;



       // Act (Ação)

       bool resultadoReal = calculadora.EhPar(numero);



       // Assert (Afirmação)

       Assert.True(resultadoReal);






    }
}