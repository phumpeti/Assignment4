using Assignment4C;

namespace PhoneBookApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of PhoneBook
            PhoneBook phoneBook = new PhoneBook();

            // The PhoneBook constructor will automatically display the list, sort it, and display the table

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
