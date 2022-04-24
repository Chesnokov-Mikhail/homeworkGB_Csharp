// Задача 19. Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.

Console.Clear();

string Palindrom(int num)
{
    string res = "да";   
    int[] digitarray = new int[5];

    for(int i = 0; i < digitarray.Length; i++)
    {
        digitarray[i] = num % 10;
        num /= 10;
    }
    for(int i = 0; i < (digitarray.Length/2); i++)
    {
        if(digitarray[i] != digitarray[digitarray.Length - 1 - i])
        {
            res = "нет";
            break;
        }
    }
    return res;
}

Console.WriteLine("Введите пятизначное число:");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(number + " -> " + Palindrom(number));