namespace FriendFace
{
    public class MainNetwork
    {
        public static void MainPage(Profile currentProfile)
        {
            Console.Clear();
            Console.WriteLine($"Velkommen {currentProfile.FirstName} {currentProfile.LastName}.\n");
            Console.WriteLine($"Friends: {currentProfile.GetFriendlistCount()}");
            MenuBar.Menu();
        }
        public static void ShowNewPeople(Profile currentProfile, List<Profile> ListOfUsers)
        {
            foreach (Profile profile in ListOfUsers)
            {
                if (profile != currentProfile) Console.WriteLine($"{profile.ID} - {profile.FirstName} {profile.LastName}.");
            }
            Console.WriteLine("Write the number to add to friend list.");
            var chosenProfile = Console.ReadLine();
            foreach (Profile profile in ListOfUsers)
            {
                if (Convert.ToInt32(chosenProfile) == profile.ID)
                {
                    currentProfile.AddFriend(profile);
                    Console.WriteLine("Friend added!\n");
                    ShowNewPeople(currentProfile, ListOfUsers);
                    MenuBar.MenuCommands(currentProfile, ListOfUsers);
                }
                else
                {
                    Console.WriteLine("Uanble to read command. Returning to main page.\n");
                    Thread.Sleep(2000);
                    MainPage(currentProfile);
                }
            }
        }
        public static void ShowFriends(Profile currentProfile)
        {
            foreach (Profile friend in currentProfile.Friends)
            {
                Console.WriteLine($"{friend.ID} - {friend.FirstName} {friend.LastName}.");
            }
            Console.WriteLine("NUMBER - delete friend");
            Console.WriteLine("BACK - back to main page");
            var choiceInput = Console.ReadLine();
            foreach (Profile friend in currentProfile.Friends)
            {
                if (Convert.ToInt32(choiceInput) == friend.ID) currentProfile.RemoveFriend(friend);
                else if (choiceInput == "back") MainPage(currentProfile);
                else ShowFriends(currentProfile);
            }
        }
    }
}

