﻿// 1 Задача

//Console.WriteLine("Введите число для проверки:");
        //string input = Console.ReadLine();

        //if (int.TryParse(input, out int number))
        //{
            //if (number % 7 == 0 && number % 23 == 0)
            //{
                //Console.WriteLine($"{number} кратно одновременно 7 и 23");
            //}
           // else
            //{
                //Console.WriteLine($"{number} не кратно одновременно 7 и 23");
            //}
       // }
        //else
        //{
            //Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
       // }

// Задача 2


        Console.WriteLine("Введите целое число из диапазона [10, 99]:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number >= 10 && number <= 99)
            {
                int maxDigit = FindMaxDigit(number);
                Console.WriteLine($"Наибольшая цифра в числе {number} - {maxDigit}");
            }
            else
            {
                Console.WriteLine("Ошибка. Введите целое число из диапазона [10, 99].");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
        }

    static int FindMaxDigit(int number)
    {
        int maxDigit = 0;
        while (number > 0)
        {
            int digit = number % 10;
            if (digit > maxDigit)
            {
                maxDigit = digit;
            }
            number /= 10;
        }
        return maxDigit;
    }
