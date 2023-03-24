namespace FriendFace
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("WELCOME TO FRIENDFACE - THE ONLY SOCIAL PLATFORM YOU NEED\n");
            Console.WriteLine("Welcome!");
            var userList = new UserList();
            var startPage = new StartPage();
            startPage.Start(userList.ListOfUsers);
        }
    }
}