// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double [] CreateArray()
{
    System.Console.WriteLine("Input length array");
    int Length = int.Parse(Console.ReadLine());
    double [] Array = new double[Length];
    for (int i = 0; i < Array.Length; i++)
    {
        Array[i] = new Random().NextDouble()*10;
    }
    return Array;
}
double [] Array = CreateArray();

double Num(string arg)
{
    System.Console.WriteLine($"Input {arg}");
    return double.Parse(Console.ReadLine());
}

double min = Num("min number");
double max = Num("max number");

void PrintArray(double [] Array)
{
    System.Console.Write("[");
    for (int i = 0; i < Array.Length-1; i++)
    {
        System.Console.Write(Array[i] + "; ");
    }
    System.Console.WriteLine(Array[Array.Length -1] + "]");
}
PrintArray(Array);

double GetDifference (double [] Array) 
{
    double min = Array[0];
    double max = Array[0];
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] > max)
        {
            Array[i] = max;
        }
        else if (Array[i] < min)
        {
            Array[i] = min;
        }
    }
    double GetDifference = max - min;
    return GetDifference;
}

System.Console.WriteLine("Difference max and min: " + GetDifference);