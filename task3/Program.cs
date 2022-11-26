/* Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали 
(с индексами (0,0); (1;1) и т.д. */

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

int MainDiagSumm(int[,] array)
{
        int sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
         for (int j = 0; j < array.GetLength(1); j++)
            {
                if(i == j) sum = sum + array[i, j];
            }
        }
    return sum;
}

Console.WriteLine("Введите число m: ");
int m = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);
if(array.GetLength(0) != array.GetLength(1))
    Console.WriteLine("Матирца не симметричная");
else
    Console.WriteLine($"сумма элементов гдавной диагонали равна: {MainDiagSumm(array)}");
