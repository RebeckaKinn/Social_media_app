namespace FriendFace
{
    public class MainNetwork
    {
        public static void MainPage(Profile currentProfile, List<Profile> ListOfUsers)
        {
            Console.Clear();
            Console.WriteLine($"Velkommen {currentProfile.FirstName} {currentProfile.LastName}.\n");
            Console.WriteLine($"Friends: {currentProfile.GetFriendlistCount()}");
            MenuBar.Menu(currentProfile, ListOfUsers);
        }
        public static void ShowNewPeople(Profile currentProfile, List<Profile> ListOfUsers)
        {
            foreach (Profile profile in ListOfUsers)
            {
                if (profile != currentProfile) Console.WriteLine($"{profile.ID} - {profile.FirstName} {profile.LastName}.");
            }
            Console.WriteLine("Write the number to add to friend list.");
            var chosenProfile = Convert.ToInt32(Console.ReadLine());
            foreach (Profile profile in ListOfUsers)
            {
                if (chosenProfile == profile.ID)
                {
                    currentProfile.AddFriend(profile);
                    Console.WriteLine("Friend added!\n");
                    ShowNewPeople(currentProfile, ListOfUsers);
                    MenuBar.MenuCommands(currentProfile, ListOfUsers);
                }
                else if (chosenProfile != profile.ID)
                {
                    Console.WriteLine("Uanble to read command. Returning to main page.\n");
                    MainPage(currentProfile, ListOfUsers);
                }
            }
        }
        public static void ShowFriends(Profile currentProfile)
        {
            foreach (Profile friend in currentProfile.Friends)
            {
                Console.WriteLine($"{friend.ID} - {friend.FirstName} {friend.LastName}.");
            }

        }
    }
}

