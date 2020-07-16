using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    /**
     * <summary>
     * This is the driver class
     * </summary>
     * 
     * @class Program
     */
     // Author's name Richard Elridge
     //Student number 301107264
     //Last modify July 16 2020
     // This is a simple program that store a list of numbers in a list and using loops the numbers are randomly
     //assign to an object and display using a switch case for the user to select there choice and the program will display
     //6 or 7 set of numbers in a row
    public class Program
    {
        // Instantiate lotto649 object
        static Lotto649 lotto649 = new Lotto649();
        // Instantiate lottoMax object
        static LottoMax lottoMax = new LottoMax();

        /**
         * @static
         * @method Main
         * @returns {void}
         */
        public static void Main(string[] args)
        {
            // Call the Menu
            LottoMenu();
        }

        /**
         * <summary>
         * This utility method creates a console menu that allows the user to choose
         * a Lotto game to execute.
         * </summary>
         * 
         * @static
         * @method LottoMenu
         * @returns {void}
         */
        public static void LottoMenu()
        {
            // declare a variable to record if menu is active
            bool menuActive = true;

            // While the menu is active...loop
            while (menuActive)
            {
                // show options in the console menu
                Console.WriteLine("++++++++++++++++++++++++++++++++");
                Console.WriteLine(" Please make your selection");
                Console.WriteLine(" 1. Lotto 6/49");
                Console.WriteLine(" 2. Lotto Max");
                Console.WriteLine(" 3. Exit");
                Console.WriteLine("++++++++++++++++++++++++++++++++");

                // read the user selection
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1: // The "1" Key - Select Lotto 6 / 49
                        Console.Clear();
                        Console.WriteLine("+ Lotto 6/49 +++++++++++++++++++");
                        lotto649.GenerateLottoNumbers();
                        
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D2: // The "2" Key - Select Lotto Max
                        Console.Clear();
                        Console.WriteLine("+ Lotto MAX ++++++++++++++++++++");
                        lottoMax.GenerateLottoNumbers();
                        Console.WriteLine("++++++++++++++++++++++++++++++++");
                        Console.WriteLine("Please press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case ConsoleKey.D3: // The "3" Key - Exit the menu
                        menuActive = false;
                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}
