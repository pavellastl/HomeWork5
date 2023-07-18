Console.Clear();
int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minvalue, maxvalue + 1);
    }
    return res;
}
int EvenAmount(int[] array)
{
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if(array[i] % 2 == 0)
    {
        count++;
    }
}
return count;
}
int[] array = GetArray(4, 100, 1000);
Console.WriteLine(string.Join($", ", (array)));
int amount = EvenAmount(array);
Console.WriteLine($"Число четных чисел в массиве = {amount}");

