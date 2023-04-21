// Задача 1: ------------------------------------------------------------------------------------------------
//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int CalcToDegree(int number, int n)
// {
//     int result = 1;
//     for (int i = 0; i < n; i++)
//     {
//         result *= number;
//     }
//     return result;
// }

// Console.Write("Enter the number A: ");
// int number1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter the number B ");
// int number2 = Convert.ToInt32(Console.ReadLine());

// int rez = CalcToDegree(number1, number2);
// Console.WriteLine($"Result = {rez}");

// Задача 2: ------------------------------------------------------------------------------------------------
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int SumNumber(int num)
// {
//     int result = 0;
//     while (num > 0)
//     {
//         result += num % 10;
//         num /= 10;
//     }
//     return result;
// }

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// int rez = SumNumber(number);
// Console.WriteLine($"Sum = {rez}");

// Задача 2: ------------------------------------------------------------------------------------------------
// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


// int[] MasCreate(int lengthMas, int minNumber, int maxNumber)
// {
//     int[] mas = new int[lengthMas];
//     for (int i = 0; i < lengthMas; i++)
//     {
//         mas[i] = new Random().Next(minNumber, maxNumber + 1);
//     }
//     return mas;
// }

// void PrintMas(int[] mas)
// {
//     for (int i = 0; i < mas.Length; i++)
//     {
//         Console.Write(mas[i] + " ");
//     }
// }

// Console.Write("Введите размер массива: ");
// int lengthMas = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите min диапазон числа: ");
// int minNumber = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите max диапазон числа: ");
// int maxNumber = Convert.ToInt32(Console.ReadLine());

// int[] array = MasCreate(lengthMas, minNumber, maxNumber);
// PrintMas(array);