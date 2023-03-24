namespace FriendFace
{
    public class MainNetwork
    {
        public static void MainPage(Profile currentProfile, List<Profile> ListOfUsers)
        {
            Console.Clear();
            MenuBar.Menu();
            Console.WriteLine($"Velkommen {currentProfile.FirstName} {currentProfile.LastName}.\n");
            Console.WriteLine($"Friends: {currentProfile.GetFriendlistCount()}");
            MenuBar.MenuCommands(currentProfile, ListOfUsers);
        }
        public static void ShowNewPeople(Profile currentProfile, List<Profile> ListOfUsers)
        {
            Console.Clear();
            Console.WriteLine("Write the number to add to friend list.\n");
            foreach (Profile profile in ListOfUsers)
            {
                if (profile != currentProfile) Console.WriteLine($"{profile.ID} - {profile.FirstName} {profile.LastName}.");
            }
            var chosenProfile = Console.ReadLine();
            foreach (Profile profile in ListOfUsers)
            {
                if (Convert.ToInt32(chosenProfile) == profile.ID)
                {
                    currentProfile.AddFriend(profile);
                    Console.WriteLine("Friend added!\n");
                    Thread.Sleep(2000);
                    ShowNewPeople(currentProfile, ListOfUsers);
                }
                if (chosenProfile != null)
                {
                    Console.WriteLine("Uanble to read command. Returning to main page.\n");
                    Thread.Sleep(2000);
                    MainPage(currentProfile, ListOfUsers);
                }
            }
        }
        public static void ShowFriends(Profile currentProfile, List<Profile> ListOfUsers)
        {
            Console.Clear();
            Console.WriteLine("NUMBER - delete friend");
            Console.WriteLine("or anything else to return\n");
            foreach (Profile friend in currentProfile.Friends)
            {
                Console.WriteLine($"{friend.ID} - {friend.FirstName} {friend.LastName}.");
            }
            var choiceInput = Console.ReadLine();
            foreach (Profile friend in currentProfile.Friends)
            {
                if (Convert.ToInt32(choiceInput) == friend.ID) currentProfile.RemoveFriend(friend);
                else MainPage(currentProfile, ListOfUsers);
            }
            ShowFriends(currentProfile, ListOfUsers);
        }
    }
}

