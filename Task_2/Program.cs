using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Train[] trains = new Train[8];

            // це якщо не хочете сами заповнювати масив
            //trains[0] = new Train(4556, "Timiti");
            //trains[1] = new Train(3455, "Lisi");
            //trains[2] = new Train(1244, "Dimo");
            //trains[3] = new Train(9657, "Lodo");
            //trains[4] = new Train(4236, "Nopo");
            //trains[5] = new Train(1245, "Triof");
            //trains[6] = new Train(5677, "Forio");
            //trains[7] = new Train(3643, "Timiti");


            Console.WriteLine(new String('=', 80));
            Console.WriteLine("Маршрутній лист поїздів!");
            Console.WriteLine("Перед початком потрібно заповнити маршрутнй лист из 8 машрутів");
            Console.WriteLine(new String('=', 80));



            for (int i = 0; i < trains.Length; i++)
            {


                int trainNumber = UsInterface.UsInTrainNumber("Введіть номер потяга (4 цифри): ");

                Console.Write("Введіть пунк призначення: ");
                string destinationName = Console.ReadLine();

                //для практики
                string departureTime = $"{new Random().Next(1, 30)}/{new Random().Next(1, 13)}";

                //або так;
                //Console.Write("Введіть дату відправлення (через кому): ");
                //string departureTime = Console.ReadLine();

                trains[i] = new Train(trainNumber, destinationName, departureTime);
                Console.Clear();
            }

            trains.ExtenshenSortArray();


            while (true)
            {
                Console.WriteLine(new String('=', 80));
                Console.WriteLine("Маршрутній лист поїздів! (заповнений)");
                Console.WriteLine("1 - вивести всі маршрути; 2 - пошук по номеру потяга");
                Console.WriteLine(new String('=', 80));
                Console.Write("Виберіть пункт меню: ");
                int namMenu = UsInterface.NamberMenuIn();

                switch (namMenu)
                {
                    case 1:
                        {
                            foreach (var item in trains)
                            {
                                item.ShowInfo();
                            }
                            Console.WriteLine("\nНатисныть на будь яку кнопку щоб продовжити!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                    case 2:
                        {
                            //в данному віпатку я не реалізовував вивід декількох значень так як
                            //по ідеї номер потяга повінен бути унікальнім
                            int trainNumber = UsInterface.UsInTrainNumber("Введіть номер потяга (4 цифри): ");
                            trains.RouteSearch(trainNumber);

                            Console.WriteLine("\nНатисныть на будь яку кнопку щоб продовжити!");
                            Console.ReadKey();
                            Console.Clear();

                            break;
                        }
                    default:
                        {
                            UsInterface.ErrorShow("Такого номера меню не існуе");

                            Console.WriteLine("\nНатисныть на будь яку кнопку щоб продовжити!");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            }






            Console.ReadKey();
        }
    }
}
