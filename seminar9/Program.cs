Console.Clear();

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
/*
// Вариант 1
// M + M+1 + M+2 + M+3 + M+4 ... + N => N*(N-1)/2 - M * (M-1)/2
int SummNaturalNumber(int number)
{
    return number*(number + 1)/2;
}
// Вариант 2
int SummNaturalNumberRecurse(int startNumber, int endNumber)
{
    if(endNumber >= startNumber)
        return startNumber + SummNaturalNumberRecurse(startNumber + 1, endNumber);
    else
        return 0;
}

Console.WriteLine("Введите начальное число M:");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число N:");
int numberN = Convert.ToInt32(Console.ReadLine());
if(numberM < numberN)
{
    Console.WriteLine("Cумма (вариант 1) натуральных числел от {0} до {1} равно: {2}",
                    numberM,
                    numberN,
                    (SummNaturalNumber(numberN) - SummNaturalNumber(numberM - 1)));
    Console.WriteLine("Cумма (вариант 2) натуральных числел от {0} до {1} равно: {2}",
                    numberM,
                    numberN,
                    SummNaturalNumberRecurse(numberM, numberN));
}
else
    Console.WriteLine("Введите число M >= N");
*/
// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// Вариант 1
int SummDigitalNumber(string number)
{
    int result = 0;
    for(int i = 0; i < number.Length; i++)
    {
        result += Convert.ToInt32(number[i].ToString());
    }
    return result;
}

// Вариант 2

int SummDigitNumber(int num)
{    
    int digit = 0;
    while(num > 0)
    {
        digit += num % 10;
        num /= 10;
    }
    return digit;
}

// Вариант 3
int SummDigitNumberRecurse(int num)
{    
    if(num > 0)
        return (num % 10) + SummDigitNumberRecurse(num/10);
    else
        return 0;

}

Console.WriteLine("Введите число:");
string strNumber = Console.ReadLine();
if(String.IsNullOrEmpty(strNumber))
    Console.WriteLine("Ничего не введено");
else
{
    Console.WriteLine("Вариант 1. {0} -> {1}",strNumber, SummDigitalNumber(strNumber));
    int number = Convert.ToInt32(strNumber);
    Console.WriteLine("Вариант 2. {0} -> {1}", number, SummDigitNumber(number));
    Console.WriteLine("Вариант 3. {0} -> {1}", number, SummDigitNumber(number));
}