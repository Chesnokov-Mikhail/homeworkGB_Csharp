// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

void SecondDigitThreeNumber(int num)
{
    int hundr = num%100;
    Console.WriteLine("Вторая цифра числа:");
    Console.Write(num + " -> " + hundr/10);
}

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
SecondDigitThreeNumber(number);