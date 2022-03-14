using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Predavanja_vaje_14_3
{
    public class Tabela //damo public!!
    {
        public static string Izpis(string a)
        {
            return a + "nov niz";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("asd");
            string niz = Izpis("primer");
            Console.WriteLine(niz);
            Console.WriteLine("še neki");
            //string x = "asd";
            //string y = "bla";
            //int z = (int)(object)(x + y);
            //Console.WriteLine(z);

            //funkcija(10,vrenost : 10)
            string[] tab = { "Prvo", "Drugo", "Tretje" };
            string iti = DeloTabela.Vrni_iti_element(1, tab);
            Console.WriteLine(iti);
        }
        public static T Vsota <T>(T[] tab)
        {
            dynamic vsota = tab[0];
            for (int i = 1; i < tab.Length; i++)
            {
                vsota += tab[i];
            }

                return vsota;
                    }
    }
}
