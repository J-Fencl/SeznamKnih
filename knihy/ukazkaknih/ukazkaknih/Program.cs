namespace ukazkaknih
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {            
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class Knihy
    {
        public string nazev;
        public string autor;
        public string pocetstranek;
        public string obsah;
        public string hodnoceni;
        public Knihy(string nazev, string autor, string pocetstranek, string obsah, string hodnoceni)
        {
            this.nazev = nazev;
            this.autor = autor;
            this.pocetstranek = pocetstranek;
            this.obsah = obsah;
            this.hodnoceni = hodnoceni;
        }
        
    }
}