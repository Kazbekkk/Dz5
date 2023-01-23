/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */

Console.Clear();

Random r = new Random(); int length, summ; // обьявление переменных
length = r.Next(5, 10); // задаем рандомный размер массива

int[] array = gets(length);
Console.WriteLine($"Массив {String.Join(", ", array)}");
Console.Write("Количесво четных чисел в масиве равно "); summEven();


int[] gets(int size) // заполняем массив
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = r.Next(100, 1000 + 1);
    }
    return array;
}

void summEven() // находим сумму количесва четных чисел
{
    summ = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i] % 2 == 0) summ += 1;
    }
    Console.WriteLine(summ);
}


