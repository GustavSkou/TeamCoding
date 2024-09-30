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

/*
Opgave 2:
    Lav en funktion der finder ud af hvor mange bogstaver der er i en sætning.
    “Jeg vil gerne bestille en lagkage med ekstra flødeskum”
    Lav funktion der finder ud af hvilken af to sætninger har flest tegn
    “Jeg vil gerne bestille en lagkage med ekstra flødeskum på”
    “Jeg så en tiger i Odense Zoo i går, og den var meget stor”
*/

int StringSize(string someString)
{
    int size = 0;
    someString = someString.Replace(" ", "");

    foreach (char item in someString)
    {
        size++;
    }

    return size; 
    //return someString.Length
}



string someString = "Jeg vil gerne bestille en lagkage med ekstra flødeskum";
Console.WriteLine(StringSize(someString));