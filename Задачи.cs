/*Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/
/*
int CountPositiveNumber (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

Console.WriteLine("Введите любые + и - целые числа(через пробел): ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int result = CountPositiveNumber (array);
Console.WriteLine($"Количество чисел больше 0 = {result}");
*/
/*
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5) */

void IntersectionPoint (double k1, double b1, double k2, double b2)
{
    // k1 * x + b1 = k2 * x + b2
    // k1x - k2x = b2 - b1
    // x = -(b1 - b2)/(k1-k2)
    // 5x + 2 = 9x + 4
    // -4x = 2; x = 2/-4
    double x = -(b1 - b2) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Пересечение в точке: ({x};{y})");
}

Console.WriteLine("Введите k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
IntersectionPoint (k1, b1, k2, b2);
 

 

