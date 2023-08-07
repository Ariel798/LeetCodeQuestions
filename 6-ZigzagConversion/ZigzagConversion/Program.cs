using System.Text;

var s = "PAYPALISHIRING";
var numRows = 3;

System.Console.WriteLine(Convert(s, numRows));

string Convert(string s, int numRows)
{
    var countRows = 0;
    int[,] matrix = new int[numRows + 1, numRows * 2];
    StringBuilder sb = new StringBuilder();
    foreach (var c in s)
    {
        var countColumns = 0;
        matrix[countRows, countColumns] = c;
        if (countRows == numRows)
        {
            while (countRows > 0)
            {
                countColumns++;
                countRows--;
                matrix[countRows, countColumns] = c;
            }
            
        }
        countRows++;
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != null)
            {
                char c = (char)matrix[i, j];
                sb.Append(c);
            }
        }
    }
    return sb.ToString();
}
