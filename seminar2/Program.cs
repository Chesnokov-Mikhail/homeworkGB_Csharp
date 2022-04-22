/*
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
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// Вариант 1. Без конвертирования в число, т.к. ввод все равно ввиде строки, или целое число конвертировать в строку
/*
Console.Clear();

Console.WriteLine("Введите трёхзначное число:");
string strNumber = Console.ReadLine();
// метод int.TryParse нашел на https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isnumber?view=net-6.0#system-char-isnumber(system-char)
if(strNumber.Length >= 3 && int.TryParse(strNumber, out int number))
    Console.WriteLine(strNumber + " -> " + strNumber[2]);
else
    Console.WriteLine("Введённое не число или не трёхзначное число!");
*/
/*
// Вариант 2. Работаем с числом
Console.Clear();

int ThreeDigitNumber(int num)
{
    if(num/100 == 0)
    return -1; // нет цифры в таком номере позиции числа
    
    int[] digitarray = new int[3];
    int i = 0;

    while(num > 0)
    {
        if(i > 2)
        {
            i = 2;
            for(int j = 0; j < 2; j++)
                digitarray[j] = digitarray[j+1];
        }   
        digitarray[i] = num % 10;
        num /= 10;
        i++;
    }
    return digitarray[0];
}

Console.WriteLine("Введите трёхзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
int three = ThreeDigitNumber(number);
if(three < 0)
    Console.WriteLine(number + " -> третьей цифры нет");
else
{
    Console.WriteLine("Третья цифра числа:");
    Console.WriteLine(number + " -> " + three);
}
*/