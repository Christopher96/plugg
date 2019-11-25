using System;
using System.IO;

namespace task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "hello.dat";
            string newString = "";

            using (StreamReader tr = new StreamReader(path))
            {
                string line;
                while((line = tr.ReadLine()) != null) {
                    newString += line + ", ";
                }
                tr.Close();
            }

            using (StreamWriter tw = new StreamWriter(path))
            {
                tw.Write(newString);
                tw.Close();
            } 

        }
    }
}
