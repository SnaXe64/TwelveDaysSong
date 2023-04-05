using System;
using System.Collections.Generic;
using static System.Console;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwelveSong
{
    internal class Lyrics
    {
        private string[] Days = new string[]
        {
            "first",
            "second",
            "third",
            "fourth",
            "fifth",
            "sixth",
            "seventh",
            "eighth",
            "ninth",
            "tenth",
            "eleventh",
            "twelfth"
        };

        private string[] Gifts = new string[]
        {
            "a Partridge in a pear tree.",
            "two turtle doves",
            "Three French hens",
            "four calling birds",
            "five golden rings",
            "six geese a laying",
            "Seven swans a swimming",
            "eight maids a milking",
            "nine ladies dancing",
            "ten lords a leaping",
            "Eleven pipers piping",
            "twelve drummers drumming"

        };

        public Lyrics()
        {
            Sing();
        }

        public void Sing()
        {
            //create loop to iterate each day
            for(int d = 0; d < Days.Length;d++)
            {
                WriteLine($"On the {Days[d]} day of Christmas my true love gave to me...");

                if(d == 0)
                {
                    WriteLine($"{Gifts[d]}.");
                }
                else
                {
                    //create loop to iterate through all gifts to current day
                    for (int g = d; g > 0; g--)
                    {
                        WriteLine($"   {Gifts[g]}, ");
                    }

                    WriteLine($"and {Gifts[0]}.");
                }

                
                ReadKey();
                Clear();
            }

        }
    }
}
