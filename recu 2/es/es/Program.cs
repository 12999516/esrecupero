using static System.Console;

namespace es
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int cont = 0;
            do
            {
                WriteLine("quanti numeri vuoi aggiungere");
            } while (!Int32.TryParse(ReadLine(), out n) || n > 50);

            int[] numeri = new int[n];

            for (int i = 0; i < n; i++)
            {
                do
                {
                    WriteLine("inserisci il numero");
                } while (!Int32.TryParse(ReadLine(), out numeri[i]));
            }

            for (int i = 0; i < n - 1; i++)
            {
                if ((numeri[i] > 0 && numeri[i + 1] < 0) || (numeri[i] < 0 && numeri[i + 1] > 0))
                {
                   cont++;
                }
            }

            WriteLine($"i cambi segno sono {cont}");

        }
    }
}
