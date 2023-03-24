namespace FriendFace
{
    public class Profile
    {
        public string FirstName;
        public string LastName;
        public string Email;
        public string Password;
        public List<Profile> Friends { get; set; }
        public int ID;
        public static int NextID = 0;
        public Profile(string firstName, string lastName, string email, string password)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            Password = password;
            Friends = new List<Profile>();
            ID = NextID;
            NextID++;
        }
        public void ShowFriends()
        {
            foreach (var friend in Friends)
            {
                Console.WriteLine($"{friend.ID} - {friend.FirstName} {friend.LastName}.");
            }
        }
        public int GetFriendlistCount()
        {
            return Friends.Count;
        }
        public void AddFriend(Profile addFriend)
        {
            Friends.Add(addFriend);
        }
        public void RemoveFriend(Profile removedFriend)
        {
            Friends.Remove(removedFriend);
        }
    }
}
