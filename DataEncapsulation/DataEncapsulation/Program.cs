namespace DataEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "alice";
            person.Age = 25;
            Console.WriteLine($"the name is {person.Name} and the age is {person.Age}");
        }
    }
}
