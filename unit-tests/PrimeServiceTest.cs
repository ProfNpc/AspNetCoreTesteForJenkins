using AspNetCoreTesteForJenkins.Services;
using Microsoft.AspNetCore.Mvc;

namespace unit_tests
{
    public class PrimeServiceTest
    {
        [Fact]
        //Padrão Given_When_Should
        public void DadoQueChamouGenerateArrayPrimes_QuandoPassoNIgualA2_DeveRetornar23()
        {
            IPrimeService service = new PrimeService();
            var array = service.GenerateArrayPrimes(2);
            Assert.Equal(2, array.Length);
            Assert.True(array[0] == 2);
            Assert.True(array[1] == 3);
        }

        [Fact]
        //Padrão Given_When_Should
        public void DadoQueChamouGenerateArrayPrimes_QuandoPassoNIgualA1_DeveLancarExcecao()
        {
            IPrimeService service = new PrimeService();
            Assert.Throws<ArgumentException>(() => service.GenerateArrayPrimes(1));
        }
    }
}