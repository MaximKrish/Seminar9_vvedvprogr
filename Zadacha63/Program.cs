﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежетке от 1 до N


void f(int n)
{
    if (n != 0) // пока n не равна 0
    {
        f(n - 1);
        Console.Write(n + " ");
    }
}

int n = 10;
f(n);