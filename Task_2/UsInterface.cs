using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public static class UsInterface
    {

        //я знаю що їх треба росподиляти и обеднувати в ризні класи по сенсу але часу немае
        public static int UsInTrainNumber(string text)
        {

            int trainNumber;
            while (true)
            {
                try
                {
                    Console.Write(text);
                    trainNumber = int.Parse(Console.ReadLine());

                    if (trainNumber < 1000 || trainNumber > 9999)
                    {
                        Console.Clear();
                        ErrorShow("Повнно бути 4 чифри");
                        
                        continue;
                    }

                    break;
                }
                catch (Exception)
                {
                    Console.Clear();
                    ErrorShow("Невірні данні!");

                }
            }

            return trainNumber;
        }

        public static void ErrorShow(string errorText)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(errorText);
            Console.ResetColor();
        }

        public static void ExtenshenSortArray(this Train[] trains)
        {

            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = i + 1; j < trains.Length; j++)
                {
                    if (trains[i].TrainNumber > trains[j].TrainNumber)
                    {
                        Train temp = trains[i];
                        trains[i] = trains[j];
                        trains[j] = temp;
                    }
                }
            }


        }

        public static int NamberMenuIn()
        {

            int namMenu;
            while (true)
            {
                try
                {
                    Console.Write("Виберіть пункт меню: ");
                    namMenu = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    ErrorShow("Помилка повторіть спробу;");
                }
            }

            return namMenu;
        }

        public static void RouteSearch(this Train[] trains, int namTrain)
        {

            foreach (var item in trains)
            {
                if (item.TrainNumber == namTrain)
                {
                    item.ShowInfo();
                    return;
                }
            }

            ErrorShow("Такого машрута нема");

        }

    }

}
