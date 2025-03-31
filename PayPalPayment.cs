public class PayPalPayment : IPayment
{
    public void Pay() => Console.WriteLine("Payment was made by PayPal.");
}