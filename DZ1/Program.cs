/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.Write("Введите число: ");
int Num = int.Parse(Console.ReadLine()!);

Console.WriteLine(NaturalNumbers(Num));

string NaturalNumbers(int Num)
{
    if (Num == 1)
        return "1";

    return Num + " , " + NaturalNumbers(Num - 1);
}