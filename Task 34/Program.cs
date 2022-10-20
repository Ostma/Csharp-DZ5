// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2




// //метод инициализации массива
int[] InitArray(int demension)
{
    int[] arr = new int[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }

    return arr;
}

//метод, который печатает массив на консоль
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}



int[] arr = InitArray(10);
PrintArray(arr); // Создали массив и напечатали его

int evenCount = 0;
for (int i = 0; i < arr.Length; i++) //проходим массив и в evenCount считаем четные
{
    if (arr[i] % 2 == 0) evenCount ++;
}

Console.WriteLine($"Количество четных = {evenCount}");