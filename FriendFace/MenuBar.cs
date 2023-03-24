namespace FriendFace
{
    internal class MenuBar
    {
        public static void Menu(Profile currentProfile, List<Profile> ListOfUsers)
        {
            foreach (string choice in WriteLines.menu)
            {
                Console.WriteLine(choice);
            }
            MenuCommands(currentProfile, ListOfUsers);
        }
        public static void MenuCommands(Profile currentProfile, List<Profile> ListOfUsers)
        {
            var currentUser = Console.ReadLine();
            if (currentUser == "main") MainNetwork.MainPage(currentProfile, ListOfUsers);
            else if (currentUser == "friends") MainNetwork.ShowFriends(currentProfile);
            else if (currentUser == "new") MainNetwork.ShowNewPeople(currentProfile, ListOfUsers);
            else if (currentUser == "log out") StartPage.LogOut(ListOfUsers);
            else
            {
                Console.WriteLine("Write a valid answer.");
                MenuCommands(currentProfile, ListOfUsers);
            };
        }
    }
}
