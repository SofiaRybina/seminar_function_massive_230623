// Задача 32: Напишите программу замена элементов
// массива: положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int size = Prompt("Input massive size: ");
int random_min = Prompt("Input random_min: ");
int random_max = Prompt("Input random_max: ");
int[] array = GetArray(size, random_min, random_max);
Console.Write("Massive:    ");
PrintArray(array);
Console.Write("Massive new:");
Replace(array);

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int number = Convert.ToInt32(Console.ReadLine()!);
    return number;
}

int[] GetArray(int size, int random_min, int random_max) //создаём и заполняем массив случайными числами
{
    int[] result = new int[size]; //проинициализировали массив, задали размер
    for(int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(random_min, random_max + 1);
    }
    return result;
}

void PrintArray(int[] array) //вывод массива
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.Write("]");
    Console.WriteLine();
}

void Replace(int[] array)
{
    Console.Write("[");
    foreach(int el in array)
    {
        Console.Write($"{el*(-1)} ");
    }
    Console.Write("]");
}