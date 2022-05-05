/*
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.Clear();

// Вариант 1. Считываем до тех пор пока вводят числа
string strNumber;
int intNumber;
int count = 0; // счетчик чисел больше 0
do
{
    Console.WriteLine("Введите число:");
    strNumber = Console.ReadLine();
    if(strNumber != string.Empty)
        {
            intNumber = Convert.ToInt32(strNumber);
            if(intNumber > 0)
                count++;
        }
} while (strNumber != string.Empty);

Console.WriteLine("Количество чисел больше 0, равно: {0}", count);
*/
/*
// Вариант 2. Считываем до тех пор пока не введут известное М число чисел
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

int CountPositive(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0)
            count++;
    }
    return count;
}

Console.WriteLine("Введите сколько будет чисел:");
int numM = Convert.ToInt32(Console.ReadLine());
int[] arrNum = new int[numM];
for(int i = 0; i < numM; i++)
{
    Console.WriteLine("Введите {0} число:", (i + 1));
    arrNum[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("{0} -> {1}", PrintArrayInt(arrNum), CountPositive(arrNum));
*/
/*
// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
Console.Clear();

string ConvertIntToBin(int num)
{
    string numBin = string.Empty;
    int ostatok = 0;
    do
    {
        ostatok = num % 2;
        num /= 2;
        numBin = Convert.ToString(ostatok) + numBin;
    }
    while(num > 0);
    return numBin;
}

Console.WriteLine("Введите число:");
int numDec = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("{0} -> {1}", numDec, ConvertIntToBin(numDec));
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

(double, double) GetIntersectionPointOfLines(double k1, double b1, double k2, double b2)
{
    double x;
    double y;
    x = (b2 - b1)/(k1 - k2);
    y = (k1 * b2 - k2 * b1)/(k1 - k2);
    return (x,y);
}

Console.WriteLine("Введите число k1 из y = k1 * x + b1:");
double numk1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b1 из y = k1 * x + b1:");
double numb1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2 из y = k2 * x + b2:");
double numk2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2 из y = k2 * x + b2:");
double numb2 = Convert.ToInt32(Console.ReadLine());
(double x, double y) pointTuple = GetIntersectionPointOfLines(numk1,numb1,numk2,numb2);
Console.WriteLine($"Для прямых y = {numk1}*x + {numb1} и y = {numk2}*x + {numb2}");
Console.WriteLine($"точка пересечения имеет координаты (x ; y): ({pointTuple.x} ; {pointTuple.y})");