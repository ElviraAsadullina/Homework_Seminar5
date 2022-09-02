void FillandPrintArray(int[] array)
{
    Console.WriteLine("Полученный массив: ");
    int N = array.Length;
    for(int index = 0; index < N; index++)
    {
        array[index] = new Random().Next(100, 999 + 1);
        Console.WriteLine(array[index]);
    }
}
Console.WriteLine("Введите количество элементов в Вашем массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int [N];
FillandPrintArray(array);
int count_even = 0;
for(int index = 0; index < N; index++)
    {
        if (array[index] % 2 == 0)
        {
            count_even += + 1;
        }
    }
Console.WriteLine($"Количество четных элементов в массиве: {count_even}");