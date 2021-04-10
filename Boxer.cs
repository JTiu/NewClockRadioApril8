using System;
using System.Collections.Generic;
using System.Text;

namespace TheFight
{
    public class Boxer
    {
        public string name;
        public string weight;
        public string height;
        public int record;
        public bool righty;
        static int tableWidth = 113;

        public Boxer   (string name, string weight, string height)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
            //this.record = record;
            //this.righty = righty;
        }

        public void MenuSelectMethod()
        {
            Console.WriteLine("Hello, let's examine your Opponent's Profile");
            Console.WriteLine("");
            //loop, wrap all the options in a loop, stop loop with "9 exit" at the user's option. all of the options print to the screen, user choices as many as desired, then can exit at user's option

            //bool participantMayChooseOpponent = true;

            //while (participantMayChooseOpponent)
            //{
            //    Console.WriteLine("Press 1 to Display Opponent's Name");
            //    Console.WriteLine("Press 2 to Display Opponent's Weight, Height, and Record");
            //    Console.WriteLine("Press 3 to check righty");
                
            //    string participantSelection;
            //    participantSelection = Console.ReadLine();
                
            //    if (participantSelection == "1")
            //    {
            //        DisplayOpponentName();
            //    }
            //    else if (participantSelection == "2")
            //    {
            //        DisplayOpponentWeightHeightRecord();
            //    }
            //    else if (participantSelection == "3")
            //    {
            //        CheckRighty();
            //    }

            //}

            PrintLine();
            PrintRow();
            PrintLine();
            PrintRow();
            PrintRow();
            PrintLine();


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


        public void DisplayOpponentName()
        {
            Console.WriteLine("Your opponent's name is: " + name);
            Console.ReadLine();
            Console.Clear();
        }
        public void DisplayOpponentWeightHeightRecord()
        {
            Console.WriteLine("Your opponent is a " + weight);
            Console.WriteLine("Your opponent's height is " + height); 
            Console.WriteLine("Your opponent's record is " + record);
            Console.ReadLine();
            Console.Clear();
        }

        public void CheckRighty()
        {
            bool righty = true;

            if (righty)
            {
                Console.WriteLine("no need to adjust stance, opponent is a righty");
                Console.ReadLine();
                Console.Clear();
            }
            
        }

            




    }
        
    
}
