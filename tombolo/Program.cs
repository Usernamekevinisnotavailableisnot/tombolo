using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace tombolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            
            int a, b, y;
            b = 91;
            
            for(int z=0; z<b; z++)
            {
                a = z;
                Console.Write(a+"   ");
            }
            Random r= new Random();
            Console.WriteLine("");
            for(int z=0; z<120;z++)
            {
                Console.Write("_");
            }
            Console.WriteLine(" ");
            for (int g=0; g<15; g++) 
            {
                
                y = (r.Next(14) + 1);
                Console.Write(""+y+" ");
            }
            Console.WriteLine("");
            for (int z = 0; z < 120; z++)
            {
                Console.Write("_");
            }
            Console.WriteLine(" ");
            for (int f = 0; f < 15; f++)
            {

                y = (r.Next(14) + 1);
                Console.Write("" + y + " ");
            }
            Console.WriteLine("");
            for (int d = 0; d < 120; d++)
            {
                Console.Write("_");

            }
            Console.WriteLine("");
            List<int> numeriEstratti = new List<int>();
            Random k = new Random();

            //int numeroDaControllare = y;
            Timer t = new Timer();
            t.Interval = 1000; // 1000ms = 1s
            t.Elapsed += EstrattiNumero;
            t.Start();
            Console.ReadLine(); // tenere aperta la finestra del console
        }
        private static void EstrattiNumero(Object source, ElapsedEventArgs e)
        {
            Random rnd = new Random();
            int numeroEstratto = rnd.Next(1, 100);
            Console.Write("    Numero estratto: " + numeroEstratto);
        }
        private List<int> numeriGenerati = new List<int>();

        private Random rnd = new Random();

        public int GeneraNumero()
        {
            int numeroDaGenerare = rnd.Next(1, 100);

            while (numeriGenerati.Contains(numeroDaGenerare))
            {
                numeroDaGenerare = rnd.Next(1, 100);
            }

            numeriGenerati.Add(numeroDaGenerare);

            return numeroDaGenerare;
        }
    }
}

