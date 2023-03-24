namespace FriendFace
{
    public class StartPage
    {
        public void Start(List<Profile> ListOfUsers)
        {
            foreach (var line in WriteLines.intro)
            {
                Console.WriteLine(line);
            }
            var input = Console.ReadLine();
            foreach (var person in ListOfUsers)
            {
                if (input == person.Email)
                {
                    Console.WriteLine("Please enter your password.");
                    PasswordCheck(person, ListOfUsers);
                }
                else if (input.ToLower() == "new user")
                {
                    CreateAccountByInput(ListOfUsers);
                }
                else
                {
                    Console.WriteLine("Please enter a valid answer below.");
                    Start(ListOfUsers);
                }
            }
        }
        public static void PasswordCheck(Profile currentProfile, List<Profile> ListOfUsers)
        {
            var input = Console.ReadLine();
            if (currentProfile.Password == input)
            {
                MainNetwork.MainPage(currentProfile, ListOfUsers);
            }
            else
            {
                if (input == "back") Program.Main();
                Console.WriteLine("Try again or write 'back' to restart.");
                PasswordCheck(currentProfile, ListOfUsers);
            }
        }
        public static void CreateAccountByInput(List<Profile> ListOfUsers)
        {
            Console.Clear();
            foreach (string choice in WriteLines.createAccount)
            {
                Console.WriteLine(choice);
            }
            var firstNameInput = Console.ReadLine();
            string? firstname = Convert.ToString(firstNameInput);

            Console.WriteLine("Please enter your lastname.");
            var lastNameInput = Console.ReadLine();
            string? lastname = Convert.ToString(lastNameInput);

            Console.WriteLine("Please enter your prefered E-mail adress.");
            var eMailInput = Console.ReadLine();
            string? email = Convert.ToString(eMailInput);

            Console.WriteLine("Please enter a password.");
            var password1Input = Console.ReadLine();
            string? password1 = Convert.ToString(password1Input);

            Console.WriteLine("Please right your password again.");
            var password2Input = Console.ReadLine();
            string? password2 = Convert.ToString(password2Input);
            if (password1 != password2)
            {
                Console.WriteLine("Password not matching. Try again.");
                CreateAccountByInput(ListOfUsers);
            }
            else
            {
                Console.WriteLine($"Name: {firstname} {lastname}. E-mail: {email}. Password: {password1}\n");
                foreach (string choice in WriteLines.checkAccount)
                {
                    Console.WriteLine(choice);
                }
                var endInput = Console.ReadLine();
                if (endInput.ToLower() == "yes")
                {
                    var addUserToList = new Profile(firstname, lastname, email, password1);
                    Console.WriteLine("NEW USER CREATED...\n");
                    Thread.Sleep(2000);
                    MainNetwork.MainPage(addUserToList, ListOfUsers);
                }
                else
                {
                    Console.WriteLine("Returning...\n");
                    Thread.Sleep(2000);
                    Console.Clear();
                    var newStart = new StartPage();
                    newStart.Start(ListOfUsers);
                }
            }
        }
        public static void LogOut(List<Profile> ListOfUsers)
        {
            Console.WriteLine("You are now logged out...\n");
            Thread.Sleep(2000);
            Console.Clear();
            var newStart = new StartPage();
            newStart.Start(ListOfUsers);
        }
    }
}
