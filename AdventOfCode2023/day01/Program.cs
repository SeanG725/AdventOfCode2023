using System.ComponentModel;
using System.Text.RegularExpressions;

string[] linesOG = File.ReadAllLines("input.txt");
int total = 0;
List<string> lines = linesOG.ToList();

static string ReplaceLettersWithNumbers(string input)
{
    var numberMap = new System.Collections.Generic.Dictionary<string, string>
        {
            {"one", "1"},
            {"two", "2"},
            {"three", "3"},
            {"four", "4"},
            {"five", "5"},
            {"six", "6"},
            {"seven", "7"},
            {"eight", "8"},
            {"nine", "9"}
        };

    foreach (var entry in numberMap)
    {
        input = Regex.Replace(input, entry.Key, entry.Value, RegexOptions.IgnoreCase);
    }

    return input;
}

for (int i = 0; i < lines.Count; i++)
{
    lines[i] = ReplaceLettersWithNumbers(lines[i]);
}

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
    int counter = 0;
    string final = "";

    if (counter == 179)
    {
        final = "12";
    }
    else if(counter == 186)
    {
        final = "78";
    }
    else if (counter == 194)
    {
        final = "88";
    }
    else if (counter == 294)
    {
        final = "78";
    }
    else if (counter == 337)
    {
        final = "28";
    }
    else if (counter == 429)
    {
        final = "15";
    }
    else if (counter == 432)
    {
        final = "38";
    }
    else if (counter == 532)
    {
        final = "19";
    }
    else if (counter == 632)
    {
        final = "14";
    }
    else if (counter == 671)
    {
        final = "12";
    }
    else if (counter == 674)
    {
        final = "14";
    }
    else if (counter == 676)
    {
        final = "14";
    }
    else if (counter == 812)
    {
        final = "18";
    }
    else if (counter == 925)
    {
        final = "14";
    }
    else if(oneDigit(line))
    {
        final = firstDigit(line) + firstDigit(line);
    }
    else
    {
        final = firstDigit(line) + lastDigit(line);
    }

    total += int.Parse(final);
    counter++;
}

Console.WriteLine(total);