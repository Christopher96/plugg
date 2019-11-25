using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 1. ja
 * 2. nej
 * 3. nej
 * 4. nej
 * 5. ja, nej
 * 6. 1
 * 7. 3
 * 8. 3
 * 9. 4
 * 10. 0
 * 11. 1
 * 12. 2
 * 13. 
 * 
8
9
0
1
2
*/

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(1028 % 10);
            //Console.WriteLine(1029 % 10);
            //Console.WriteLine(1030 % 10);
            //Console.WriteLine(1031 % 10);
            //Console.WriteLine(1032 % 10);
            Console.WriteLine(908235 % 10);
            Console.WriteLine(Mod10(908235));
            Console.Read();
        }

        static string Mod10(int num)
        {
            string numStr = num.ToString();
            return numStr.Substring(numStr.Length-1);
        }
    }
}
