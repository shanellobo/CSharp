namespace DataEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("enter a name");
            string name=Console.ReadLine();

            Console.WriteLine("enter a age");
            int number=int.Parse(Console.ReadLine());

            person.Age = number;
            person.Name = name;

            Console.WriteLine($"the name is {person.Name} and the age is {person.Age}");
        }
    }
}

