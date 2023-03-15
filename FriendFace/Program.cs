namespace FriendFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new();
            Console.WriteLine("WELCOME TO FRIENDFACE - THE ONLY SOCIAL PLATFORM YOU NEED");
            Console.WriteLine("");
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please enter your firstname to log in");
            Console.WriteLine("OR");
            Console.WriteLine("write 'new user' to create account.");
            StartPage(user.Accounts);
        }
        static void StartPage(List<Account> accounts)
        {
            string? input = Console.ReadLine();

            foreach (var person in accounts)
            {
                if (input == person.FirstName)
                {
                    Login(accounts, person.FirstName);
                }
                else if (input == "new user")
                {
                    CreateAccount(accounts);
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer below.");
                    StartPage(accounts);
                }
            }

        }
        static void CreateAccount(List<Account> accounts)
        {
            Console.WriteLine($"{accounts.Count} accounts");
        }

        static void Login(List<Account> accounts, string currentName)
        {
            Console.WriteLine("Please enter your lastname.");
            var input = Console.ReadLine();
            foreach (var person in accounts)
            {
                if (person.FirstName == currentName && input == person.LastName)
                {

                }
                else
                {
                    Console.WriteLine("Wrong input detected. Please try again or");
                    Console.WriteLine("write 'back' to the start menu.");
                    input = Console.ReadLine();
                    if (input == "back")
                    {
                        Console.WriteLine("Please enter your firstname to log in");
                        Console.WriteLine("OR");
                        Console.WriteLine("write 'new user' to create account.");
                        StartPage(accounts);
                    }
                    else if (person.FirstName == currentName && input == person.LastName)
                    {
                        PasswordCheck(accounts, person.FirstName, person.LastName);
                    }
                    else
                    {
                        Console.WriteLine("You have written your lastname wrong");
                        Console.WriteLine("too many times. Press any button to continue.");
                        input = Console.ReadLine();
                        if (input != null)
                        {
                            Console.WriteLine("Please enter your firstname to log in");
                            Console.WriteLine("OR");
                            Console.WriteLine("write 'new user' to create account.");
                            StartPage(accounts);
                        }
                    }
                }

            }
        }
        static void PasswordCheck(List<Account> accounts, string firstname, string lastname)
        {
            //skjekk passordene om de stemmer overens med allerede riktig navn
        }
    }
}