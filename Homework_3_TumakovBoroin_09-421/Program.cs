namespace Homework_3_TumakovBoroin_09_421
{
    internal class Program
    {
        static void Task1()
        {
            Console.WriteLine("\nУпражнение 4.1");

            try
            {
                Console.WriteLine("Введите число от 1 до 365 (номер дня в году): ");
                int answer_user = int.Parse(Console.ReadLine());

                
                int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                
                int month = 0;
                while (answer_user > daysInMonth[month])
                {
                    answer_user -= daysInMonth[month];
                    month++;
                }

                string monthName = GetMonthName(month);
                Console.WriteLine($"Вы ввели число {answer_user}, это {monthName} {answer_user}-й день.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неверное значение! Пожалуйста, введите число.");
            }
        }

        static void Task2()
        {
            Console.WriteLine("\nУпражнение 4.2");

            try
            {
                Console.WriteLine("Введите число от 1 до 365 (номер дня в году): ");
                int answer_user;
                bool isValid = int.TryParse(Console.ReadLine(), out answer_user);

                
                if (!isValid || answer_user < 1 || answer_user > 365)
                {
                    throw new ArgumentOutOfRangeException($"Некорректное значение! Введите число от 1 до 365.");
                }


                int[] daysInMonth = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

                
                int month = 0;
                while (answer_user > daysInMonth[month])
                {
                    answer_user -= daysInMonth[month];
                    month++;
                }

                string monthName = GetMonthName(month);
                Console.WriteLine($"Вы ввели число {answer_user}, это {monthName} {answer_user}-й день.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неверное значение! Пожалуйста, введите число.");
            }
        }

        static void Task3()
        {
            Console.WriteLine("\nДомашнее задание 4.1");

            try
            {
                Console.WriteLine("Введите год: ");
                int year = int.Parse(Console.ReadLine());

                bool isLeapYear = IsLeapYear(year);
                int daysInYear = isLeapYear ? 366 : 365;
                Console.WriteLine($"Год {year} {(isLeapYear ? "високосный" : "невисокосный")}.");

                Console.WriteLine($"Введите число от 1 до {daysInYear} (номер дня в году): ");
                int answer_user;
                bool isValid = int.TryParse(Console.ReadLine(), out answer_user);

                if (!isValid || answer_user < 1 || answer_user > daysInYear)
                {
                    throw new ArgumentOutOfRangeException($"Некорректное значение! Введите число от 1 до {daysInYear}.");
                }

                
                int[] daysInMonth = isLeapYear
                    ? new int[] { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }  
                    : new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 }; 

                
                int month = 0;
                while (answer_user > daysInMonth[month])
                {
                    answer_user -= daysInMonth[month];
                    month++;
                }

                string monthName = GetMonthName(month);
                Console.WriteLine($"Вы ввели число {answer_user}, это {monthName} {answer_user}-й день.");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                Console.WriteLine("Введено неверное значение! Пожалуйста, введите число.");
            }
        }

        
        static string GetMonthName(int month)
        {
            string[] monthNames = new string[]
            {
            "Январь", "Февраль", "Март", "Апрель", "Май", "Июнь",
            "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"
            };
            return monthNames[month];
        }

        
        static bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }

        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();

        }
    }
}
