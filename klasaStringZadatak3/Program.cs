using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringZadatak3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string niz;
            
            jopet:
            Console.Write("Unesite niz znakova: ");
            niz = Console.ReadLine();


            if (niz.Length > 11)
            {
                int zadnjipet = niz.Length;

                Console.WriteLine("Velika slova: " + niz.ToUpper());
                Console.WriteLine("Mala slova: " + niz.ToLower());
                Console.WriteLine("Prva tri unešena znaka: " + niz.Substring(0, 3));
                Console.WriteLine("Prva tri unešena znaka: " + niz.Substring(niz.Length - 5, 5));
                Console.WriteLine("Od 8 do 11 znaka: " + niz.Substring(7, 4));

                Console.ReadKey();

            }
            else
            {

                goto jopet;

            }


        }
    }
}
