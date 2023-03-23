//namespace FriendFace
//{
//    public class Account
//    {
//        //lage static? og private!
//        private string FirstName { get; }
//        private string LastName { get; }
//        private string Email { get; }
//        private string Password;
//        private int ID { get; }
//        private static int NextID = 0;
//        public Account(string firstName, string lastName, string email, string password)
//        {
//            FirstName = firstName;
//            LastName = lastName;
//            Email = email;
//            Password = password;
//            ID = NextID;
//            NextID++;
//        }

//        public void Identify()
//        {
//            Console.WriteLine($"Navn: {FirstName}. Min ID: {ID}");
//        }
//    }

//    //ha metoder for å hente ut informasjon
//    public class Users
//    {
//        //fjerne static?
//        public List<Account> Accounts { get; set; } = new List<Account>();
//        public Users()
//        {
//            CreateAccountList();
//        }
//        public void CreateAccountList()
//        {
//            Accounts.Add(new Account("Liam", "Sørensen", "liam@email.com", "passord123"));
//            Accounts.Add(new Account("Elisabeth", "Olsen", "elisabeth@email.com", "passord123"));
//            Accounts.Add(new Account("Jørgen", "Aalvang", "jorgen@email.com", "123passord"));
//            Accounts.Add(new Account("Anne Marie", "Augustus", "anne-marie@email.com", "123passord"));
//            Accounts.ForEach(e => e.Identify());
//        }
//    }
//}
