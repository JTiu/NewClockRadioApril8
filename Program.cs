using BoxerProfile;
using System;


namespace NewBoxerApril8
{
   public class Program
    {

        static int tableWidth = 113;
        static void Main(string[] args)
        {
            Boxer myboxer = new Boxer("Canelo", "Middleweight", "5ft9in", "30-1");
            //myboxer.MenuSelectMethod();
            
            Console.ReadLine();

            {

                //int x_1 = Boxer.name;
                //int x_2 = scoreBoxer1_2;
                //int x_3 = scoreBoxer1_3;
                //int x_4 = scoreBoxer2_1;
                //int x_5 = scoreBoxer2_2;
                //int x_6 = scoreBoxer2_3;
                //int x_7 = scoreBoxer1_1 + scoreBoxer1_2 + scoreBoxer1_3;
                //int x_8 = scoreBoxer2_1 + scoreBoxer2_2 + scoreBoxer2_3;


                PrintLine();
                PrintRow("Boxer Name", "Weight", "Height", "Record");
                PrintLine();
                PrintRow("" + myboxer.name, "" + myboxer.height, "" + myboxer.weight,  "" + myboxer.record );
                PrintRow("" , "" , "" , "" );
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

           
        }






    }

        
    
}
