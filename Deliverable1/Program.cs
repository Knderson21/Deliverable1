bool tryAgain = true;
while (tryAgain)
{
    Console.WriteLine("How many people are we making PB and J sandwiches for?");
    string input = Console.ReadLine();
    int numberOfPeople = int.Parse(input);

    Console.WriteLine("\nYou need:\n");

    int totalSlicesNeeded = numberOfPeople * 2;
    Console.WriteLine("\t" + totalSlicesNeeded + " slices of bread");

    int totalTablespoonsOfPeanutButter = numberOfPeople * 2;
    Console.WriteLine("\t" + totalTablespoonsOfPeanutButter + " tablespoons of peanut butter");

    int totalTeaspoonsOfJelly = numberOfPeople * 4;
    Console.WriteLine("\t" + totalTeaspoonsOfJelly + " teaspoons of jelly");

    Console.WriteLine("\nWhich is...\n");

    double totalNumberOfLoaves = totalSlicesNeeded / 28.0;
    Console.WriteLine("\t" + Math.Ceiling(totalNumberOfLoaves) + " loaves of bread");

    double totalNumberOfPBJars = totalTablespoonsOfPeanutButter / 32.0;
    Console.WriteLine("\t" + Math.Ceiling(totalNumberOfPBJars) + " jars of peanut butter");

    double totalNumberofJellyJars = totalTeaspoonsOfJelly / 48.0;
    Console.WriteLine("\t" + Math.Ceiling(totalNumberofJellyJars) + " jars of jelly");

    Console.WriteLine("\nWould you like to restart? Enter yes or y to continue, or enter any other key to exit.");
    input = Console.ReadLine();

    if (input != "yes" && input != "y")
    {
        tryAgain = false;
    }
}
Console.WriteLine("\nGoodbye!");

