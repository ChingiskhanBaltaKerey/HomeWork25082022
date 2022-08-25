//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19

int[] array = { 3, 7, 23, 12 };
int index = 0;
int size = array.Length;
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine($"array[{i}]: {array [i]}");
}

var even = array.Where((element, index) => index % 2 != 0);

Console.WriteLine("Нечётные. Количество: {0}. Сумма: {1}.", even.Count(), even.Sum());

Console.ReadKey();
