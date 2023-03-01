namespace AspNetCoreTesteForJenkins.Services
{
    public class PrimeService : IPrimeService
    {
        public int[] GenerateArrayPrimes(int n)
        {
            if (n < 2)
            {
                throw new ArgumentException("n tem que ser maior que 2");
            }
            int[] array = new int[n];
            array[0] = 2;
            array[1] = 3;

            return array;
        }
    }
}
