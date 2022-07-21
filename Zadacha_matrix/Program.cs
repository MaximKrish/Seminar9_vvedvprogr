// Проверка на симметричеость матрицы 

int[,] CreateArrayFirst(int m, int n)
{
    int[,] matrix1 = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.Write(matrix1[i, j] + " \t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    return matrix1;
}

void CheckMatrix(int[,] matrix)
{
    bool flag = true;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != matrix[j, i] && i != j) // != означает не равен
            {
                flag = false;
                break;
            }
        }

    }
    if (flag)                                       // if (flag)  - означает сокращенная проверка
        Console.WriteLine("yes");

    else Console.WriteLine("no");
}

CheckMatrix(CreateArrayFirst(3, 3));

// CheckMatrix(CreateArrayFirst(4, 4), CreateArraySecond(4, 4));

// int[,] CreateMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             //int x = Convert.ToInt32(Console.ReadLine());
//             int x = new Random().Next(1, 100);
//             matrix[i, j] = x;
//         }
//     }
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write(matrix[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }

//     return matrix;
// }

// void CheckMatrix(int[,] matrix)
// {
//     bool flag = true;
//     Console.WriteLine();
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (matrix[i, j] != matrix[i, j] && i != j)
//             {
//                 flag = false;
//                 break;
//             }
//         }

//     }
//     if (flag)
//         Console.WriteLine("yes");

//     else Console.WriteLine("no");

// }


