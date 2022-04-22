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
/*
// Вариант 1. Работаем с числом
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
// Вариант 2. Если число положительное, то можно без конвертирования в число, т.к. ввод все равно ввиде строки, или положительное целого число (модуль числа) конвертировать в строку
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

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// Стандарт ISO 8601	Понедельник = 1, Вторник = 2, Среда = 3, Четверг = 4, Пятница = 5, Суббота = 6,	Воскресенье = 7
// За выходные дни недели принимаем дни недели = 6 или 7.
Console.Clear();

string WeekendDayWeek(int num)
{
    if(num < 6)
        return "рабочий день";
    else
        return "выходной день";
}

Console.WriteLine("Введите день недели от 1 до 7:");
int numDay = Convert.ToInt32(Console.ReadLine());
if(numDay < 1 || numDay >7)
    Console.WriteLine(numDay + " не может быть днем недели");
else
    Console.WriteLine(numDay + " -> " + WeekendDayWeek(numDay));
