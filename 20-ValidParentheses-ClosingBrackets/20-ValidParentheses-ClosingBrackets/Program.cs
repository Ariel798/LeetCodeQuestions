Queue<int> curlyBrackets = new Queue<int>();
Queue<int> brackets = new Queue<int>();
Queue<int> rectangularBrackets = new Queue<int>();
var s = "({})";
Console.WriteLine(validParenthesis(s));
bool validParenthesis(string s)
{
    foreach (char c in s)
    {
        if (c == '{')
        {
            curlyBrackets.Enqueue(1);
        }
        if (c == '(')
        {
            brackets.Enqueue(1);
        }
        if (c == '[')
        {
            rectangularBrackets.Enqueue(1);
        }
        if (c == '}')
        {
            if (curlyBrackets.Count == 0)
                return false;
            curlyBrackets.Dequeue();
        }
        if (c == ')')
        {
            if (brackets.Count == 0)
                return false;
            brackets.Dequeue();
        }
        if (c == ']')
        {
            if (rectangularBrackets.Count == 0)
                return false;
            rectangularBrackets.Dequeue();
        }
    }
    if (curlyBrackets.Count == 0 && rectangularBrackets.Count == 0 && brackets.Count == 0)
        return true;
    return false;
}