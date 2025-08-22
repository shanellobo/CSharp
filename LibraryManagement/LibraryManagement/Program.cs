namespace LibraryManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Books b = new Books("Tinkle", "Anant Pai");
            b.DisplayDetails();
            Books e = new EBook("Atomic Habits", "James Clear", 100, "ATH");
            e.DisplayDetails();
        }
    }
}
