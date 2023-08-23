namespace SampleSOLIDConcepts
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of payment methods
            var creditCardPayment = new CreditCardPayment("John Doe", "1234-5678-9012-3456", "123", DateTime.Now.AddYears(2));
            var payPalPayment = new PayPalPayment("example@example.com", "password123");

            // Configure payment methods
            var paymentMethods = new List<IPaymentGateway> { creditCardPayment, payPalPayment };
            var paymentProcessor = new PaymentProcessor(paymentMethods);

            // Process payments using the configured payment methods
            paymentProcessor.ProcessPayments(100.00);  // OCP: Extending with new payment methods.
        }
    }
}

