using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public struct Train
    {
        private int trainNumber;
        private string destinationName;
        private DateTime departureTime;


        public int TrainNumber
        {
            get { return trainNumber; }
        }


        public Train(int trainNumber, string destinationName, string departureTime = "11/12")
        {
            this.trainNumber = trainNumber;
            this.destinationName = destinationName;
            this.departureTime = DateTime.Parse(departureTime);

        }


        public void ShowInfo()
        {
            Console.WriteLine(new String('-',80));
            Console.WriteLine($" Номер потяга: {trainNumber} | " +
                $"Пунк призначення {destinationName} | Дата відправлення: {departureTime.Day:D}/{departureTime.Month:D}");
            Console.WriteLine(new String('-', 80));
        }


    }
}
