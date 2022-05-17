Console.Clear();

void PrintDoubleMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,-6:f2} ", matrix[i,j]);
        }
        Console.WriteLine();
    }
}

void PrintDoubleArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,-6:f2} ", arr[i]);
    }
}

void PrintIntMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,-6} ", matrix[i,j]);
        }
        Console.WriteLine();
    }
}

double[,] CreateDoubleMatrix(int row, int col, int minRange, int maxRange)
{
    double[,] matrix = new double[row,col];
    Random newrandom = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = minRange + newrandom.NextDouble()*(maxRange - minRange);
        }
    }
    return matrix;
}

int[,] CreateIntMatrix(int row, int col, int minRange, int maxRange)
{
    int[,] matrix = new int[row,col];
    Random newrandom = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = newrandom.Next(minRange,maxRange + 1);
        }
    }
    return matrix;
}

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*

Console.WriteLine("Введите количество строк массива:");
int sizeM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива:");
int sizeN = Convert.ToInt32(Console.ReadLine());
PrintDoubleMatrix(CreateDoubleMatrix(sizeM, sizeN, -10, 10));
*/
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
bool IsElementOfIndex(int[,] matrix, int row, int col)
{
    if(matrix.GetLength(0) > row && matrix.GetLength(1) > col)
        return true;
    return false;
}

int[,] newMatrix = CreateIntMatrix(3, 4, -10, 10);
Console.WriteLine("Задан массив:");
PrintIntMatrix(newMatrix);
Console.WriteLine("Введите позицию элемента массива [строка, столбец]:");
string strIndexElementMatrix = Console.ReadLine().Replace("[","").Replace("]","");
if (String.IsNullOrEmpty(strIndexElementMatrix))
    Console.WriteLine("Введена пустая строка");
else if(strIndexElementMatrix.IndexOf(",") != -1)
{
    string[] index = strIndexElementMatrix.Split(',');
    int row = Convert.ToInt32(index[0]);
    int col = Convert.ToInt32(index[1]);
    Console.Write("Элемент массива[{0}, {1}]", row, col);
    if(IsElementOfIndex(newMatrix, row, col))
        Console.Write(" => {0}", newMatrix[row, col]);
    else
        Console.Write(" => такого числа в массиве нет");
}
else
{
    Console.WriteLine("Введите позицию элемента массива");
}
*/
// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

double[] ArithmeticMeanColMatrix(int[,] matrix)
{
    double[] arithmeticMean = new double[matrix.GetLength(1)];
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticMean[j] += matrix[i,j];
        }
        arithmeticMean[j] /= matrix.GetLength(0);
    }
    return arithmeticMean;
}

int[,] newMatrix = CreateIntMatrix(5, 4, 0, 10);
Console.WriteLine("Задан массив:");
PrintIntMatrix(newMatrix);
double[] arifmArray = ArithmeticMeanColMatrix(newMatrix);
Console.Write("Среднее арифметическое каждого столбца:");
PrintDoubleArray(arifmArray);
