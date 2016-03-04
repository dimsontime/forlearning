using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public static string Coding (string a, int key)
        {
            string ResStr = ""; //Resulted String
            int SL = a.Length; //String Length
            for (int i=0; i < SL; i++)
            {
                ResStr = ResStr.Insert(ResStr.Length, Convert.ToString((char)(a[i] ^ key)));
            }
            return ResStr;
        }

        static void Main(string[] args)
        {
            string EntStr;
            Console.WriteLine("Enter string to code:");
            EntStr = Console.ReadLine();
            Console.WriteLine("Enter code key:");
            int CK = int.Parse(Console.ReadLine()); ; // Coding Key
            string CdS = Coding(EntStr, CK);
            Console.WriteLine("Coded string");
            Console.WriteLine(CdS);
            EntStr = Coding(CdS, CK);
            Console.WriteLine("Decoded string");
            Console.WriteLine(EntStr);
            Console.ReadKey();
        }
    }
}
