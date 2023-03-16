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
            Console.WriteLine("Please enter your email to log in");
            Console.WriteLine("OR");
            Console.WriteLine("write 'new user' to create account.");
            StartPage(user.Accounts);
        }
        static void StartPage(List<Account> accounts)
        {
            var input = Console.ReadLine();
            foreach (var person in accounts)
            {
                if (input == person.Email)
                {
                    Console.WriteLine("Please enter your password.");
                    PasswordCheck(accounts, person.Email);
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
        static void PasswordCheck(List<Account> accounts, string email)
        {
            var input = Console.ReadLine();
            foreach (var account in accounts.Select((value, i) => (value, i)))
            {

                if (account.value.Email == email)
                {
                    if (input == account.value.Password)
                    {
                        MainAccount(account.i);
                    }
                    else
                    {
                        Console.WriteLine("Wrong password. Please try again.");
                        var input2 = Console.ReadLine();

                        if (input2 == account.value.Password)
                        {
                            MainAccount(account.i);
                        }
                        else
                        {
                            Console.WriteLine("You have written your password wrong");
                            Console.WriteLine("too many times. Press any button to continue.");
                            input = Console.ReadLine();
                            if (input2 != null)
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
        }
        static void CreateAccount(List<Account> accounts)
        {
            Console.WriteLine($"{accounts.Count} accounts");
        }

        static void MainAccount(int index)
        {
            Console.WriteLine("hei");
            //starter på start page på nytt og tar input og angir som feil med en gang. 
        }

        //static void Login(List<Account> accounts, string currentName)
        //{
        //    Console.WriteLine("Please enter your lastname.");
        //    var input = Console.ReadLine();
        //    foreach (var person in accounts)
        //    {
        //        if (person.FirstName == currentName && input == person.LastName)
        //        {

        //        }
        //        else
        //        {
        //            Console.WriteLine("Wrong input detected. Please try again or");
        //            Console.WriteLine("write 'back' to the start menu.");
        //            input = Console.ReadLine();
        //            if (input == "back")
        //            {
        //                Console.WriteLine("Please enter your firstname to log in");
        //                Console.WriteLine("OR");
        //                Console.WriteLine("write 'new user' to create account.");
        //                StartPage(accounts);
        //            }
        //            else if (person.FirstName == currentName && input == person.LastName)
        //            {
        //                PasswordCheck(accounts, person.FirstName, person.LastName);
        //            }
        //            else
        //            {
        //                Console.WriteLine("You have written your lastname wrong");
        //                Console.WriteLine("too many times. Press any button to continue.");
        //                input = Console.ReadLine();
        //                if (input != null)
        //                {
        //                    Console.WriteLine("Please enter your firstname to log in");
        //                    Console.WriteLine("OR");
        //                    Console.WriteLine("write 'new user' to create account.");
        //                    StartPage(accounts);
        //                }
        //            }
        //        }

        //    }
        //}
    }
}