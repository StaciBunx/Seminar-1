//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int n = Convert.ToInt32(ReadLine());

int currentN = 1;

while (currentN <= n)
{
    if (currentN % 2 == 0)
    { 
        Write($"{currentN} ");
    }
    currentN++;
}
