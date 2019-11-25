using System;

namespace moment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definering av Chopin objekt
            CD myChopinCDObject = new CD();
            myChopinCDObject.artist = "Frédéric Chopin";
            myChopinCDObject.title = "Nocturnes";
            myChopinCDObject.genre = "Classical";
            myChopinCDObject.year = 1827;
            myChopinCDObject.company = "Chopin";
            myChopinCDObject.songs = 21;
            myChopinCDObject.length =  116;

            // Definering av Liszts objekt
            CD myLisztsCDObject = new CD("Mūza Rubackytė", "Parcours Satanique");
            myLisztsCDObject.genre = "Classical";
            myLisztsCDObject.year = 2000;
            myLisztsCDObject.company = "Lyrinx";
            myLisztsCDObject.songs = 7;
            myLisztsCDObject.length = 95;
            
            // Definering av HipHop objekt
            CD myHipHopCDObject = new CD("Eminem", "The Slim Shady EP", "HipHop", 1997, "Shady Records", 10, 38);

            // Utmatning av alla objekt
            myChopinCDObject.PrintBrief();
            myLisztsCDObject.PrintFull();
            myHipHopCDObject.PrintFull();
        }
    }
}
