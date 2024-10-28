using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите номер задачи от 39 до 53:");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 39:
                SumEvenOdd();
                break;
            case 40:
                FindMaxMin();
                break;
            case 41:
                FibonacciSequence();
                break;
            case 42:
                ReverseArray();
                break;
            case 43:
                CompareStrings();
                break;
            case 44:
                SumFrom1ToN();
                break;
            case 45:
                SelectionSortDescending();
                break;
            case 46:
                SimpleCalculator();
                break;
            case 47:
                CheckPrimeNumber();
                break;
            case 48:
                SumOfDigits();
                break;
            case 49:
                FindDuplicates();
                break;
            case 50:
                GenerateRandomArray();
                break;
            case 51:
                CelsiusToFahrenheit();
                break;
            case 52:
                CheckPalindrome();
                break;
            case 53:
                CountVowelsConsonants();
                break;
            default:
                Console.WriteLine("Некорректный номер задачи.");
                break;
        }
    }

    static void SumEvenOdd()
    {
        int[] numbers = new int[10];
        int evenSum = 0, oddSum = 0;
        Console.WriteLine("Введите 10 целых чисел:");
        for (int i = 0; i < 10; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            if (numbers[i] % 2 == 0) evenSum += numbers[i];
            else oddSum += numbers[i];
        }
        Console.WriteLine($"Сумма четных чисел: {evenSum}, Сумма нечетных чисел: {oddSum}");
    }

    static void FindMaxMin()
    {
        Console.WriteLine("Введите массив целых чисел (через пробел):");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        int a = numbers.Max();
        int b = numbers.Min();
        Console.WriteLine($"Максимальное: {a}, Минимальное: {b}");
    }

    static void FibonacciSequence()
    {
        Console.WriteLine("Введите количество чисел Фибоначчи:");
        int n = int.Parse(Console.ReadLine());
        int[] fib = new int[n];
        fib[0] = 0;
        if (n > 1) fib[1] = 1;
        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
        Console.WriteLine("Числа Фибоначчи: " + string.Join(", ", fib));
    }

    static void ReverseArray()
    {
        Console.WriteLine("Введите массив целых чисел (через пробел):");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        Array.Reverse(array);
        Console.WriteLine("Массив в обратном порядке: " + string.Join(", ", array));
    }

    static void CompareStrings()
    {
        Console.WriteLine("Введите первую строку:");
        string str1 = Console.ReadLine().ToLower();
        Console.WriteLine("Введите вторую строку:");
        string str2 = Console.ReadLine().ToLower();
        Console.WriteLine(str1 == str2 ? "Строки равны" : "Строки не равны");
    }

    static void SumFrom1ToN()
    {
        Console.WriteLine("Введите число N:");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= n; i++) sum += i;
        Console.WriteLine($"Сумма от 1 до {n}: {sum}");
    }

    static void SelectionSortDescending()
    {
        Console.WriteLine("Введите массив целых чисел (через пробел):");
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        for (int i = 0; i < array.Length - 1; i++)
        {
            int v = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] > array[v])
                    v = j;
            }
            int temp = array[v];
            array[v] = array[i];
            array[i] = temp;
        }
        Console.WriteLine("Отсортированный массив по убыванию: " + string.Join(", ", array));
    }

    static void SimpleCalculator()
    {
        Console.WriteLine("Введите два числа и оператор (+, -, *, /):");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        char op = Console.ReadLine()[0];
        double result = op switch
        {
            '+' => num1 + num2,
            '-' => num1 - num2,
            '*' => num1 * num2,
            '/' => num2 != 0 ? num1 / num2 : double.NaN,
            _ => double.NaN
        };
        Console.WriteLine("Результат: " + result);
    }

    static void CheckPrimeNumber()
    {
        Console.WriteLine("Введите число:");
        int num = int.Parse(Console.ReadLine());
        bool isPrime = num > 1;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0) { isPrime = false; break; }
        }
        Console.WriteLine(isPrime ? "Простое число" : "Не простое число");
    }

    static void SumOfDigits()
    {
        Console.WriteLine("Введите число:");
        int num = Math.Abs(int.Parse(Console.ReadLine()));
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("Сумма цифр: " + sum);
    }

    static void FindDuplicates()
    {
        Console.WriteLine("Введите массив целых чисел (через пробел):");
        int[] numbers = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        var duplicates = numbers.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();
        Console.WriteLine("Дубликаты: " + string.Join(", ", duplicates));
    }

    static void GenerateRandomArray()
    {
        Console.WriteLine("Введите количество случайных чисел:");
        int n = int.Parse(Console.ReadLine());
        Random rand = new Random();
        int[] array = new int[n];
        for (int i = 0; i < n; i++) array[i] = rand.Next(1, 101);
        Console.WriteLine("Случайный массив: " + string.Join(", ", array));
    }

    static void CelsiusToFahrenheit()
    {
        Console.WriteLine("Введите температуру в градусах Цельсия:");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = celsius * 9 / 5 + 32;
        Console.WriteLine("Температура в Фаренгейтах: " + fahrenheit);
    }

    static void CheckPalindrome()
    {
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine().ToLower().Replace(" ", "");
        string reversedStr = new string(str.Reverse().ToArray());
        Console.WriteLine(str == reversedStr ? "Палиндром" : "Не палиндром");
    }

    static void CountVowelsConsonants()
    {
        Console.WriteLine("Введите строку:");
        string str = Console.ReadLine().ToLower();
        int vowels = 0, consonants = 0;
        foreach (char ch in str)
        {
            if ("aeiouауоыиэяюёе".Contains(ch)) vowels++;
            else if (char.IsLetter(ch)) consonants++;
        }
        Console.WriteLine($"Гласные: {vowels}, Согласные: {consonants}");
    }
}