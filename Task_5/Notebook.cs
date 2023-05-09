using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public struct Notebook
    {
        string model;
        string producer;
        double cost;

        public Notebook(string model, string producer, double cost)
        {
            this.model = model;
            this.producer = producer;
            this.cost = cost;
        }


        public void Showinfo()
        {
            Console.WriteLine(new String('-', 50));
            Console.WriteLine($" Модель: {model} | Виробник {producer} | Ціна: {cost:f} грн");
            Console.WriteLine(new String('-', 50));
        }

    }
}
