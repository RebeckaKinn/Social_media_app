namespace FriendFace
{
    public class IntroLines
    {
        public static List<string> intro = new List<string>
        {
            "Please enter your E-mail to log in",
            "OR",
            "write 'new user' to create account.",

        };

    }

    public class CreateAccountLines
    {
        public static List<string> createAccount = new List<string>
        {
            "Welcome to your start of your FRIENDFACE journey!",
            "Please write your information carefully.",
            "",
            "Please enter your firstname.",
        };
    }

    public class UpdateAccountLines
    {
        public static List<string> uploadAccount = new List<string>
        {
            "Account saved! Please log in.",
            "----------------------",
            "Please enter your E-mail to log in",
            "OR",
            "write 'new user' to create account.",
        };
    }

    public class DispatchAccountLines
    {
        public static List<string> dispatchAccount = new List<string>
        {
            "No changes were saved.",
            "----------------------",
            "Please enter your E-mail to log in",
            "OR",
            "write 'new user' to create account.",
        };
    }

    public class CheckAccountLines
    {
        public static List<string> checkAccount = new List<string>
        {
            "",
            "Write:",
            "YES - confirm account and log in.",
            "BACK - back to create account.",
            "or anything else to restart the prosess.",
        };
    }

    public class Menu
    {
        public static List<string> menu = new List<string>
        {
            "_________________________",
            "MENU COMMANDS:",
            "",
            "MAIN - back to main page",
            "FRIENDS - view friends",
            "ADD - find new people",
            "FEED - comments and news",
            "CHAT - chat with a friend",
            "LOG OUT",
            "-------------------------"
        };
    }
}
