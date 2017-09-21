using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            bool againQuestion = true;
            Console.WriteLine("Learn your squares and cubes");
            Console.WriteLine();
            while (againQuestion==true) 
            {
                Console.WriteLine("Please enter an integer");
                input = int.Parse(Console.ReadLine());
                if (input == 0)
                {
                    Console.WriteLine("Zero Squared, and Cubed is Zero");
                   
                }
                else
                {

                    for (int i = 1; i <= input; i++)
                    {

                        Console.Write(i + "           ");
                        Console.Write(Squared(i) + "          ");
                        Console.Write(Cubed(i) + "   ");
                        Console.WriteLine();


                    }
                }
                againQuestion = DoAgain();
            
            }

        }
        public static int Squared(int i)
        {
            int square = i * i;
            return square;
            
        }
        public static int Cubed(int i)
        {
            int cubed = i * i * i;
            return cubed;
        }
        public static bool DoAgain()
        {
            string repeat;
            Console.WriteLine("Continue? Y or N");
            repeat = Console.ReadLine();
            repeat=repeat.ToLower();
            bool goAgain;
            if (repeat== "y")
            {
                goAgain = true;
            }
            else if (repeat== "n")
            {
                goAgain = false;
            }
            else
            {
                Console.WriteLine("Sorry not an accurate input");
                goAgain = DoAgain();
            }
            return goAgain;
        }

    }
}
