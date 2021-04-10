using TheFight;
using System;


namespace TheFight
{
   public class Program
    {

        static int tableWidth = 113;
        static void Main(string[] args)
           
        {
            Boxer myboxer = new Boxer("Canelo", "Middleweight", "5ft9in");
            Opponent opponent = new Opponent("GGG", "Middlewieght", "5ft10in");
            Console.WriteLine("Record of my boxer?");
            Console.WriteLine("");

            myboxer.record = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Record of opponent?");
            Console.WriteLine("");
            opponent.oRecord = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //myboxer.MenuSelectMethod();

            Console.ReadLine();

            {
                PrintLine();
                PrintRow("Boxer Name", "Weight", "Height", "Record");
                PrintLine();
                PrintRow("" + myboxer.name, "" + myboxer.height, "" + myboxer.weight,  "" + myboxer.record );
                PrintRow("" , "" , "" , "" );
                PrintLine();

                PrintLine();
                PrintRow("Boxer Name", "Weight", "Height", "Record");
                PrintLine();
                PrintRow("" + opponent.oName, "" + opponent.oHeight, "" + opponent.oWeight, "" + opponent.oRecord);
                PrintRow("", "", "", "");
                PrintLine();

                //GenerateHtmlPage();
                Console.ReadLine();
            }

            static void PrintLine()
            {
                Console.WriteLine(new string('-', tableWidth));
            }

            static void PrintRow(params string[] columns)
            {
                int width = (tableWidth - columns.Length) / columns.Length;
                string row = "|";

                foreach (string column in columns)
                {
                    row += AlignCentre(column, width) + "|";
                }

                Console.WriteLine(row);
            }

            static string AlignCentre(string text, int width)
            {
                text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

                if (string.IsNullOrEmpty(text))
                {
                    return new string(' ', width);
                }
                else
                {
                    return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
                }
            }
            {
                bool myBoxerWins = true;
                if (myboxer.record > opponent.oRecord)
                {
                    Console.WriteLine($"{myboxer.name} won!"); 
                }
                else
                {
                    Console.WriteLine($"{ opponent.oName} won!");
                }
            }

        }






    }

        
    
}
