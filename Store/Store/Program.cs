namespace Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("Pillow", 99.99);
            p.Display();
            EProduct e = new EProduct("Fridge", 499.99, "Haier", 5);
            e.Display();
            Smartphone s = new Smartphone("Smartphone", 50000, "iPhone", 1, "iOS");
            s.Display();
        }
    }
}
