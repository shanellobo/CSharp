namespace Constructors
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a Person object
            Person person = new Person("Alice", 30);

            // Create an Address object
            Address address = new Address("123 Main St", "New York");

            // Display the information
            person.DisplayInfo();
            address.DisplayAddress();

            Console.ReadLine(); // Keep console open
        }
    }
}
