namespace FriendFace
{
    public class Account
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Password { get; set; }

    }

    public class User
    {
        public List<Account> Accounts { get; set; } = new List<Account>();
        public User()
        {
            CreateAccountList();
        }

        public void CreateAccountList()
        {
            Accounts.Add(new Account { FirstName = "Liam", LastName = "Sørensen", Email = "liam@email.com", Password = "passord123" });
            Accounts.Add(new Account { FirstName = "Elisabeth", LastName = "Olsen", Email = "elisabeth@email.com", Password = "passord123" });
            Accounts.Add(new Account { FirstName = "Jørgen", LastName = "Aalvang", Email = "jorgen@email.com", Password = "123passord" });
            Accounts.Add(new Account { FirstName = "Anne Marie", LastName = "Augustus", Email = "anne-marie@email.com", Password = "123passord" });
        }
    }
}
