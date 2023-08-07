var array = new[] {1,2,2,2,1};
Console.WriteLine(IsUnique(array));
static bool IsUnique(int[] arr)
{
    //Counter Dictionary
    Dictionary<int, int> keyValues = new Dictionary<int, int>();
    foreach (var num in arr)
    {
        if(keyValues.ContainsKey(num))
            keyValues[num]++;
        else
            keyValues[num] = 1;
    }
    //Check if duplicate values of counters
    HashSet<int> countersValue = new HashSet<int>(keyValues.Values);
    return countersValue.Count == keyValues.Count;
}