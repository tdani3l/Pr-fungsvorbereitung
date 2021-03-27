using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS1
{
    //1.1 - 1.3

    class Program
    {
        public static int[] liste = new int[30];
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            ListInit();

            foreach (var item in liste)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n=============================================================");

            ListSort();

            foreach (var item in liste)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }

        static void ListInit()
        {
            int i = 0;
            while (i < 30)
            {
                liste[i] = rnd.Next(1, 1000);
                i++;
            }
        }

        static void ListSort()
        {
            int i = 0;
            int j;
            int help;
            while (i < 29)
            {
                j = i + 1;
                while (j < 30)
                {
                    if (liste[i] > liste[j])
                    {
                        help = liste[i];
                        liste[i] = liste[j];
                        liste[j] = help;
                    }

                    j++;
                }
                i++;
            }
        }
    }
}
