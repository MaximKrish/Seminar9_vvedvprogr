// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N

int f(int m, int n)
{
    if (n == m)
        return n;
    return f(m, n - 1) + n;
}
Console.WriteLine("M должно быть меньше N ");
Console.WriteLine("Введите чило M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(f(m, n));