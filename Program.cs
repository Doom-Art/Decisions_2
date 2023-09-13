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
            Console.Clear();
            double money = 150;
            Console.WriteLine("Welcome to the Bank of Blorb AMV \nPlease Select one of the following Options\n");
            Console.WriteLine("Deposit");
            Console.WriteLine("Withdrawal");
            Console.WriteLine("Bill Payment");
            Console.WriteLine("Account Balance Update");
            string choice = Console.ReadLine().Replace(" ", "").ToLower();
            money -= 0.75;
            if (choice == "deposit"){
                Console.WriteLine("How much would you like to deposit?");
                double depositAmount;
                double.TryParse(Console.ReadLine(), out depositAmount);
                if (depositAmount < 0)
                {
                    Console.WriteLine("You can not deposit a negative value, it has been defaulted to $0.00");
                    depositAmount = 0;
                }
                Console.WriteLine($"Please insert ${depositAmount} into the ATM:");
                Thread.Sleep(2000);
                Console.Write("Please wait while we process the deposit");
                for (int i = 0; i < 4; i++)
                {
                    Thread.Sleep(500);
                    Console.Write(".");
                }
                Console.WriteLine("\nYour deposit has been succesfully Completed");
                money += depositAmount;
            }
            else if (choice == "withdrawal"){
                bool correctAmount = false;
                while (!correctAmount)
                {
                    Console.Clear();
                    Console.WriteLine("How much would you like to withdraw?");
                    double withdrawAmount;
                    double.TryParse(Console.ReadLine(), out withdrawAmount);
                    if (withdrawAmount > money){
                        Console.WriteLine("You do not have this much money in the bank it has been defaulted to $0.00");
                        withdrawAmount = 0;
                    }
                    else if (withdrawAmount < 0){
                        Console.WriteLine("You can not withdraw a negative number, it has been defaulted to $0.00");
                        withdrawAmount = 0;
                    }
                    Console.WriteLine($"You would like to withdraw ${withdrawAmount}, if this is correct press enter");
                    if (Console.ReadLine() == ""){
                        money -= withdrawAmount;
                        correctAmount = true;
                    }
                }
            }
            else if (choice == "billpayment"){
                
                bool correctInfo = false;
                while (!correctInfo)
                {
                    Console.Clear();
                    Console.WriteLine("Who are you paying?");
                    string whoToPay = Console.ReadLine().Trim();
                    Console.WriteLine("How much are you paying?");
                    double amountToPay;
                    if (!double.TryParse(Console.ReadLine().Trim(), out amountToPay)){
                        Console.WriteLine("You have not entered a valid number please try again later");
                        break;
                    }
                    else if (amountToPay > money){
                        Console.WriteLine("You do not have this much money in the bank it has been defaulted to $0.00");
                        amountToPay = 0;
                    }
                    else if (amountToPay < 0){
                        Console.WriteLine("You can not pay a negative number, it has been defaulted to $0.00");
                        amountToPay = 0;
                    }
                    Console.WriteLine($"You are paying ${amountToPay} to {whoToPay}\nIf this is correct press enter, if not type no");
                    if (Console.ReadLine() == ""){
                        correctInfo = true;
                        money -= amountToPay;
                    }
                }
            }
            else if (choice == "accountbalanceupdate"){
                Console.Write("Please Wait While we Process your request");
                for (int i =0; i < 4; i++)
                {
                    Thread.Sleep(500);
                    Console.Write(".");
                }

            }
            else{
                Console.WriteLine("An error has occured when proccesing your request, please try again or call the help line");
            }
            Console.WriteLine($"\nThank you for using the BoB ATM, you're account balance is ${Math.Round(money,2)}, Hava a nice Day");
        }
        private static void ParkGarage()
        {
            Console.WriteLine("Thank you for using Sam's parking Garage, How many minutes have you been here for?");
            bool number = false;
            int minutes =0;
            while (!number)
            {
                number = Int32.TryParse(Console.ReadLine(), out minutes);
                if (minutes <= 0)
                    number = false;
                if (!number){
                    Console.WriteLine("Please input a whole number");
                }
                else
                    Console.WriteLine($"\nYou have been here {minutes} minutes please wait while we process your bill\n");
            }
            int cost = 2;
            while (minutes >= 60)
            {
                cost += 2;
                minutes -= 60;
            }
            if (minutes > 0){
                cost += 2;
            }
            if (cost > 20)
                cost = 20;
            Console.WriteLine($"Your total bill is ${cost}.00, Have a nice day");
        }
        private static void Hurricane()
        {

        }
    }
}