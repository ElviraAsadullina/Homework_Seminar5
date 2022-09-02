void FillandPrintArray(int[] array)
{
    Console.WriteLine("Массив из случайных чисел: ");
    int N = array.Length;
    for(int i = 0; i < N; i++)
    {
        array[i] = new Random().Next();
        Console.WriteLine(array[i]);
    }
}
Console.WriteLine("Введите количество элементов в Вашем массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] column = new int [N];
FillandPrintArray(column);
int sum_proper_elements = 0;
for(int i = 1; i < N; i = i + 2)
{
    if(column[i] % 2 == 0)
    {
        sum_proper_elements += column[i];
    }
}
Console.WriteLine($"Сумма четных элементов с нечетной позицией: {sum_proper_elements}");