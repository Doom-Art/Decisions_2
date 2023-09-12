using System.Data.SqlTypes;
using System.Xml.Serialization;

namespace If_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Welcome to the Menu please select an option");
            Console.WriteLine("1 - BoB Bank");
            Console.WriteLine("2 - Sam's Parking Garage");
            Console.WriteLine("3 - Hurricane Reader");
            int choice =0;
            while (!Int32.TryParse(Console.ReadLine(), out choice) || choice <1 || choice >3)
                Console.WriteLine("Invalid Choice, try again");
            Console.Clear();
            if (choice == 1)
                BobBank();
            else if (choice == 2)
                ParkGarage();
            else if (choice == 3)
                Hurricane();

        }
        private static void BobBank()
        {
            double money = 150;
            Console.WriteLine("Welcome to the Bank of Blorb AMV \nPlease Select a Valid Option\n");
            Console.WriteLine("Deposit");
            Console.WriteLine("Withdrawal");
            Console.WriteLine("Bill Payment");
            Console.WriteLine("Account Balance Update");
            string choice = Console.ReadLine().Replace(" ", "").ToLower();
            money -= 0.75;
            if (choice == "deposit"){

            }
            else if (choice == "withdrawal"){

            }
            else if (choice == "billpayment"){

            }
            else if (choice == "accountbalanceupdate"){

            }
            else{
                Console.WriteLine("An error has occured when proccesing your request, please try again or call the help line");
            }
            Console.WriteLine($"\nThank you for using the BoB ATM, you're account balance is ${money}, Hava a nice Day");
        }
        private static void ParkGarage()
        {

        }
        private static void Hurricane()
        {

        }
    }
}