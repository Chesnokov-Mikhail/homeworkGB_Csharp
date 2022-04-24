
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