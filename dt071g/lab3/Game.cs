using System;

namespace lab3
{
    class Game
    {  
        // Definera attribut med properties
        private int _round = 0;
        private int round {
            get { return _round; }
            set { _round = value; }
        }
       
        private int _score = 0;
        private int score {
            get { return _score; }
            set { _score = value; }
        }
       
        private int distance {
            get { return _distance; }
            set { _distance = value; }
        }

        // Definera inställningar för spel
        private int _distance = 100;
        private int throwCount = 10;
        private int windRange = 5;
        private int tableWidth = 60;
        private int numCells = 4;
        
        // Definera fält för kast och tabellformat
        private int[,] throws;
        private string tableFormat;

        public Game() {
            // Räkna ut apans hastighet
            int movingDistance = this.distance/this.throwCount;

            // Återställ kast
            throws = new int[this.throwCount, this.numCells];

            // Räkna ut storleken på varje cell i tabellen
            int cellWidth = this.tableWidth/this.numCells;

            // Skapa ett strängformat för tabellen med hjälp av cell storleken
            tableFormat = "{0,-"+cellWidth+"}{1,-"+cellWidth+"}{2,"+cellWidth+"}{3,"+cellWidth+"}";
           
            // Kasta bananer tills apan är framme
            for(int i = 0; this.distance > 0; i++) {
                printTitle("Kasta Banan");
                // Slumpartad värde för vind
                int wind = new Random().Next(-windRange, windRange);

                // Starta nytt kast med ny vind i varje iteration
                double length = newThrow(wind);
                
                // Kolla om bananen landade 1 meter ifrån apan och ge poäng
                bool newScore = false;
                if(Math.Abs(this.distance-length) <= 1) {
                    newScore = true;
                    this.score++;
                }
                printLines(this.tableWidth);
                Console.Write("\n");
                Console.WriteLine(newScore ? "Du träffade apan!" : "Du missade apan!");

                // Spara kastet i det multidimensionella fältet
                throws[i,0] = this.round;
                throws[i,1] = this.distance;
                throws[i,2] = wind;
                throws[i,3] = this.score;
                
                // Minska avståndet för apan
                this.distance -= movingDistance;
            }
            
            printTitle("Game Over");

            // Skriv ut ascii-figurer vid spelets slut beroende på om man fick 5 eller fler träffar
            if(score >= 5) {
                Console.Write(
                    " \\o/  c(..)o\n"+
                    "  |    (-)   \n"+
                    " / \\   / \\   "
                );
                Console.WriteLine("Du fick en apkram!");
            } else {
                Console.Write(
                    "             \n"+
                    " /|\\        \n"+
                    " / \\  o       "
                );
                Console.WriteLine("Apan åt upp dig!");
            }
            Console.ReadLine();    
            printResults();            
        }

        // Metod för nya kast som kräver vind som parameter
        public double newThrow(int w) {
            round++;
            
            // Skriv ut statistik för aktuellt kast med hjälp av tabellformatet
            Console.WriteLine();
            string table = String.Format(this.tableFormat, "Runda: "+this.round, "Avstånd: "+this.distance+"m", "Vind: "+w+"m/s", "Poäng: "+this.score);
            Console.WriteLine(table);
            
            // Läs användarinput för vinkel och hastighet på kast
            Console.Write("Vinkel (grader): ");
            int angle = int.Parse(Console.ReadLine());
            Console.Write("Hastighet (m/s): ");
            int v = int.Parse(Console.ReadLine());

            // Räkna ut radianer för vinkel i grader och definera gravitationskonstant
            double a = (Math.PI / 180) * angle;
            double g = 9.81;

            // Räkna ut kastlängden med vinkel, vind, hastighet och gravitation.
            double length = 2*Math.Pow(v, 2)*Math.Cos(a)*Math.Sin(a)/g - w*v*Math.Sin(a)/g;

            // Returnera kastlängd
            return length;
        }
        
        public void printResults() {
            printTitle("Resultat");
            
            // Printa ut en ny tabell med tabellformatet
            string table = String.Format(this.tableFormat, "Runda", "Avstånd", "Vind", "Poäng");
            Console.Write("\n");
            Console.WriteLine(table);

            // Loopa igenom alla kast
            for(int t = 0; t < this.throwCount; t++) {
                // Printa ut varje kast och dess värden i tabellen från det multidimensionella fältet
                string stats = String.Format(this.tableFormat, throws[t,0], throws[t,1], throws[t,2], throws[t,3]);
                Console.WriteLine(stats);
            }

            // Printa ut totalpoäng
            printLines(this.tableWidth);
            Console.WriteLine("\nTotal poäng: {0}", this.score);
            Console.ReadLine(); 
        }
        
        // Printa ut sträck med en specifik längd
        public void printLines(int length) {
            for(int i = 0; i < length; i++) {
                Console.Write("-");
            }
        }

        // Printa ut en titel med hjälp av sträck funktionen
        public void printTitle(string title) {
            Console.WriteLine();
            string text = " "+title+" ";
            int lineLength = this.tableWidth/2 - text.Length/2;
            printLines(lineLength);
            Console.Write(text);
            printLines(lineLength);
    
        }
    }
}
