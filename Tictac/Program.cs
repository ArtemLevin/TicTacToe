Console.SetCursorPosition(0, 5);
int i, j, k, Column, Line, p, R;
string Point;

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
    location(Column, Line, Point);
    Console.SetCursorPosition(0, 11);
}

Console.SetCursorPosition(0, 14);
