int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0;i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}
int Hou(int[] a)
{
    
    int count = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] % 2 ==0)
        {
            count +=1;
        }
    }
    return count;
}

Console.Clear();
Console.WriteLine("Введите разрядность массива");
int size = int.Parse(Console.ReadLine());
int[] mass = Array(size);
int x = Hou(a);
Console.Write($" {String.Join(", ", mass)} ");
Console.Write($"Кол-во ч чисел = {x}");