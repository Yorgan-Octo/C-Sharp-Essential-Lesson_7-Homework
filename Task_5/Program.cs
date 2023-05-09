using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Notebook[] notebooks = new Notebook[] 
            {
                new Notebook("Domino", "ERC", 57684),
                new Notebook("Domino", "YUG", 765),
                new Notebook("Domino", "FIG", 235),
                new Notebook("Domino", "NIMB", 976),
                new Notebook("Domino", "IMDB", 356),
            };


            foreach (var item in notebooks)
            {
                item.Showinfo();
            }

            Console.ReadKey();
        }
    }
}
