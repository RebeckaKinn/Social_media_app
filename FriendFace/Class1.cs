namespace FriendFace
{
    public class Account
    {
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public string? email { get; set; }
        public string? password { get; set; }

    }

    public class User
    {
        public List<Account> accounts { get; set; } = new List<Account>();
        public User()
        {
            CreateAccountList();
        }

        public void CreateAccountList()
        {
            accounts.Add(new Account { firstName = "Liam", lastName = "Sørensen", email = "liam@email.com", password = "passord123" });
            accounts.Add(new Account { firstName = "Elisabeth", lastName = "Olsen", email = "elisabeth@email.com", password = "passord123" });
            accounts.Add(new Account { firstName = "Jørgen", lastName = "Aalvang", email = "jorgen@email.com", password = "123passord" });
            accounts.Add(new Account { firstName = "Anne Marie", lastName = "Augustus", email = "anne-marie@email.com", password = "123passord" });
        }
    }
}
