using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyClass myClass = new MyClass(); 
            MyStruct myStruct;


            Console.WriteLine("Класс: ");
            Console.WriteLine("-----------------------------------------------------");
            myClass.change = "не змінено";
            Console.WriteLine(myClass.change);

            ClassTaker(myClass);
            Console.WriteLine(myClass.change);

            Console.WriteLine("=====================================================");

            Console.WriteLine("Структура: ");
            Console.WriteLine("-----------------------------------------------------");
            myStruct.change = "не змінено";
            Console.WriteLine(myStruct.change);

            StruktTaker(myStruct);
            Console.WriteLine(myStruct.change);

            Console.ReadKey();

        }


        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "Зминено в ClassTaker";
        }

        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "Зминено в StruktTaker";
        }
    }
}
