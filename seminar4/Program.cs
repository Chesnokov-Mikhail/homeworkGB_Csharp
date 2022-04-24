/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

string PrintArrayInt(int[] arr)
{
    string res = "[";
    for(int i = 0; i < (arr.Length - 1); i++)
    {
        res += Convert.ToString(arr[i]) + ", ";
    }
    res += Convert.ToString(arr[arr.Length - 1]);
    res += "]";
    return res;
}

int NumberEvenNumbers(int[] numbersArray)
{
    int count = 0;
    for(int i = 0; i < numbersArray.Length; i++)
    {
        if(numbersArray[i] % 2 == 0)
            count += 1;
    }
    return count;
}
Console.WriteLine("Введите размер массива трехзначных чисел:");
int countArray = Convert.ToInt32(Console.ReadLine());
int[] numbersArray = new int[countArray];
for(int i =0; i < countArray; i++)
{
    numbersArray[i] = new Random().Next(100, 1000);
}
Console.WriteLine("{0} -> {1}", PrintArrayInt(numbersArray), NumberEvenNumbers(numbersArray));
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

string PrintArrayInt(int[] arr)
{
    string res = "[";
    for(int i = 0; i < (arr.Length - 1); i++)
    {
        res += Convert.ToString(arr[i]) + ", ";
    }
    res += Convert.ToString(arr[arr.Length - 1]);
    res += "]";
    return res;
}

int SummEvenIndex(int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    return sum;
}

int[] GenerateNumArray(int[] array, int range)
{
    for(int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next((-1 * range), (range + 1));
    }
    return array;
}

Console.WriteLine("Введите размер массива для заполнения случайными числами:");
int countArray = Convert.ToInt32(Console.ReadLine());
int[] numbersArray = new int[countArray];
numbersArray = GenerateNumArray(numbersArray,100);
Console.WriteLine("{0} -> {1}", PrintArrayInt(numbersArray), SummEvenIndex(numbersArray));