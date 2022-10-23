Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите наименьшее значение массива: ");
int minValue = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите наибольшее значение массива: ");
int maxValue = int.Parse(Console.ReadLine() ?? "");


int[] array = GetArray(size, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
FindInArray(array);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void FindInArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum++;
    }
    Console.WriteLine($"Кол-во чисел больше 0: {sum}");
}
