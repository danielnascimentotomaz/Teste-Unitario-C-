using Calculadora.Service;
using Xunit;

namespace CalculadoraTeste
{
    public class ValidacaoStringTeste
    {


        private ValidadacaoString validadacao;

       public ValidacaoStringTeste(){

            validadacao = new ValidadacaoString();
        }

        [Fact]
        public void DeverContarSeNomeretornar5()
        {
          // Arrange (Preparação)

          string Palavra = "Apple";

          int ResultadoEsperado = 5;

          
          
          
          
          // Act (Ação)

          int ResultadoReal = validadacao.ContarCaracteres(Palavra);




          // Assert (Afirmação)

          Assert.Equal(ResultadoEsperado, ResultadoReal);
           
        }


       
    
     
        
    }
}