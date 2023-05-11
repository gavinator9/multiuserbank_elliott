// Gavin Elliott
// IT112
// NOTES: this was a fun assignment, thought I had it completely done in one hour then spent more time combing over the fine details to fit criteria than I expected
// BEHAVIORS NOT IMPLIMENTED AND WHY: seems to be good as far as I can see

namespace banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Banking World! Enter your login credentials. \n");
            string input = "";
            bool inuse = true;
            bank account = new bank(10000);
            bool empty = false;
            char loggedin= '0';
            empty= false;
            decimal balancereader = 0;
            while (inuse==true)
            {

                while (loggedin=='0')
                {
                    Console.WriteLine("The bank currently contains " + account.bankbalance.ToString("C") + " worth of money.");
                    string user;
                    string pass;
                    Console.WriteLine("Please enter your login information \n");
                    Console.WriteLine("Username?:\n");
                    user=Console.ReadLine();
                    Console.WriteLine("Password?:\n");
                    pass=Console.ReadLine();
                    if (user== "jlennon")
                    {
                        if (pass == "johnny")
                        {
                            loggedin = '1';
                            Console.WriteLine("Welcome John Lennon!\n");
                            balancereader = account.balancejohn;
                        }
                    }

                    if (user == "pmccartney")
                    {
                        if (pass == "pauly")
                        {
                            loggedin = '2';
                            Console.WriteLine("Welcome Paul Mccartney!\n");
                            balancereader = account.balancepaul;
                        }
                    }

                    if (user == "gharrison")
                    {
                        if (pass == "georgy")
                        {
                            loggedin = '3';
                            Console.WriteLine("Welcome George Harrison!\n");
                            balancereader = account.balancegeorge;
                        }
                    }

                    if (user == "rstarr")
                    {
                        if (pass == "ringoy")
                        {
                            loggedin = '4';
                            Console.WriteLine("Welcome Ringo Starr!\n");
                            balancereader = account.balanceringo;
                        }
                    }

                }

                if (balancereader==0 || account.bankbalance==0) 
                {
                    Console.WriteLine("Your cannot withdraw while the bank is empty silly guy");
                        empty=true;
                }
                if (balancereader>0&&account.bankbalance>0)
                {
                    empty=false;
                }

                if (empty == true)
                {
                    if (loggedin == '4')
                    {
                        Console.WriteLine("rstarr bank account\n Current balance is: "+account.balanceringo.ToString("C"));
                    }
                    if (loggedin == '3')
                    {
                        Console.WriteLine("gharrison bank account\n Current balance is: "+account.balancegeorge.ToString("C"));
                    }
                    if (loggedin == '2')
                    {
                        Console.WriteLine("pmccartney bank account\n Current balance is: " + account.balancepaul.ToString("C"));
                    }
                    if (loggedin == '1')
                    {
                        Console.WriteLine("jlennon bank account\n Current balance is: " + account.balancejohn.ToString("C"));
                    }
                    Console.WriteLine("\nEnter a to deposit, c to quit or d to logout. \n");
                }
                if (empty==false)
                {
                    if (loggedin == '4')
                    {
                        Console.WriteLine("rstarr bank account\n Current balance is: " + account.balanceringo.ToString("C"));
                    }
                    if (loggedin == '3')
                    {
                        Console.WriteLine("gharrison bank account\n Current balance is: " + account.balancegeorge.ToString("C"));
                    }
                    if (loggedin == '2')
                    {
                        Console.WriteLine("pmccartney bank account\n Current balance is: " + account.balancepaul.ToString("C"));
                    }
                    if (loggedin == '1')
                    {
                        Console.WriteLine("jlennon bank account\n Current balance is: " + account.balancejohn.ToString("C"));
                    }


                    Console.WriteLine("\nEnter a to deposit, b to withdraw, c to quit, or d to logout. \n");
                }
                input = Console.ReadLine();
                if (input =="a")
                {
                    Console.WriteLine("Enter your deposit amount. \n");
                    input=Console.ReadLine();
                    decimal deposit=decimal.Parse(input);
                    string output = account.deposit(deposit,loggedin);
                    Console.WriteLine(output);
                    balancereader = account.balanceindex;

                }
                if (input=="b" && empty==false) 
                {

                    Console.WriteLine("Enter Withdrawal amount. \n");
                    input=Console.ReadLine();
                    decimal withdrawal=decimal.Parse(input);
                    if (withdrawal > 500) 
                    {
                        withdrawal = 500;
                        Console.WriteLine("500 is the maximum withdrawal, reducing withdrawal to 500. \n");
                    }
                    string output=account.withdraw(withdrawal,loggedin);
                    Console.WriteLine(output);
                    balancereader = account.balanceindex;
                }


                if (input=="c")
                {
                    inuse = false;
                    Console.WriteLine("\nGoodbye!");

                }

                if (input=="d")
                {
                    loggedin = '0';
                }


            }
        }
    }
}