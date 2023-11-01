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
    

    // Utilizando o Theory

    [Theory]
   
   [InlineData(2)]
   [InlineData(4)]
   [InlineData(8)]
   [InlineData(16)]
   [InlineData(32)]

    public void DeveVerificarSeOsNumerosSaoParesRetornarTrue(int numero1){

      // Arrange (Preparação)

          //Tou Usando o Theory Pra receber os valores

      // Act (Ação)

      bool resultadoReal = calculadora.EhPar(numero1);

      // Assert (Afirmação)

      Assert.True(resultadoReal);

    }

    /*
     é marcado com [Theory], e vários conjuntos de dados de entrada são fornecidos usando [InlineData]. O método é então executado uma vez para cada conjunto de dados fornecido. Isso permite que você teste o método DeveVerificarSeOsNumerosSaoParesRetornarTrue com diferentes valores de entrada e verifique se ele produz os resultados esperados para cada caso.

    */

    



}