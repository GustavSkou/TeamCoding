/*
1. Lav en funktion der printer et tilfældigt tal mellem 1-100:
Eksempel på Random:
Random random = new Random();
int a = random.Next(1, 5);

2. Lav en funktion der fortæller om tallet over 50?
3. Lav en funktion der fortæller om tallet er et lige tal?
*/

int tal()
{
    Random random = new Random();
    int a = random.Next(1, 101);
    return a;
}

bool isOver50(int someNum)
{
    if (someNum > 50)
    {
        return true;
    }
    return false;
}

bool isEven(int someNum)
{
    if (someNum % 2 == 0)
    {
        return true;
    }
    return false;
}

for (int i = 0; i < 10; i++)
{
    int someNum = tal();
    Console.WriteLine(someNum + " " + isOver50(someNum) + " " + isEven(someNum));
}