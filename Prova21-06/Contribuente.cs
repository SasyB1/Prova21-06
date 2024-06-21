using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova21_06
{
    // Enumerazione per rappresentare il genere
    public enum Sesso
    {
        Uomo,
        Donna
    }

    // Classe che rappresenta un Contribuente
    public class Contribuente
    {
        // Proprietà della classe Contribuente
        public string nome { get; set; }         
        public string cognome { get; set; }         
        public Sesso genere { get; set; }           
        public DateOnly dataNascita { get; set; }    
        public string codiceFiscale { get; set; }   
        public string comuneResidenza { get; set; }   
        public double redditoAnnuale { get; set; }     

        // Costruttore per inizializzare l'oggetto Contribuente
        public Contribuente(string nome, string cognome, Sesso genere, DateOnly dataNascita, string comuneResidenza, double redditoAnnuale, string codiceFiscale)
        {
            // Inizializza le proprietà con i valori passati
            this.nome = nome;
            this.cognome = cognome;
            this.genere = genere;
            this.dataNascita = dataNascita;
            this.comuneResidenza = comuneResidenza;
            this.redditoAnnuale = redditoAnnuale;
            this.codiceFiscale = codiceFiscale;
        }

        // Metodo per calcolare l'imposta basata sul reddito annuale
        public double CalcoloImposta()
        {
            double imposta = 0;

            // Calcola l'imposta in base agli scaglioni di reddito
            if (redditoAnnuale <= 15000)
            {
                imposta = redditoAnnuale * 0.23;
            }
            else if (redditoAnnuale > 15000 && redditoAnnuale <= 28000)
            {
                imposta = 3450 + (redditoAnnuale - 15000) * 0.27;
            }
            else if (redditoAnnuale > 28000 && redditoAnnuale <= 55000)
            {
                imposta = 6960 + (redditoAnnuale - 28000) * 0.38;
            }
            else if (redditoAnnuale > 55000 && redditoAnnuale <= 75000)
            {
                imposta = 17220 + (redditoAnnuale - 55000) * 0.41;
            }
            else if (redditoAnnuale > 75000)
            {
                imposta = 25420 + (redditoAnnuale - 75000) * 0.43;
            }

            return imposta; // Restituisce l'imposta calcolata
        }
    }
}
