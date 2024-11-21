namespace Homework_3
{
    internal class Program
    {
        enum DaysOfWeek
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Thursday = 4,
            Friday = 5,
            Saturday = 6,
            Sunday = 7
        }

        static void Task1()
        {
            Console.WriteLine("1 задание\n");
            Console.WriteLine("Введите 10 чисел: ");
            int[] numbers = new int[10];


            for (int i = 0; i < 10; i++)
            {
                bool isValid = int.TryParse(Console.ReadLine(), out numbers[i]);
                if (!isValid)
                {
                    Console.WriteLine("Вы ввели не число! Попробуйте еще раз.");
                    i--;
                }
            }


            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    Console.WriteLine($"Последовательность не упорядочена. Ошибка на позиции {i + 1}.");
                    break;
                }

                
                if (i == numbers.Length - 1)
                {
                    Console.WriteLine("Последовательность упорядочена по возрастанию.");
                }

            }

            // SS
            
        }

        
        static void Task2()
        {
            Console.WriteLine("2 задание\n");
            Console.WriteLine("Введите порядковый номер карты (6 <= k <= 14): ");
            Console.WriteLine("6 — шестерка, 7 — семерка, 8 — восьмерка, 9 — девятка, 10 — десятка.");
            Console.WriteLine("11 — валет, 12 — дама, 13 — король, 14 — туз.");

            try
            {
                int k = int.Parse(Console.ReadLine());

                if (k < 6 || k > 14)
                {
                    throw new ArgumentOutOfRangeException(); 
                }

                string card; 

                switch (k)
                {
                    case 6:
                        card = "шестерка";
                        break;
                    case 7:
                        card = "семерка";
                        break;
                    case 8:
                        card = "восьмерка";
                        break;
                    case 9:
                        card = "девятка";
                        break;
                    case 10:
                        card = "десятка";
                        break;
                    case 11:
                        card = "валет";
                        break;
                    case 12:
                        card = "дама";
                        break;
                    case 13:
                        card = "король";
                        break;
                    case 14:
                        card = "туз";
                        break;
                    default:
                        card = "неизвестная карта";
                        break;
                }

                Console.WriteLine($"Карта с номером {k} — это {card}.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Некорректный ввод! Введите число.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Ошибка! Номер карты должен быть в диапазоне от 6 до 14.");
            }
            finally
            {
                Console.WriteLine("Попробуйте снова, если ввели данные неправильно.");
            }

        }
        static void Task3()
        {
            Console.WriteLine("3 задание\n");
            Console.WriteLine("Выберите что написать, вот следующие варианты:\nJabroni\nSchool Counselor\nProgrammer\nBike Gang Member");
            Console.WriteLine("Politician\nRapper\nanything else");
            Console.WriteLine("Можете писать как с маленькой буквы так и с большой!");
            string answer_user = Console.ReadLine().ToLower();
            switch (answer_user)
            {
                case "jabroni":
                    string output = "Patron Tequila";
                    Console.WriteLine(output);
                    break;
                case "school counselor":
                    output = "Anything with Alcohol";
                    Console.WriteLine(output);
                    break;
                case "programmer":
                    output = "Hipster Craft Beer";
                    Console.WriteLine(output);
                    break;
                case "bike gang member":
                    output = "Moonshine";
                    Console.WriteLine(output);
                    break;
                case "politician":
                    output = "Your tax dollars";
                    Console.WriteLine(output);
                    break;
                case "rapper":
                    output = "Cristal";
                    Console.WriteLine(output);
                    break;
                case "anything else":
                    output = "Beer";
                    Console.WriteLine(output);
                    break;
                default:
                    Console.WriteLine("Beer");
                    break;
            }
        }

        static void Task4()
        {
            Console.WriteLine("4 задание\n");
            Console.WriteLine("Введите число(числа зависят таким образом):\n1 - Monday\n2 - Tuesday\n3 - Wednesday\n4 - Thursday\n5 - Friday\n6 - Saturday\n7 - Sunday");
            int answer_user;
            bool isValid = int.TryParse(Console.ReadLine(), out answer_user);
            if (!isValid || answer_user < 1 || answer_user > 7)
            {
                Console.WriteLine("Неправильный ввод!\nТакого значения не найдено!");
            }
            else
            {
                DaysOfWeek day = (DaysOfWeek)answer_user;
                Console.WriteLine($"День недели получился: {day}");
            }
        }
        static void Task5()
        {
            Console.WriteLine("5 задание\n");
            Console.WriteLine("Введите сколько элементов вы хотите иметь в массиве: ");
            int number_answer_user;
            bool isValid = int.TryParse(Console.ReadLine(), out number_answer_user);

            if (!isValid || number_answer_user <= 0)
            {
                Console.WriteLine("Некорректное значение! Число должно быть больше нуля.");
                return; 
            }

            string[] strings_mass = new string[number_answer_user];

            
            for (int i = 0; i < strings_mass.Length; i++)
            {
                Console.WriteLine("Введите любой текст: ");
                strings_mass[i] = Console.ReadLine();
            }

            Console.WriteLine("\nВы ввели следующие строки:");
            foreach (string str in strings_mass)
            {
                Console.WriteLine(str);
            }

            int count_dolls = 0; 
            foreach (string str in strings_mass)
            {
                
                if (str.ToLower() == "hello kitty" || str.ToLower() == "barbie doll")
                {
                    Console.WriteLine("\nНашли куклу! Кладем в сумку!");
                    count_dolls++;
                }
            }

            Console.WriteLine($"Количество кукол, которые лежат в сумке = {count_dolls}");
        }


    
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Task5();


        }
    }
}