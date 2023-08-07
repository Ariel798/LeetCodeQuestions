var board = new int[,]
{{5, 3, 0, 0, 7, 0, 0, 0, 0},
{6, 0, 0, 1, 9, 5, 0, 0, 0},
{0, 9, 8, 0, 0, 0, 0, 6, 0}
,{8, 0, 0, 0, 6, 0, 0, 0, 3}
,{4, 0, 0, 8, 0, 3, 0, 0, 1}
,{7, 0, 0, 0, 2, 0, 0, 0, 6}
,{0, 6, 0, 0, 0, 0, 2, 8, 0}
,{0, 0, 0, 4, 1, 9, 0, 0, 5}
,{0, 0, 0, 0, 8, 0, 0, 7, 9}};

IDictionary<int, HashSet<int>> rows = new Dictionary<int, HashSet<int>>();
IDictionary<int, HashSet<int>> columns = new Dictionary<int, HashSet<int>>();
IDictionary<int, HashSet<int>> boxes = new Dictionary<int, HashSet<int>>();

System.Console.WriteLine(CheckSudoku(board));

bool CheckSudoku(int[,] board)
{
    var res = true;
    for (int i = 0; i < board.GetLength(0)-1; i++)
    {
        for (int j = 0; j < board.GetLength(1)-1; j++)
        {
            var item = board[i, j];
            if (item != 0)
            {
                if (rows.ContainsKey(i))
                {
                    if (!rows[i].Add(item))
                    {
                        res = false;
                        break;
                    }
                }
                else
                    rows.Add(i, new HashSet<int> { item });
                if (columns.ContainsKey(j))
                {
                    if (!columns[j].Add(item))
                    {
                        res = false;
                        break;
                    }
                }
                else
                    columns.Add(j, new HashSet<int> { item });

                var boxNum = GetBox(i, j);
                if (boxes.ContainsKey(boxNum))
                {
                    if (!boxes[boxNum].Add(item))
                    {
                        res = false;
                        break;
                    }
                }
                else
                    boxes.Add(boxNum, new HashSet<int> { item });
            }
        }
    }
    return res;
}

int GetBox(int i, int j)
{
    //box row one
    if (i < 3 && j < 3)
        return 1;
    if (i < 3 && j < 6 && j > 2)
        return 2;
    if (i < 3 && j > 5 && j < 9)
        return 3;
    //box row two
    if (i > 2 && i < 6 && j < 3)
    {
        return 4;
    }
    if (i > 2 && i < 6 && j < 6 && j > 2)
        return 5;
    if (i > 2 && i < 6 && j < 9 && j > 5)
        return 6;
    //box row three
    if (i > 5 && i < 9 && j < 3)
        return 6;
    if (i > 5 && i < 9 && j < 6 && j > 2)
        return 7;
    if (i > 5 && i < 9 && j < 9 && j > 5)
        return 7;
    return 0;
}