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
int OddPlaceSum(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        summ = summ + array[i];
    }
    return summ;
}
int[] array = GetArray(4, 0, 1000);
Console.WriteLine(string.Join(", ", array));
int summ = OddPlaceSum(array);
Console.WriteLine($"Сумма чисел, стоящих на нечетных местах = {summ}");