System.Console.WriteLine(CheckIfPalindrom("123454321"));
CheckIfIntPalindrom(10);
bool CheckIfPalindrom(string text)
{
    if (text.Length <= 1)
    {
        return true;
    }
    if (text[0] != text[text.Length - 1])
    {
        return false;
    }
    return CheckIfPalindrom(text.Substring(1, text.Length - 2));
}
void CheckIfIntPalindrom(int num)
{
}