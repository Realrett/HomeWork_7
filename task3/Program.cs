/*Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int[,] InitArray(int m,int n)
{
    Random rnd = new Random();
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintColumnAverageVAlues(int[,] array,  int n, int m)
{
    double[] aver = new double[n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            aver[j] = aver[j] + array[i,j];
        }
    }
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < n; i++)
    {
        aver[i] = Math.Round(aver[i] / m, 2);
        if(i != n-1) Console.Write($"{aver[i]}; ");
        else Console.Write($"{aver[i]}.");
    }
}

Console.WriteLine("Введите размер m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);
PrintColumnAverageVAlues(array, n, m);
