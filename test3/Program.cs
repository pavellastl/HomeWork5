Console.Clear();

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ");
    int[] res = new int[nums.Length];
    for (int i = 0; i < nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

int MaxMinDifferense(int[] array)
{
    int max = array[0];
    int min = array[0];
    int diff = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(max>array[i+1])
        {
            max = array[i]+1;
        }
        if(min< array[i+1])
        {
            min = array[i+1];
        }
        
        
    }
        diff = max - min;
        return diff;
    
    
}
Console.WriteLine("Введите числа через пробел");
string arr = Console.ReadLine();
int[] baseArr = GetArrayFromString(arr);
int difference = MaxMinDifferense(baseArr);
Console.WriteLine(difference);