using System;
using System.Globalization;

namespace Net.M.A007.Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello , toi là viet anh!");
            Console.WriteLine("Hello , toi là viet anh!");
            Console.WriteLine("Hello , toi là viet anh!");
            Console.WriteLine("Hello , toi là viet anh!");
            Console.WriteLine("Hello , toi là viet anh!");

            DateTime inputDate;
            do
            {
                Console.Write("Input date(dd/MM/yyyy): ");

            } while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy", null, DateTimeStyles.None, out inputDate));
            int workingDay = 0;
            while (workingDay <= 12)
            {
                inputDate = inputDate.AddDays(1);
                if (IsWorkingDay(inputDate))
                {
                    workingDay++;

                }
                else
                {
                    continue;
                }
                if (workingDay == 7)
                {
                    Console.WriteLine("1st reminder: " + inputDate.ToString("dd/MM/yyyy"));

                }
                if (workingDay == 9)
                {
                    Console.WriteLine("2st reminder: " + inputDate.ToString("dd/MM/yyyy"));

                }
                if (workingDay == 10)
                {
                    Console.WriteLine("3st reminder: " + inputDate.ToString("dd/MM/yyyy"));
                }
                if (workingDay == 11)
                {
                    Console.WriteLine("4st reminder: " + inputDate.ToString("dd/MM/yyyy"));
                }
                if (workingDay == 12)
                {
                    Console.WriteLine("5st reminder: " + inputDate.ToString("dd/MM/yyyy"));
                }
            }
            Console.ReadKey();
        }
        #region Methods check Workingday
        private static bool IsWorkingDay(DateTime date)
        {
            switch (date.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    return false;
                default:
                    return true;

            }
        }
        #endregion
       
    }
}
