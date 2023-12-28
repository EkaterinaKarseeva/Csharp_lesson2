// 1 Задача

Console.WriteLine("Введите число для проверки:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number % 7 == 0 && number % 23 == 0)
            {
                Console.WriteLine($"{number} кратно одновременно 7 и 23");
            }
            else
            {
                Console.WriteLine($"{number} не кратно одновременно 7 и 23");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
        }