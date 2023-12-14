string[] games = File.ReadAllLines("input.txt");

int gamesPossible = 0;

for (int i = 0; i < games.Length; i++)
{
    string originalWord = games[i];
    string currentWord = originalWord;

    Console.WriteLine(originalWord);
    Console.WriteLine();

    int currentRedPos = currentWord.IndexOf("red");
    int currentGreenPos = currentWord.IndexOf("green");
    int currentBluePos = currentWord.IndexOf("blue");

    int currentRedValue = 0;
    int currentGreenValue = 0;
    int currentBlueValue = 0;

    int greatestRed = 0;
    int greatestGreen = 0;
    int greatestBlue = 0;

    // Reds
    Console.WriteLine("Reds:");
    while(currentRedPos != -1)
    {
        currentRedPos = currentWord.IndexOf(" red") - 2;
        currentWord = currentWord.Substring(currentRedPos);
        currentRedValue = Int32.Parse(currentWord[1].ToString());
        if (currentWord[0] == '1')
        {
            currentRedValue += 10;
        }
        currentWord = currentWord.Substring(5); // change to proper length for each color
        currentRedPos = currentWord.IndexOf(" red");

        Console.WriteLine(currentRedValue);

        if (currentRedValue > greatestRed)
        {
            greatestRed = currentRedValue;
        }

    }

    currentWord = originalWord;

    // Greens
    Console.WriteLine("Greens:");
    while (currentGreenPos != -1)
    {
        currentGreenPos = currentWord.IndexOf(" green") - 2;
        currentWord = currentWord.Substring(currentGreenPos);
        currentGreenValue = Int32.Parse(currentWord[1].ToString());
        if (currentWord[0] == '1')
        {
            currentGreenValue += 10;
        }
        currentWord = currentWord.Substring(7); // change to proper length for each color
        currentGreenPos = currentWord.IndexOf(" green");

        Console.WriteLine(currentGreenValue);

        if (currentGreenValue > greatestGreen)
        {
            greatestGreen = currentGreenValue;
        }

    }

    currentWord = originalWord;

    // Blues
    Console.WriteLine("Blues:");
    while (currentBluePos != -1)
    {
        currentBluePos = currentWord.IndexOf(" blue") - 2;
        currentWord = currentWord.Substring(currentBluePos);
        currentBlueValue = Int32.Parse(currentWord[1].ToString());
        if (currentWord[0] == '1')
        {
            currentBlueValue += 10;
        }
        currentWord = currentWord.Substring(6); // change to proper length for each color
        currentBluePos = currentWord.IndexOf(" blue");

        Console.WriteLine(currentBlueValue);

        if (currentBlueValue > greatestBlue)
        {
            greatestBlue = currentBlueValue;
        }

    }


    Console.WriteLine();
    Console.WriteLine("Greatest red = " + greatestRed);
    Console.WriteLine("Greatest green = " + greatestGreen);
    Console.WriteLine("Greatest blue = " + greatestBlue);
    Console.WriteLine();

    int gameNumber = i + 1;

    Console.WriteLine("Game Number : " + gameNumber);

    if (greatestRed <= 12 && greatestGreen <= 13 && greatestBlue <= 14)
    {
        Console.WriteLine(" POSSIBLE GAME ");
        gamesPossible += gameNumber;
    }

    Console.WriteLine("-------------------------------------------------------------------------------------------------");
} // End of for (int i = 0; i < games.Length; i++) loop;

Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Answer = " + gamesPossible);
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("-------------------------------------------------------------------------------------------------");