namespace FriendFace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user = new();
            Console.WriteLine("WELCOME TO FRIENDFACE - THE ONLY SOCIAL PLATFORM YOU NEED");
            Console.WriteLine(user.accounts[0].firstName);
        }
    }
}