/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
 и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */

int[,] InitArray(int m,int n)
{
    Random rnd = new Random();
    int[,] array = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i,j] = rnd.Next(0, 10);
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


Console.WriteLine("Введите размер m: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите размер n: ");
int n = int.Parse(Console.ReadLine());
int[,] array = InitArray(m,n);
PrintArray(array);

Console.WriteLine("Введите номер строки искомого элемента: ");
int strToPrint = int.Parse(Console.ReadLine());
Console.WriteLine("Введите номер столбца искомого элемента: ");
int colToPrint = int.Parse(Console.ReadLine());
if(array.GetLength(0) - 1 < strToPrint || array.GetLength(1) - 1 < colToPrint)
    {
        Console.WriteLine("Элемента с такими индексами нет");
        /*Console.WriteLine($"{array.GetLength(0)} {strToPrint}");
        Console.WriteLine($"{array.GetLength(1)} {strToPrint}");*/
    }
else
    Console.WriteLine($"элемент с индексами [{strToPrint}, {colToPrint}] равен: {array[strToPrint, colToPrint]}");