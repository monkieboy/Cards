using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGames
{
    class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();

            
            var a = deck.Deal();
            var b = deck.Deal();
            Console.WriteLine(a);
            Console.ReadLine();

        }
    }
}
