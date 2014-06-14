using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
         static void Main()

        {

          

 

            var aDeck = new Deck();

            var aHand = new Hand();

          

 

           

 

            while (true)

            {

               

                Console.WriteLine("Deck Cards:" + aDeck.GetLength());

                Console.WriteLine("Hand Cards:" + aHand.GetLength());

                Console.WriteLine("D: Deal to Hand");

                Console.WriteLine("S: Shuffle Deck");

                Console.WriteLine("X: See Deck");

                Console.WriteLine("R: Return Cards");

                Console.WriteLine("Escape: Quit");

                Console.WriteLine("===Your Hand===");

                aHand.Show();

                var input = Console.ReadKey();

               

                switch (input.Key)

                {

                    case ConsoleKey.S:

                        aDeck.Shuffle();

                        break;

                    case ConsoleKey.D:

                        aDeck.Deal(aHand);

                        break;

                    case ConsoleKey.H:

                        aHand.Show();

                        break;

                    case ConsoleKey.R:

                        aHand.ReturnCards(aDeck);

                        break;

                    case ConsoleKey.Escape:

                        Environment.Exit(0);

                        break;

                    case ConsoleKey.X:

                        aDeck.Show();

                        break;

                }

                Console.Clear();

              

                

            }

           

        }

      

    }

}
