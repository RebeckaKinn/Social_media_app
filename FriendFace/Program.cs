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
            StartPage(user.accounts);
        }
        static void StartPage(List<Account> accounts)
        {
            var input = Console.ReadLine();

            foreach (var person in accounts)
            {
                if (input == person.firstName)
                {
                    Login(accounts);
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

        }

        static void Login(List<Account> accounts)
        {
        }
    }
}