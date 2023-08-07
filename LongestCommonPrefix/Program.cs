string[] arr_strings2 = { "Jacket", "Joint", "Junky", "Jet" };
System.Console.WriteLine(LongestCommonPrefix(arr_strings2));
string LongestCommonPrefix(string[] args)
{
    string result = args[0];
    var i = result.Length;
    foreach (var word in args)
    {
        var j = 0;
        foreach (var c in word)
        {
            if (c != result[j])
                break;
            j++;
        }
        i = Math.Min(i,j);
    }
    return result.Substring(0,i);
}
