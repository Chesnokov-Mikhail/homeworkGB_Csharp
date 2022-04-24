/*
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
*/

// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Console.Clear();

string PrintArrayDouble(double[] arr)
{
    string res = "(";
    for(int i = 0; i < (arr.Length - 1); i++)
    {
        res += Convert.ToString(arr[i]) + ", ";
    }
    res += Convert.ToString(arr[arr.Length - 1]);
    res += ")";
    return res;
}

double DistanceAB(double[] pA, double[] pB)
{
    return Math.Sqrt(Math.Pow(pB[0] - pA[0],2) + Math.Pow(pB[1] - pA[1],2) + Math.Pow(pB[2] - pA[2],2));
}

double[] pointA = new double[3];
double[] pointB = new double[3];

Console.WriteLine("Введите координату X первой точки в пространстве:");
pointA[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки в пространстве:");
pointA[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки в пространстве:");
pointA[2] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X второй точки в пространстве:");
pointB[0] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y второй точки в пространстве:");
pointB[1] = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Z второй точки в пространстве:");
pointB[2] = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("A {0}; B {1} -> {2:f2}", PrintArrayDouble(pointA), PrintArrayDouble(pointB), DistanceAB(pointA,pointB));