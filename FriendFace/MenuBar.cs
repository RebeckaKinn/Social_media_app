namespace FriendFace
{
    public static class MenuBar
    {
        static public void Menu()
        {
            foreach (var choice in MainMenu.menu)
            {
                Console.WriteLine(choice);
            }
        }
        static public void MenuCommands(int index)
        {
            var currentUser = Console.ReadLine();
            if (currentUser == "main") LoggedIn.MainAccount(index);
            else if (currentUser == "friends") LoggedIn.ShowFriends(index);
            else if (currentUser == "add") LoggedIn.ShowNewFriends(index);
            else if (currentUser == "feed") LoggedIn.ShowFeed(index);
            else if (currentUser == "chat") LoggedIn.ShowChat(index);
            else if (currentUser == "log out") LoggedIn.LogOut(index);
            else
            {
                Menu();
                MenuCommands(index);
            };
        }
    }
}
