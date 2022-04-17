/*
// Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num2 > num1)
{
    Console.WriteLine("Второе число больше первого: " + num2 + " > " + num1);
}
else
{
    if(num2 == num1)
    {
        Console.WriteLine("Числа равны: " + num2 + " = " + num1);
    }
    else
    {
        Console.WriteLine("Первое число больше второго: " + num1 + " > " + num1);
    }
}
*/
/*
// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num2 > max)
    max = num2;
if(num3 > max)
    max = num3;

Console.Write("Из чисел: " + num1 + ", " + num2 + ", " + num3 + " -> максимальное " + max);
*/
/*
//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = num % 2;

if(result == 0)
    Console.Write("Число: " + num + " -> четное");
else
    Console.Write("Число: " + num + " -> нечетное");
*/
/*
// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Clear();
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int count = 0;
int result = 0;
if(num <= -2)
{
    count = -2;
    result = count;
    Console.Write("Четные числа до " + num + " -> " + count);
    result += count;
    while(result >= num)
    {
        Console.Write(", " + result);
        result += count;
    }
}
if(num >= 2)
{
    count = 2;
    result = count;
    Console.Write("Четные числа до " + num + " -> " + count);
    result += count;
    while(result <= num)
    {
        Console.Write(", " + result);
        result += count;
    }
}
if(count == 0)
{
    Console.Write("До числа " + num + " нет четных чисел от 0");
}
*/