namespace FriendFace
{
    public static class LoggedIn
    {
        public static void MainAccount(int index)
        {
            MenuBar.Menu();
            Console.WriteLine($"Welcome {User.Accounts[index].FirstName} {User.Accounts[index].LastName} to your main page.");
            Console.WriteLine("You can redirect anywhere at any time by using the menu commands above.");
            if (Friend.Friends.Contains(User.Accounts[index].ID))
            {
                int myFriends = Friend.Friends.Count - 1;
                Console.WriteLine($"You have {myFriends} friends.");
            }
            MenuBar.MenuCommands(index);
        }

        public static void ShowFriends(int index)
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
            MenuBar.MenuCommands(index);
        }

        public static void ShowNewFriends(int index)
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
                MenuBar.MenuCommands(index); ;
            }
        }

        public static void NewChoiceInput(int index)
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
        public static void ShowFeed(int index)
        {
            MenuBar.MenuCommands(index);
        }
        public static void ShowChat(int index)
        {
            MenuBar.MenuCommands(index);
        }

        public static void LogOut(int index)
        {
            Console.WriteLine($"You are now logged out of {User.Accounts[index].FirstName} {User.Accounts[index].LastName}'s account.");
            Console.WriteLine("Welcome back soon!");
            Console.WriteLine("____________________________________");
            foreach (var line in IntroLines.intro)
            {
                Console.WriteLine(line);
            }
            Program.StartPage();
        }
    }
}
