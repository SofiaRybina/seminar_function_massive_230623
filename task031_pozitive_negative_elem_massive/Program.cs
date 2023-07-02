// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна
// -20.

int size = Prompt("Input massive size: ");
int random_min = Prompt("Input random_min: ");
int random_max = Prompt("Input random_max: ");
int [] array = GetArray(size, random_min, random_max);
PrintArray(array);
GetSum(array);
/*
//альтернативное написание, вывод через элементы массива
int[]resSum = GetSum(array);
PrintArray(array);
Console.WriteLine();

*/
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
        //Console.Write($"{result[i]} ");
    }
    return result;
}

void PrintArray(int[] array) //вывод массива
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    
    ////то же самое, но через foreach
    // foreach(int el in array)
    // {
    //     Console.Write($"{el} ");
    // }
}

void GetSum(int[] array)
{
    int pozitiveSum = 0;
    int negativeSum = 0;

    foreach(int el in array)
    {
        if(el > 0) pozitiveSum += el; //pozitiveSum = pozitiveSum + el
        if(el < 0) negativeSum += el; //negativeSum = negativeSum + el
    }
    Console.WriteLine($"Сумма положительных чисел: {pozitiveSum}, Сумма отрицательных чисел: {negativeSum}");
}
/*
//**альтернативное написание, вывод итога через два элемента массива
int GetSum(int[] array)
{
    int[] result = new int[2];

    foreach(int el in array)
    {
        if(el > 0) pozitiveSum += el; //pozitiveSum = pozitiveSum + el
        if(el < 0) negativeSum += el; //negativeSum = negativeSum + el
    }
    return result;
}
*/