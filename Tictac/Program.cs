Console.SetCursorPosition(0, 5);
int i, j, k, Column, Line, p, R, t, count;
string Point;
int [] Player1Columns = new int[10];
int [] Player2Columns = new int[10];
int [] Player1Lines = new int[10];
int [] Player2Lines = new int[10];

for (k = 1; k <= 3; k++)
{
    for (i = 0; i <= 18; i++)
    {
        Console.Write("-");
    }
    Console.WriteLine(" ");

    Console.WriteLine("|     |     |     |");

}
for (i = 0; i <= 18; i++)
{
    Console.Write("-");
}
void location(int Column, int Line, string Point)

{
    if (Column == 1 && Line == 1)
    {
        Console.SetCursorPosition(3, 6);
    }
    if (Column == 1 && Line == 2)
    {
        Console.SetCursorPosition(3, 8);
    }
    if (Column == 1 && Line == 3)
    {
        Console.SetCursorPosition(3, 10);
    }
    if (Column == 2 && Line == 1)
    {
        Console.SetCursorPosition(9, 6);
    }
    if (Column == 2 && Line == 2)
    {
        Console.SetCursorPosition(9, 8);
    }
    if (Column == 2 && Line == 3)
    {
        Console.SetCursorPosition(9, 10);
    }
    if (Column == 3 && Line == 1)
    {
        Console.SetCursorPosition(15, 6);
    }
    if (Column == 3 && Line == 2)
    {
        Console.SetCursorPosition(15, 8);
    }
    if (Column == 3 && Line == 3)
    {
        Console.SetCursorPosition(15, 10);
    }
    Console.Write($"{Point}");
}

for (p = 1; p <= 9; p++)

{
    if (p % 2 != 0)
    {
        Point = "X";
        R = 1;
    }
    else
    {
        Point = "O";
        R = 2;
    }

    Console.WriteLine(" ");
    Console.Write($" Игрок {R} введите номер столбца: ");
    Column = int.Parse(Console.ReadLine()!);
    Console.Write($" Игрок {R} введите номер строки: ");
    Line = int.Parse(Console.ReadLine()!);
        if (p % 2 != 0)
    {
        Player1Columns[p] = Column;
        Player1Lines[p] = Line;
    }
    else
    {
        Player2Columns[p] = Column;
        Player2Lines[p] = Line;
    }
    location(Column, Line, Point);

    Console.SetCursorPosition(0, 11);

    if (p >=3)
    {
        count = 0;
        for (t=0; t<=p; t++)
        {
            if (Player1Columns[t] == 1 || Player1Columns[t] == 2 || Player1Columns[t] == 3 )
            {
            count++;
            }
        }
        if (count == 3)
        {
        Console.SetCursorPosition(0, 14);
        Console.Write("Игрок 1 победил");
        break;
        }
    }
       if (p >=3)
    {
        count = 0;
        for (t=0; t<=p; t++)
        {
            if (Player2Columns[t] == 1 || Player2Columns[t] == 2 || Player2Columns[t] == 3 )
            {
            count++;
            }
        }
        if (count == 3)
        {
        Console.SetCursorPosition(0, 14);
        Console.Write("Игрок 1 победил");
        break;
        }
    }
    if (p >=3)
    {
        count = 0;
        for (t=0; t<=p; t++)
        {
            if (Player1Lines[t] == 1 || Player1Lines[t] == 2 || Player1Lines[t] == 3 )
            {
            count++;
            }
        }
                if (count == 3)
        {
        Console.SetCursorPosition(0, 14);
        Console.Write("Игрок 2 победил");
        break;
        }
    }
    if (p >=3)
    {
        count = 0;
        for (t=0; t<=p; t++)
        {
            if (Player2Lines[t] == 1 || Player2Lines[t] == 2 || Player2Lines[t] == 3 )
            {
            count++;
            }
        }
                if (count == 3)
        {
        Console.SetCursorPosition(0, 14);
        Console.Write("Игрок 2 победил");
        break;
        }
    }
}



Console.SetCursorPosition(0, 15);
