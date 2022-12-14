
/* 
Si vuole progettare un sistema per la gestione 
di una biblioteca. 
Gli utenti si possono registrare al sistema, fornendo:
cognome,
nome,
email,
password,
recapito telefonico,
Gli utenti registrati possono effettuare dei prestiti 
sui documenti 
che sono di vario tipo (libri, DVD). I documenti sono 
caratterizzati da:
un codice identificativo di tipo stringa 
(ISBN per i libri, numero seriale per i DVD),
titolo,
anno,
settore (storia, matematica, economia, …),
stato (In Prestito, Disponibile),
uno scaffale in cui è posizionato,
un autore (Nome, Cognome).
Per i libri si ha in aggiunta il numero di pagine, mentre 
per i dvd la durata.
L’utente deve poter eseguire delle ricerche per codice o per 
titolo e, eventualmente, effettuare 
dei prestiti registrando il periodo (Dal/Al) del prestito 
e il documento.
Deve essere possibile effettuare la ricerca dei prestiti 
dato nome e cognome di un utente.
 */



public class Documento
{
    public Documento(string titolo, bool stato)
    {
        this.Titolo = titolo;
        this.Stato = stato;
    }

    public string Titolo { get; set; }
    public int Anno { get; set; }
    public string Settore { get; set; }
    public bool Stato { get; set; }
    public int Scaffale { get; set; }
    public Autore Autore { get; set; }
}
