// Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

//Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

//двумерный массив с случайным вводом (универсальный)
int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)  //или rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    //или columns
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

//вывод массива на экран (универсальный)
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  //или rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++)    //или columns
        {
            Console.Write($"{matrix[i, j],5}");  //5 это чтобы разделять числа
        }
        Console.WriteLine();
    }
}

//нахождение суммы каждой строки двумерного массива
int[] SumRowsMatrix(int[,] matrix)
{
    int[] sumRowsMatrix = new int[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRowsMatrix[i] += matrix[i, j];
        }
    }
    return sumRowsMatrix;
}

//нахождение индекса минимального элемента одномерного массива
int MinIndexElementArray (int[] arr)
{
    int min=arr[0]; 
    int k=1;
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i]<min)  
        {
            min=arr[i];
            k=i+1;
        }
    }
    return k;
}

//вывод массива на экран (универсальный)
void PrintArray(int[] arr, string sep = ",")
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}{sep} ");
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
}


int[,] array2d = CreateMatrixRndInt(3, 4, 0, 10);
PrintMatrix(array2d);
Console.WriteLine();

int[] sum = SumRowsMatrix(array2d);
PrintArray(sum);
Console.WriteLine();

int minIndexElementArray=MinIndexElementArray(sum);
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minIndexElementArray}");
