// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Clear();

double PowerNumber(double numA, int numB)
{
    return Math.Pow(numA, numB);
}

Console.WriteLine("Введите число, основание степени:");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите натуральное число, показатель степени:");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Число {0:f2} в степени {1} равно {2:f2}", numberA, numberB, PowerNumber(numberA, numberB));
*/
/*
// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();

int SummDigitalNumber(int num)
{    
    int summ = 0;
    while(num > 0)
    {
        summ += num % 10;
        num /= 10;
    }
    return summ;
}

Console.WriteLine("Введите натуральное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр в числе {0} равно {1}", number, SummDigitalNumber(number));
*/

// Задача 3: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();

void PrintArrayInt(int[] arr)
{
    Console.Write("[");
    for(int i = 0; i < (arr.Length - 1); i++)
    {
        Console.Write("{0}, ", arr[i]);
    }
    Console.Write(arr[arr.Length - 1]);
    Console.Write("]");
}

int[] CreateArrayInt(int len, int min, int max)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(min, (max + 1));
    }
    return arr;
}

PrintArrayInt(CreateArrayInt(8,0,10));