// Напишите программу, которая на вход принимает два число А и В, и возводит число А в целую степень В с помощью рекурсии

int f(int a, int b)
{
    if (b == 0)
        return 1;
    return f(a, b - 1) * a;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.Write(f(a, b));
