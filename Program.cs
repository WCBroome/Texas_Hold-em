using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Texas_Hold_em
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Chips theseChips = new Chips();
            theseChips.CreatePlayerChips(6, 8000);

            Testing test = new Testing();
            test.PrintChipsDict(theseChips.playerChips);


        }
    }
}
