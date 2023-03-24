namespace FriendFace
{
    public class WriteLines
    {
        public static List<string> intro = new List<string>
        {
            "Please enter your E-mail to log in",
            "OR",
            "write 'new user' to create account.\n",
        };

        public static List<string> createAccount = new List<string>
        {
            "Welcome to your start of your FRIENDFACE journey!",
            "Please write your information carefully.\n",
            "Please enter your firstname.\n",
        };

        public static List<string> dispatchAccount = new List<string>
        {
            "No changes were saved.",
            "----------------------\n",
        };

        public static List<string> checkAccount = new List<string>
        {
            "Write:",
            "YES - confirm.",
            "or press anything to restart.\n",
        };

        public static List<string> menu = new List<string>
        {
            "_________________________",
            "MENU COMMANDS:\n",
            "MAIN    - back to main page",
            "FRIENDS - view friends",
            "NEW     - find new people",
            "LOG OUT",
            "-------------------------\n"
        };
    }
}
