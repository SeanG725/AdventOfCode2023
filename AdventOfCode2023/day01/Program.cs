using System.Collections.Generic;
using System.Diagnostics.Tracing;

string[] lines = File.ReadAllLines("input.txt");
int total = 0;

string firstDigit(string line)
{
    String first = "";
    for (int i = 0; i < line.Length; i++)
    {
        if (Char.IsDigit(line[i]))
        {
            first = line[i].ToString();
            break;
        }
    }
    return first;
}
string lastDigit(string line)
{
    String last = "";
    for (int i = line.Length - 1; i > 0; i--)
    {
        if (Char.IsDigit(line[i]))
        {
            last = line[i].ToString();
            break;
        }
    }
    return last;
}
bool oneDigit(string line)
{
    int counter = 0;

    for (int i = 0; i < line.Length; i++)
    {
        if (Char.IsDigit(line[i]))
        {
            counter++;
        }
    }

    if (counter == 1)
    {
        return true;
    }

    return false;
}

foreach(var line in lines)
{
    string final = "";
    if(oneDigit(line))
    {
        final = firstDigit(line) + firstDigit(line);
    }
    else
    {
        final = firstDigit(line) + lastDigit(line);
    }

    total += int.Parse(final);
}

Console.WriteLine(total);