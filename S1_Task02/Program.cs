﻿//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22


using System;
using static System.Console;

Clear();

Write("Введите первое число: ");
int a = Convert.ToInt32(ReadLine());

Write("Введите второе число: ");
int b = Convert.ToInt32(ReadLine());

Write("Введите третье число: ");
int c = Convert.ToInt32(ReadLine());

int max = a;

if (b > max) max = b;
if (c > max) max = c;

WriteLine(max);