namespace FriendFace
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO FRIENDFACE - THE ONLY SOCIAL PLATFORM YOU NEED");
            Console.WriteLine("");
            Console.WriteLine("Welcome!");
            foreach (var line in IntroLines.intro)
            {
                Console.WriteLine(line);
            }
            StartPage();
        }

        //REFER FRIENDS AND ACCOUNTS SO THAT IT DOES NOT MAKE A NEW ONE EACH TIME. 
        static void StartPage()
        {
            var input = Console.ReadLine();
            foreach (var person in User.Accounts)
            {
                if (input == person.Email)
                {
                    Console.WriteLine("Please enter your password.");
                    PasswordCheck(person.Email);
                }
                else if (input == "new user")
                {
                    CreateAccount();
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer below.");
                    StartPage();
                }
            }

        }
        static void PasswordCheck(string? email)
        {
            var input = Console.ReadLine();
            foreach (var account in User.Accounts.Select((value, i) => (value, i)))
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
                                foreach (var line in IntroLines.intro)
                                {
                                    Console.WriteLine(line);
                                }
                                StartPage();
                            }
                        }
                    }
                }
            }
        }
        static void CreateAccount()
        {
            foreach (var line in CreateAccountLines.createAccount)
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
                foreach (var line in CheckAccountLines.checkAccount)
                {
                    Console.WriteLine(line);
                }
                StartPage();
                var choice = Console.ReadLine();
                if (choice == "yes")
                {
                    int IDNumber = User.Accounts.Count;
                    User.Accounts.Add(new Account { ID = IDNumber, FirstName = firstname, LastName = lastname, Email = email, Password = password1 });
                    foreach (var line in UpdateAccountLines.uploadAccount)
                    {
                        Console.WriteLine(line);
                    }
                    StartPage();
                }
                else if (choice == "back")
                {
                    CreateAccount();
                }
                else
                {
                    foreach (var line in DispatchAccountLines.dispatchAccount)
                    {
                        Console.WriteLine(line);
                    }
                    StartPage();
                }
            }

        }

        static void Menu()
        {
            foreach (var choice in MainMenu.menu)
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
            else
            {
                Menu();
                MenuCommands(index);
            };
        }

        static void MainAccount(int index)
        {
            Menu();
            Console.WriteLine($"Welcome {User.Accounts[index].FirstName} {User.Accounts[index].LastName} to your main page.");
            Console.WriteLine("You can redirect anywhere at any time by using the menu commands above.");
            if (Friend.Friends.Contains(User.Accounts[index].ID))
            {
                int myFriends = Friend.Friends.Count - 1;
                Console.WriteLine($"You have {myFriends} friends.");
            }
            MenuCommands(index);
        }

        static void ShowFriends(int index)
        {
            Console.WriteLine("YOUR FRIENDS");
            Console.WriteLine("----------------------");
            if (Friend.Friends.Contains(User.Accounts[index].ID))
            {
                foreach (var users in User.Accounts)
                    foreach (var friend in Friend.Friends)
                    {
                        if (friend == users.ID && friend != User.Accounts[index].ID)
                            Console.WriteLine($"{users.FirstName} {users.LastName}");
                    }
            }
            MenuCommands(index);
        }

        static void ShowNewFriends(int index)
        {
            Console.WriteLine("Find new people!");
            Console.WriteLine("________________");
            CheckList();
            if (CheckList() == false)
            {
                for (int i = 0; i < User.Accounts.Count; i++)
                {
                    if (!Friend.Friends.Contains(User.Accounts[i].ID))
                    {
                        Console.WriteLine($"{User.Accounts[i].FirstName} {User.Accounts[i].LastName}.");
                    }
                }
                Console.WriteLine("Write the whole name to add, or 'back' to your page.");
                NewChoiceInput(index);
            }
            else
            {
                Console.WriteLine("NO MORE PEOPLE TO ADD");
                MenuCommands(index); ;
            }
        }

        static void NewChoiceInput(int index)
        {
            var newChoice = Console.ReadLine();
            for (int i = 0; i < User.Accounts.Count; i++)
            {
                if (newChoice == $"{User.Accounts[i].FirstName} {User.Accounts[i].LastName}")
                {
                    Friend.Friends.Add(User.Accounts[i].ID);
                    Console.WriteLine("Added!");
                    ShowNewFriends(index);
                }
            }
            if (newChoice == "back") MainAccount(index);
            else
            {
                Console.WriteLine("Try again.");
                NewChoiceInput(index);
            }
        }

        public static bool CheckList()
        {
            bool areEqual = true;
            for (int i = 0; i < User.Accounts.Count; i++)
            {
                if (!Friend.Friends.Contains(User.Accounts[i].ID))
                {
                    areEqual = false;
                    break;
                }
            }
            return areEqual;
        }
        static void ShowFeed(int index)
        {
            MenuCommands(index);
        }
        static void ShowChat(int index)
        {
            MenuCommands(index);
        }

        static void LogOut(int index)
        {
            Console.WriteLine($"You are now logged out of {User.Accounts[index].FirstName} {User.Accounts[index].LastName}'s account.");
            Console.WriteLine("Welcome back soon!");
            Console.WriteLine("____________________________________");
            foreach (var line in IntroLines.intro)
            {
                Console.WriteLine(line);
            }
            StartPage();
        }

    }
}