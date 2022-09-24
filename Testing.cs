using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Texas_Hold_em
{
    internal class Testing
    {
        public void PrintHandsDict(Dictionary<int, List<string>> thisDeckHands)
        {
            string output = "";
            foreach (KeyValuePair<int, List<string>> kvp in thisDeckHands)
            {
                output += string.Format("Player = {0}, Hand = {1}", kvp.Key, String.Join(", ", kvp.Value.ToArray()));
                output += "\n";
            }
            Console.WriteLine(output);
        }

        public void PrintChipsDict(Dictionary<int, int> thesechips)
        {
            string output = "";
            foreach (KeyValuePair<int, int> kvp in thesechips)
            {
                output += string.Format("Player = {0}, Hand = {1}", kvp.Key, kvp.Value);
                output += "\n";
            }
            Console.WriteLine(output);
        }
    }
}
