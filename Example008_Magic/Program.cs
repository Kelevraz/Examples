Console.Clear();

//Console.SetCursorPosition (10, 4);
//Console.WriteLine("+");

//int xa = 1;
//int ya = 1;
//int xb = 1;
//int yb = 30; либо можно записать перечисление так:

int x1 = 1, y1 = 1,
    x2 = 1, y2 = 30,
    x3 = 80, y3 = 30;

Console.SetCursorPosition(x1, y1);
Console.WriteLine("+");

Console.SetCursorPosition(x2, y2);
Console.WriteLine("+");

Console.SetCursorPosition(x3, y3);
Console.WriteLine("+");

int x = x1, y = x2;

int count = 0;

while (count < 100)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + x1) / 2;
        y = (y + y1) / 2;
    }

    if (what == 1)
    {
        x = (x + x2) / 2;
        y = (y + y2) / 2;
    }

    if (what == 2)
    {
        x = (x + x3) / 2;
        y = (y + y3) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1; // либо можно использовать такие варианты записи (при увеличении на 1): count +=1; или count++;
}