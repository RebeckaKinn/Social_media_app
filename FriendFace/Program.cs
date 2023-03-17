namespace FriendFace
{
    internal class Program
    {

        static void Main(string[] args)
        {
            IntroLines introLines = new IntroLines();
            List<string> intro = introLines.intro;
            User user = new();
            Console.WriteLine("WELCOME TO FRIENDFACE - THE ONLY SOCIAL PLATFORM YOU NEED");
            Console.WriteLine("");
            Console.WriteLine("Welcome!");
            foreach (var line in intro)
            {
                Console.WriteLine(line);
            }
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
        static void PasswordCheck(List<Account> accounts, string? email)
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
                                IntroLines introLines = new IntroLines();
                                List<string> intro = introLines.intro;
                                foreach (var line in intro)
                                {
                                    Console.WriteLine(line);
                                }
                                StartPage(accounts);
                            }
                        }
                    }
                }
            }
        }
        static void CreateAccount(List<Account> accounts)
        {
            CreateAccountLines lines = new CreateAccountLines();
            List<string> createAccount = lines.createAccount;
            foreach (var line in createAccount)
            {
                Console.WriteLine(line);
            }
            var firstName = Console.ReadLine();
            string? firstname = Convert.ToString(firstName);
            Console.WriteLine("Please enter your lastname.");
            var lastName = Console.ReadLine();
            string? lastname = Convert.ToString(lastName);
            Console.WriteLine("Please enter your prefered E-mail adress.");
            var eMail = Console.ReadLine();
            string? email = Convert.ToString(eMail);
            Console.WriteLine("Please enter a password.");
            var password1Input = Console.ReadLine();
            string? password1 = Convert.ToString(password1Input);
            Console.WriteLine("Please right your password again.");
            var password2Input = Console.ReadLine();
            string? password2 = Convert.ToString(password2Input);
            if (password1 == password2)
            {
                Console.WriteLine("Great! We have everything we need to make you a new profile!");
                Console.WriteLine($"Name: {firstname} {lastname}. E-mail: {email}. Password: {password1}");
                CheckAccountLines writeLine = new CheckAccountLines();
                List<string> checkAccount = writeLine.checkAccount;
                foreach (var line in checkAccount)
                {
                    Console.WriteLine(line);
                }
                StartPage(accounts);
                var choice = Console.ReadLine();
                if (choice == "yes")
                {
                    int IDNumber = accounts.Count;
                    accounts.Add(new Account { ID = IDNumber, FirstName = firstname, LastName = lastname, Email = email, Password = password1 });
                    UpdateAccountLines write = new UpdateAccountLines();
                    List<string> uploadAccount = write.uploadAccount;
                    foreach (var line in uploadAccount)
                    {
                        Console.WriteLine(line);
                    }
                    StartPage(accounts);
                }
                else if (choice == "back")
                {
                    CreateAccount(accounts);
                }
                else
                {
                    DispatchAccountLines write = new DispatchAccountLines();
                    List<string> dispatchAccount = write.dispatchAccount;
                    foreach (var line in dispatchAccount)
                    {
                        Console.WriteLine(line);
                    }
                    StartPage(accounts);
                }
            }

        }

        static void Menu()
        {
            Menu menu = new Menu();
            List<string> choices = menu.menu;
            foreach (var choice in choices)
            {
                Console.WriteLine(choice);
            }
        }

        static void MenuCommands(int index)
        {
            var currentUser = Console.ReadLine();
            if (currentUser == "main") MainAccount(index);
            else if (currentUser == "friends") ShowFriends(index);
            else if (currentUser == "add") ShowNewFriends(index);
            else if (currentUser == "feed") ShowFeed(index);
            else if (currentUser == "chat") ShowChat(index);
            else if (currentUser == "log out") LogOut(index);
            else Menu();
        }

        static void MainAccount(int index)
        {
            Menu();
            User user = new();
            List<Account> accounts = user.Accounts;
            Console.WriteLine($"Welcome {accounts[index].FirstName} {accounts[index].LastName} to your main page.");
            Console.WriteLine("You can redirect anywhere at any time by using the menu commands above.");

            Friend count = new Friend();
            List<int> Friends = count.Friends;
            if (Friends.Contains(accounts[index].ID))
            {
                Console.WriteLine($"You have {Friends.Count} friends.");
            }

            MenuCommands(index);
        }

    }
}