using System;
using System.IO;
using System.Text;

namespace moment2
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Väkomstmedellande
            Console.WriteLine("Välkommen till skottningsprogrammet");
            Console.ReadLine();

            // Skriv ut fråga och vänta på input som sparas i en sträng
            Console.WriteLine("Hur bred är din garageuppfart (i meter)?");
            string breddTxt = Console.ReadLine();
            Console.WriteLine("Hur djup är din garageuppfart (i meter)?");
            string djupTxt = Console.ReadLine();
            Console.WriteLine("Hur många kvadratmeter orkar du skotta per timme?");
            string kvmTxt = Console.ReadLine();

            // Konvertera strängar till int variabler för beräkning
            double bredd = double.Parse(breddTxt);
            double djup = double.Parse(djupTxt);
            double kvm = double.Parse(kvmTxt);

            // Beräkna area, timmar och minuter
            double area = bredd*djup;
            double timmar = area/kvm;
            double minuter = timmar*60;
            
            // Konvertera resultat till sträng och skriv ut.
            string minuterTxt = minuter.ToString();
            Console.WriteLine();
            string output = String.Format("Det kommer att ta dig {0} minuter att skotta.", minuterTxt);
            FileStream fs = null;
            try
            {
                // fs = new FileStream("./outdata", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.Read);

                // byte[] rsByteArray = Encoding.Default.GetBytes(output);
                // fs.Write(rsByteArray, 0, rsByteArray.Length);

                // fs.Position = 0;

                // byte[] fileByteArray = new byte[rsByteArray.Length];

                // for(int i = 0; i < rsByteArray.Length; i++) {
                //     fileByteArray[i] = (byte)fs.ReadByte();
                // }

                // Console.WriteLine(Encoding.Default.GetString(fileByteArray));
                // fs.Close();
                // using (TextReader tr = new StreamReader(fs))
                // {
                //     fs = null;
                //     // Code here
                // }

                string path = "./outdata.dat";

                StreamWriter sw = File.CreateText(path);

                sw.WriteLine(output);
                sw.WriteLine("hello");
                sw.Close();

                StreamReader sr = File.OpenText(path);

                Console.WriteLine("Peek: {0}", Convert.ToChar(sr.Peek()));
                Console.WriteLine("1st Line: {0}", sr.ReadLine());
                Console.WriteLine("Everything: {0}", sr.ReadToEnd());

                sr.Close();
            }
            finally
            {
                if (fs != null)
                    fs.Dispose();
            }
        }
    }
}
