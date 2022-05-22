// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по возрастанию элементы каждой строки двумерного массива.

Console.Clear();
// передача параметров ссылкой https://docs.microsoft.com/ru-ru/dotnet/csharp/programming-guide/classes-and-structs/passing-reference-type-parameters
void PrintIntArray(ref int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("{0,-6} ", arr[i]);
    }
    Console.WriteLine();
}
void PrintIntMatrix(ref int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("{0,-6} ", matrix[i,j]);
        }
        Console.WriteLine();
    }
    Console.WriteLine();
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
/*
// вместо сортировки мотодом "пузырька" используется алгоритм быстрой сортировки,
// где в качестве базового элемента берется крайний правый элемент массива
void QuickSortRow(ref int[,] matrix, int numRow, int low, int high)
{
    int lowInit = low;
    if(low < high)
    {
        int valueInit = matrix[numRow, high];
        int temp;
        for(int i = lowInit; i < high; i++)
        {
            if(matrix[numRow, i] < valueInit)
            {
                if(i > low)
                {
                    temp = matrix[numRow,low];
                    matrix[numRow,low] = matrix[numRow,i];
                    matrix[numRow,i] = temp;
                    low += 1;
                }
                else
                    low += 1;
            }
        }
        temp = matrix[numRow,low];
        matrix[numRow,low] = matrix[numRow,high];
        matrix[numRow,high] = temp;
        QuickSortRow(ref matrix, numRow, lowInit, low -1);
        QuickSortRow(ref matrix, numRow, low+1, high);
    }
}

void SortAscendingRowMatrix(ref int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        QuickSortRow(ref matrix, i, 0, matrix.GetLength(1) - 1);
    }
}

int[,] newMatrix = CreateIntMatrix(3, 4, -10, 10);
Console.WriteLine("Задана матрица:");
PrintIntMatrix(ref newMatrix);
Console.WriteLine("Отсортированная матрица:");
SortAscendingRowMatrix(ref newMatrix);
PrintIntMatrix(ref newMatrix);

*/
// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
/*
int FindMinimumItem(ref int[] arr)
{
    int numMin = arr[0];
    int indexNumMin = 0;
    for(int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < numMin)
        {
            numMin = arr[i];
            indexNumMin = i;
        }
    }
    return indexNumMin;
}

int[] SummItemRowMatrix(ref int[,] matrix)
{
    int [] rowSummArray = new int[matrix.GetLength(0)];
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            rowSummArray[i] += matrix[i,j];
        }
    }
    return rowSummArray;
}

int[,] newMatrix = CreateIntMatrix(4, 4, -10, 10);
Console.WriteLine("Задана матрица:");
PrintIntMatrix(ref newMatrix);
int[] arrayMinimumSumm = SummItemRowMatrix(ref newMatrix);
Console.WriteLine("Массив сумм элементов строк матрицы:");
PrintIntArray(ref arrayMinimumSumm);
int numRowMinimumSumm;
numRowMinimumSumm = FindMinimumItem(ref arrayMinimumSumm);
Console.WriteLine("номер строки матрицы с наименьшей суммой элементов: {0} строка", (numRowMinimumSumm + 1));

*/
// Задача 62. Заполните спирально массив 4 на 4.

int[,] CreateIntSpiralMatrix(int row, int col)
{
    int[,] matrix = new int[row,col];
    int item = 1;
    int cicle = 0;
    for (int iTop = 0; iTop < matrix.GetLength(0) - cicle; iTop++)
    {
        for (int jTop = 0 + cicle; jTop < matrix.GetLength(1) - cicle; jTop++)
        {
            matrix[iTop,jTop] = item;
            item += 1;
        }
        for (int iRight = 1 + cicle; iRight < matrix.GetLength(0) - cicle; iRight++)
        {
            matrix[iRight,matrix.GetLength(1) - 1 - cicle] = item;
            item += 1;
        }
        for (int jBottom = matrix.GetLength(1) - 2 - cicle; jBottom > cicle; jBottom--)
        {
            matrix[matrix.GetLength(0) - 1 - cicle, jBottom] = item;
            item += 1;
        }
        for (int iLeft = matrix.GetLength(0) - 1 - cicle; iLeft > cicle; iLeft--)
        {
            matrix[iLeft,cicle] = item;
            item += 1;
        }
        cicle += 1;
    }
    return matrix;
}

int[,] newMatrix = CreateIntSpiralMatrix(4, 4);
Console.WriteLine("Матрица со спиральным заполнением элементов:");
PrintIntMatrix(ref newMatrix);