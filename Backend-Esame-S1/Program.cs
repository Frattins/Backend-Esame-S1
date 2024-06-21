namespace Backend_Esame_S1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci i dati del contribuente:");

            Console.Write("Nome:  ");
            string nome = Console.ReadLine();

            Console.Write("Cognome: ");
            string cognome = Console.ReadLine();

            Console.Write("Data di Nascita (gg/mm/aaaa):");
            DateTime dataNascita = DateTime.Parse(Console.ReadLine());

            Console.Write("Codice Fiscale:");
            string codiceFiscale = Console.ReadLine();

            Console.Write("Sesso (M/F):");
            char sesso = char.Parse(Console.ReadLine());

            Console.Write("Comune di Residenza: ");
            string comuneResidenza = Console.ReadLine();

            Console.Write("Reddito Annuale: ");
            decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

            contribuente contribuente = new contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);

            decimal imposta = contribuente.CalcolaImposta();

            Console.WriteLine("===============================================");
            Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
            Console.WriteLine($"Contribuente: {contribuente.Nome} {contribuente.Cognome},");
            Console.WriteLine($"nato il {contribuente.DataNascita.ToShortDateString()} ({contribuente.Sesso}),");
            Console.WriteLine($"residente in {contribuente.ComuneResidenza},");
            Console.WriteLine($"codice fiscale: {contribuente.CodiceFiscale}");
            Console.WriteLine($"Reddito dichiarato: {contribuente.RedditoAnnuale:C}");
            Console.WriteLine($"IMPOSTA DA VERSARE: {imposta:C}");
        }
    }
}
