void CreateNaturalArray(int[] array)
{
    Console.WriteLine("Укажите верхнюю границу случайного диапазона для массива: ");
    int r = Convert.ToInt32(Console.ReadLine());
    if(r < 0)
    {
        r = r * -1;
    }
    int N = array.Length;
    Console.WriteLine("Массив из случайных натуральных чисел: ");
    for(int i = 0; i < N; i++)
    {
        array[i] = new Random().Next(1, r);
        Console.WriteLine(array[i]);
    }
}
Console.WriteLine("Введите количество элементов в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] nums = new int [N];
CreateNaturalArray(nums);
int max = 0;
for(int index = 0; index < N; index++ )
{
    if(nums[index] > max)
    {
        max = nums[index];
    }
}
int min = max;
for(int index = 0; index < N; index++ )
{
    if(nums[index] < min)
    {
        min = nums[index];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {max-min}");