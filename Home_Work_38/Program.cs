/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */
Console.Clear();

Random r = new Random(); int length, minNum, maxNum, difference, numm;
length = r.Next(5, 10 + 1);
Console.WriteLine($"Размер массива равен {length}");
int[] array = kit(length);
int distinction = dif(length);
Console.WriteLine($"Разница между максимальным и минимальным значением массива [{String.Join(", ", array)}], равна {distinction}");

int[] kit(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        numm = r.Next(0, 100 + 1);
        arr[i] = numm;
    }
    return arr;
}

int dif(int length)
{
    maxNum = 0;
    for (int i = 0; i < length; i++) // нахождение максимального числа
    {
        if (array[i] > maxNum) maxNum = array[i];
    }

    minNum = maxNum; // присваиваем значение макс к мин и находим минимальное значение 
    for (int i = 0; i < length; i++)
    {
        if (array[i] < minNum) minNum = array[i];
    }

    difference = maxNum - minNum;
    return difference;
}