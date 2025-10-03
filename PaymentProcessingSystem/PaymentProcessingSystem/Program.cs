namespace PaymentProcessingSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment creditCardPayment = new CreditCardPayment(4500, DateTime.Now, "564987654", "shanell");
            creditCardPayment.ProcessPayment();

            Payment upiPayment = new UPIPayment(400, DateTime.Now, "canarabank.upi", "canara Bank");
            upiPayment.ProcessPayment();
        }
    }
}
