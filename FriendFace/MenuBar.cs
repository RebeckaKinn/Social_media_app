namespace FriendFace
{
    internal class MenuBar
    {
        public static void Menu()
        {
            foreach (string choice in WriteLines.menu)
            {
                Console.WriteLine(choice);
            }
        }
        public static void MenuCommands(Profile currentProfile, List<Profile> ListOfUsers)
        {
            var currentUser = Console.ReadLine();
            if (currentUser.ToLower() == "main") MainNetwork.MainPage(currentProfile, ListOfUsers);
            else if (currentUser.ToLower() == "friends") MainNetwork.ShowFriends(currentProfile, ListOfUsers);
            else if (currentUser.ToLower() == "new") MainNetwork.ShowNewPeople(currentProfile, ListOfUsers);
            else if (currentUser.ToLower() == "log out") StartPage.LogOut(ListOfUsers);
            else
            {
                Console.WriteLine("Write a valid answer.");
                MenuCommands(currentProfile, ListOfUsers);
            };
        }
    }
}
