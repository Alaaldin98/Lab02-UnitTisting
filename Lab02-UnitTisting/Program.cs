using System;

 namespace Test
{
    public class Program
    {
        public static decimal amount = 100;
        static void Main(string[] args)
        {
            userinterface();

        }
        public static void userinterface()
        {

            Console.WriteLine("Hello and Welcome to ATM Bank!");

            int pin, choice;
            Console.WriteLine("Enter Your 4 Digit Pin ");
            pin = int.Parse(Console.ReadLine());
            bool x = true;
            while (x)
            {
                Console.WriteLine("WELCOME TO BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("***************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                     Console.WriteLine(ViewBalance(amount));
                        break;
                    case 2:
                        Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                        decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine(Withdraw(withdraw));
                        break;
                    case 3:
                        Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                        decimal depo = Convert.ToDecimal(Console.ReadLine());
                        Console.WriteLine(Deposit(depo));
                        break;
                    case 4:
                    default:
                        Console.WriteLine("\n THANK YOU…");
                        x = false;
                        break;

                }
                Console.WriteLine("\n\n THANKS FOR USING ATM SERVICE");


            }
        }
        
        public static decimal ViewBalance(decimal amount)
        {

            Console.WriteLine($"\n YOUR CURRENT BALANCE IS: { amount} ");
            return amount;
        }
      public  static decimal Withdraw(decimal withdraw)
        {

            if (withdraw < 0)
            {
                Console.WriteLine("\n PLEASE ENTER THE AMOUNT IN ABOVE 0");
                return 1;
            }
            else if (withdraw > amount)
            {
                Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
                return 1;
            }
            else
            {
                amount = amount - withdraw;
                Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                Console.WriteLine($"\n CURRENT BALANCE IS : {amount}");
                return amount;
            }
           
        }
      public  static decimal Deposit(decimal deposit)
        {


            if (deposit < 0)
            {
                Console.WriteLine("Please input a positive value");
                return -1;
            }
            amount = amount + deposit;
            Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
            Console.WriteLine($"YOUR TOTAL BALANCE IS : {amount}");
            return amount;
        }
    }
}
