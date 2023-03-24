namespace FriendFace
{
    public class UserList
    {
        public List<Profile> ListOfUsers { get; set; }
        public UserList()
        {
            ListOfUsers = new List<Profile>
            {
                new Profile("Liam", "Sørensen", "liam@email.com", "passord123"),
                new Profile("Elisabeth", "Olsen", "elisabeth@email.com", "passord123"),
                new Profile("Jørgen", "Aalvang", "jorgen@email.com", "123passord"),
                new Profile("Anne Marie", "Augustus", "anne-marie@email.com", "123passord")
            };
        }

        public Profile GetUserProfile(int id)
        {
            return ListOfUsers.FirstOrDefault(user => user.ID == id);
        }

        public Profile GetLoggedInProfile(string email)
        {
            return ListOfUsers.FirstOrDefault(user => user.Email == email);
        }
    }
}
