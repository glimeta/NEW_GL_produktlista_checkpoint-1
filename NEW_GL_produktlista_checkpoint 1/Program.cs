// GL_mini project_Produktlista
Console.WriteLine("Mini Project - Checkpoint 1");
int index = 0;
string[] produkt = new string[0];


while (true)
{
    Console.WriteLine("Skriv in produkter som AB-400. Avsluta med att skriva 'exit'");
    Console.ForegroundColor = ConsoleColor.White;
    string data = Console.ReadLine();
    
    if (data.Trim().ToLower() == "exit")

    {
        break;
    }

    if (data.Length < 5)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fel inmatning. För kort artikel nummer. Skriv som AB-400.");
        continue;
    }

    string[] split = data.Split("-");    //this places a line between letters and numbers
    if (split.Length < 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fel inmatning. Ett bindestreck (-) saknas. Skriv som AB - 400.");
        continue;
    }
    else if (split.Length > 2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fel inmatning. Ett bindestreck (-) räcker. Skriv som AB - 400.");
        continue;
    }

    //checks if string is null or empty in both sides, split[0] is left, and split[1] is rigt of hypen
    bool fel = false;
    if (String.IsNullOrEmpty(split[0]) || String.IsNullOrEmpty(split[1]))  
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fel inmatning. Artilel nummer saknas. SKriv som AB-400.");
        fel = true;
    }

   foreach (char c in split[0])
    {
        if (!char.IsLetter(c)) // if char c is not a letter
        {
            fel = true;
        }

    if (fel)
       {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Fel inmatning. Det måste vara bokstäver i början. Skriv som AB - 400.");
            fel = true;
       }

    }

    //declaring a bool character, inINT within foreach command
    //inINT 0 has a command method int.TryParse(split[1], out int value that disects and determines if isINT is an integer and represents a number. The output value is then checked if within 200 and 500.

    bool isInt = int.TryParse(split[1], out int value);
    if (!isInt)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fel inmatning. Högra delen ska vara en siffra. Fösök igen");
        fel = true;
    }
    else if (value < 201 || value > 499)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Fel inmatning. Högra delen ska vara mellan 200 och 500. Fösök igen");
        fel = true;
    }
      
    if (!fel)                 
    {
      Array.Resize(ref produkt, index + 1);
        produkt[index] = data.ToUpper();
        index++;
        Console.WriteLine("Rätt Inmatning!");

    }

}


Console.WriteLine("-----------");
Console.WriteLine("Du angav följande produkter:");
for (int i = 0; i < produkt.Length; i++)
{
    Console.WriteLine(produkt[i]);
}

{
    Array.Sort(produkt);
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("-----------");
    Console.WriteLine("sorterade produkter");
    for (int i = 0; i < produkt.Length; i++)
     {
            Console.WriteLine(produkt[i]);
     }
}

Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Press enter to continue...");
Console.ReadLine();


