using System.Diagnostics;

namespace Contest
{
    public class Program
    {
        // Definisce il limite massimo
        int upperBound = 10000;

        // Metodo statico che determina se un numero è primo
        static bool IsPrime(int n)
        {

            if (n <= 1) return false;
            if (n <= 3) return true;
            if (n % 2 == 0 || n % 3 == 0) return false;
            int i = 5;
            while (i * i <= n)
            {
                if (n % i == 0 || n % (i + 2) == 0) return false;
                i += 6;
            }
            return true;
        }
        // Metodo statico che stampa tutti i numeri primi fino al limite upperBound
        static void Primes(int upperBound)
        {
            for(int i = 0; i < upperBound; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(" " + i);
                }
            }
        }
        static void Main(string[] args)
        {
            // un cronometro
            Stopwatch sw = new Stopwatch();
            // attiva il cronometro
            sw.Start();
            // esegue il metodo da misurare
            Primes(10000);
            // ferma il cronometro
            sw.Stop();
            // stampa il tempo trascorso
            Console.WriteLine($" Execution time: {sw.ElapsedMilliseconds} ms");
        }
    }
}
