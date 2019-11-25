using System;

namespace lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Fält med alla alternativ i menyn
            string[] options = new string[] {
                "Spela",
                "Instruktioner",
                "Avsluta"
            };

            // Huvudloop tills programmet avslutas
            while(true) {
                // Printa ut alla menyalternativ
                for(int i = 0; i < options.Length; i++) {
                    Console.WriteLine("[{0}] {1}", (i+1).ToString(), options[i]);
                }

                // Läs val av menyalternativ
                ConsoleKeyInfo input = Console.ReadKey();
                int choice = char.IsDigit(input.KeyChar) ? int.Parse(input.KeyChar.ToString()) : -1;

                // Exekvera metoder efter menyval har gjorts
                switch(choice) {
                    case 1: new Game(); break;
                    case 2: printInstructions(); break;
                    case 3: Environment.Exit(0); break;
                    default: continue;
                }
            }
        }

        // Skriv ut instruktioner för spelet
        static void printInstructions() {
            Console.WriteLine("\nSpelet fungerar så att man kastar iväg en banan, genom att man anger en vinkel och en hastighet. Om den kastade bananen landar inom en meter från apan träffar den apan och ger poäng. Apan börjar på 100 meters avstånd. För varje kast som görs kommer apan 10 meter närmare. Efter apans framåtflytt görs ett nytt kast. Om man träffat apan med minst 5 bananer är apan nöjd och glad och kastaren får en apkram. Om man träffat med mindre än 5 bananer äter apan upp spelaren.");
            Console.Read();
        }
    }
}
