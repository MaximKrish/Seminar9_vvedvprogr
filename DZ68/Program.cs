
int A(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return A(m - 1, 1);
    if (m > 0 && n > 0)
        return A(m - 1, A(m, n - 1));
    return A(m, n);
}

Console.WriteLine("Введите чило M ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите чило N ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(A(m, n));