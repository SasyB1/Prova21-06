using System;
using System.Text;

namespace Prova21_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Altrimenti non mi funziona il simbolo dell'euro €
            Console.OutputEncoding = Encoding.UTF8;

            // Richiesta all'utente di inserire i dati del contribuente
            Console.WriteLine("Inserisci i dati del contribuente");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();
            Console.Write("Genere Uomo/Donna (U/D): ");
            string inputGenere = Console.ReadLine().ToUpper();
            Sesso genere;

            // Confrontiamo l'input dell'utente per determinare il genere
            if (inputGenere == "U")
            {
                genere = Sesso.Uomo;
            }
            else if (inputGenere == "D")
            {
                genere = Sesso.Donna;
            }
            else
            {
                Console.WriteLine("Input non valido."); 
                return; 
            }

            // Richiesta all'utente di inserire ulteriori informazioni
            Console.Write("Data di nascita (gg/mm/aaaa): ");
            DateOnly dataNascita = DateOnly.Parse(Console.ReadLine());
            Console.Write("Comune di residenza: ");
            string comuneResidenza = Console.ReadLine();
            Console.WriteLine("Codice Fiscale: ");
            string codiceFiscale = Console.ReadLine().ToUpper();
            Console.Write("Reddito annuale: ");
            double redditoAnnuale = double.Parse(Console.ReadLine());

            // Creazione di un oggetto Contribuente con i dati inseriti dall'utente
            Contribuente contribuente = new Contribuente(nome, cognome, genere, dataNascita, comuneResidenza, redditoAnnuale, codiceFiscale);

            // Output dei risultati del calcolo dell'imposta
            Console.WriteLine("====================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE");
            Console.WriteLine($"Contribuente: {contribuente.nome.ToUpper()} {contribuente.cognome.ToUpper()}");
            Console.WriteLine($"nato il {contribuente.dataNascita} ({contribuente.genere})");
            Console.WriteLine($"Residente in {contribuente.comuneResidenza}");
            Console.WriteLine($"Codice Fiscale: {contribuente.codiceFiscale}");
            Console.WriteLine($"Reddito Dichiarato:  € {contribuente.redditoAnnuale:N2}");
            Console.WriteLine($"Imposta da versare: € {contribuente.CalcoloImposta():N2}");
        }
    }
}
