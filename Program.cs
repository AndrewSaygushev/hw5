// TASK 34

/*int[] GetRandomArray (int length, int min, int max)

{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int GetNumberArray (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

int[] EndArray = GetRandomArray(10, 100, 1000);
PrintArray(EndArray);
Console.WriteLine();
int count = GetNumberArray(EndArray);
Console.WriteLine($"The number of even numbers in the array - {count}. ");*/


// TASK 36

/*int[] GetRandomArray (int length, int min, int max)

{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

int GetSumNumberIndex (int[] array)
{
    int Sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            Sum += array[i]; 
        }
    }
    return Sum;
}

int[] EndArray = GetRandomArray(10, 1, 1500);
PrintArray(EndArray);
Console.WriteLine();
int Summa = GetSumNumberIndex(EndArray);
Console.WriteLine($"The sum of the elements standing in odd positions - {Summa}. ");*/


// TASK 38

double[] GetRandomArray (int length, int min, int max)

{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray (double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
}

double MinimumNumberArray (double[] array)
{
    double minimum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minimum)
        {
            minimum = array[i];
        }
    }
    return minimum;
}

double MaximumNumberArray (double[] array)
{
    double maximum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maximum)
        {
            maximum = array[i];
        }
    }
    return maximum;
}

double DifferenceBetweenNumbers (double maximum, double minimum)
{
    double dif = maximum - minimum;
    return dif;
}

double[] EndArray = GetRandomArray(10, 1, 1500);
PrintArray(EndArray);
Console.WriteLine();
double MaxNumber =  MaximumNumberArray(EndArray);
double MinNumber =  MinimumNumberArray(EndArray);
double Difference = DifferenceBetweenNumbers(MaxNumber, MinNumber);
Console.WriteLine($"The difference between min and max - {Difference}");
