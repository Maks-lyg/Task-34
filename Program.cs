int Hou(int[] ar)
{
    
    int count = 0;
    for (int i = 0; i < ar.Length; i++)
    {
        if (ar[i] % 2 == 0) // я тут что только не менял, туплю, застрял на месте
        {
            count +=1;
        }
    }
    return count;
}
int[] Array(int size)
{
    int[] array = new int[size];
    for (int i = 0;i < size; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
    return array;
}


Console.Clear();
Console.WriteLine("Введите разрядность массива");
int size = int.Parse(Console.ReadLine());
int[] mass = Array(size);
int s = Hou(ar);//не видит переменную, менял и на переменные. Вывод именно count делал(ну а вдруг)))) 
Console.Write($"чч - {s} ");
Console.Write($" {String.Join(", ", mass)} ");
