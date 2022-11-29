// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int ConvertArrayInt(string[] arr)
{
    int[] array = new int[arr.Length];
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(arr[i]);

        if(array[i] > 0) count++;
    }
    return count;
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

Console.Write("Введите числа через запятую: ");
string[] numbers = Console.ReadLine().Split(',');
PrintArray(numbers);
Console.WriteLine($"Цифр больше нуля: {ConvertArrayInt(numbers)}");



