namespace FriendFace
{
    public static class Program
    {
        //static public void Main(string[] args)
        //{
        //    Console.WriteLine("WELCOME TO FRIENDFACE - THE ONLY SOCIAL PLATFORM YOU NEED");
        //    Console.WriteLine("");
        //    Console.WriteLine("Welcome!");
        //    foreach (var line in IntroLines.intro)
        //    {
        //        Console.WriteLine(line);
        //    }
        //    StartPage();
        //}

        //static public void StartPage()
        //{
        //    var input = Console.ReadLine();
        //    foreach (var person in User.Accounts)
        //    {
        //        if (input == person.Email)
        //        {
        //            Console.WriteLine("Please enter your password.");
        //            PasswordCheck(person.Email);
        //        }
        //        else if (input == "new user")
        //        {
        //            CreateAccount();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Please enter a valid answer below.");
        //            StartPage();
        //        }
        //    }
        //}
        //KOMMER IKKE LENGRE ENN Å SKRIVE INN EPOST OG SÅ SLUTTER DEN. HVORFOR SENDER DEN IKKE BRUKEREN VIDERE TIL PASSWORDCHECK????
        //begynte å gjøre det etter at jeg hentet inn listene og ikke laget nye hver gang, og da jeg satte class til public/static. 
        //static public void PasswordCheck(string? email)
        //{
        //    var input = Console.ReadLine();
        //    foreach (var account in User.Accounts.Select((value, i) => (value, i)))
        //    {
        //        if (account.value.Email == email)
        //        {
        //            if (input == account.value.Password)
        //            {
        //                LoggedIn.MainAccount(account.i);
        //            }
        //            else
        //            {
        //                Console.WriteLine("Wrong password. Please try again.");
        //                var input2 = Console.ReadLine();

        //                if (input2 == account.value.Password)
        //                {
        //                    LoggedIn.MainAccount(account.i);
        //                }
        //                else
        //                {
        //                    Console.WriteLine("You have written your password wrong");
        //                    Console.WriteLine("too many times. Press any button to continue.");
        //                    input = Console.ReadLine();
        //                    if (input2 != null)
        //                    {
        //                        foreach (var line in IntroLines.intro)
        //                        {
        //                            Console.WriteLine(line);
        //                        }
        //                        StartPage();
        //                    }
        //                }
        //            }
        //        }
        //    }
        //}
        static public void CreateAccount()
        {
            foreach (var line in CreateAccountLines.createAccount)
            {
                Console.WriteLine(line);
            }
            //var firstName = Console.ReadLine();
            //string? firstname = Convert.ToString(firstName);
            //Console.WriteLine("Please enter your lastname.");
            //var lastName = Console.ReadLine();
            //string? lastname = Convert.ToString(lastName);
            //Console.WriteLine("Please enter your prefered E-mail adress.");
            //var eMail = Console.ReadLine();
            //string? email = Convert.ToString(eMail);
            //Console.WriteLine("Please enter a password.");
            //var password1Input = Console.ReadLine();
            //string? password1 = Convert.ToString(password1Input);
            //Console.WriteLine("Please right your password again.");
            //var password2Input = Console.ReadLine();
            //string? password2 = Convert.ToString(password2Input);
            if (password1 == password2)
            {
                Console.WriteLine("Great! We have everything we need to make you a new profile!");
                Console.WriteLine($"Name: {firstname} {lastname}. E-mail: {email}. Password: {password1}");
                foreach (var line in CheckAccountLines.checkAccount)
                {
                    Console.WriteLine(line);
                }
                StartPage();
                var choice = Console.ReadLine();
                if (choice == "yes")
                {
                    int IDNumber = User.Accounts.Count;
                    User.Accounts.Add(new Account { ID = IDNumber, FirstName = firstname, LastName = lastname, Email = email, Password = password1 });
                    foreach (var line in UpdateAccountLines.uploadAccount)
                    {
                        Console.WriteLine(line);
                    }
                    StartPage();
                }
                else if (choice == "back")
                {
                    CreateAccount();
                }
                else
                {
                    foreach (var line in DispatchAccountLines.dispatchAccount)
                    {
                        Console.WriteLine(line);
                    }
                    StartPage();
                }
            }
        }

    }
}