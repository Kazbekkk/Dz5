/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */
Console.Clear();

Random r = new Random(); int size, num, summ;

size = r.Next(5, 10 + 1);
Console.WriteLine("Размер массива: {0}", size);
int[] array = dok(size);
summ = sumOdd(size);

Console.WriteLine($"Сумма элементов массива [{String.Join(", ", array)}], стоящих на нечётных позициях равна = {summ}");


int[] dok(int size) // массив
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        num = r.Next(0, 100 + 1);
        arr[i] = num;
    }
    return arr;
}

int sumOdd(int size)
{
    summ = 0;
    for (int i = 0; i < size; i++)
    {
        if (i % 2 != 0) summ += array[i];
    }
    return summ;
}

