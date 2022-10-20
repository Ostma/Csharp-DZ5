// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Не совсем понятно, почему именно ВЕЩЕСТВЕННЫЕ числа, выберем 0...99



//метод инициализации массива
int[] InitArray(int demension)
{
    int[] arr = new int[demension];

    Random rnd = new Random();

    for (int i = 0; i < demension; i++)
    {
        arr[i] = rnd.Next(0, 100);
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

//метод, который находит макс
int MaxOfElements(int[] array)
{
int maxNum = array[0];
for (int i = 0; i < array.Length; i++)
{
if(array[i] > maxNum) maxNum = array[i];
}
return maxNum;
}

//метод, который находит мин
int MinOfElements(int[] array)
{
int minNum = array[0];
for (int i = 0; i < array.Length; i++)
{
if(array[i] < minNum) minNum = array[i];
}
return minNum;
}


int[] arr = InitArray(10);
PrintArray(arr); // Создали массив и напечатали его


Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {MaxOfElements(arr) - MinOfElements(arr)}");