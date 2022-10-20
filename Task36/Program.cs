// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0



// метод инициализации массива
int[] InitArray(int demension)
{
    int[] arr = new int[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(-100, 101); // В условии не сказан диапазон, зададим вилку -100...100
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



int[] arr = InitArray(10); //В условии не сказан размер, зададим 10
PrintArray(arr); // Создали массив и напечатали его

int oddSumm = 0;
for (int i = 0; i < arr.Length; i++) //проходим массив и в oddSumm суммируем, содержимое нечетных
{
    if ( i % 2 == 0) oddSumm = oddSumm + arr[i];
}

Console.WriteLine($"Сумма нечетных элементов = {oddSumm}");
