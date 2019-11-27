using System;

class MainClass
{
    public static void Main(string[] args)
    {
        {
            Console.Write("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
            string vacationType = Console.ReadLine();

            Console.Write("How many are in your group? ");
            int groupSize = int.Parse(Console.ReadLine());
            string vacationDest = "";
            string travelSugg = ("");
            switch (vacationType)
            {
                case "tropical":
                    vacationDest = "a beach vacation in Mexico";
                    break;
                case "musical":
                    vacationDest = "New Orleans";
                    break;

                case "adventurous":
                    vacationDest = "white water rafting the Grand Canyon";
                    break;
                default:

                    break;

            }

            if (groupSize <= 2)
                travelSugg = "first class";
            else if (groupSize > 2 && groupSize < 6)
                travelSugg = "helicopter";
            else
                travelSugg = "charter flight";


            Console.WriteLine("Since youre a group of " + groupSize
            + " going on a " + vacationType + " vacation, you should take a "
            + travelSugg + " to " + vacationDest);
            Console.ReadLine();
        }

    }
}











