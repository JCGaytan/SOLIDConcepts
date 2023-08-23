namespace SampleSOLIDConcepts
{
    /// <summary>
    /// Represents a payment method using PayPal.
    /// </summary>
    public class PayPalPayment : PaymentMethod
    {
        private string email;
        private string password;

        /// <summary>
        /// Initializes a new instance of the <see cref="PayPalPayment"/> class.
        /// </summary>
        /// <param name="email">The PayPal email address.</param>
        /// <param name="password">The PayPal password.</param>
        public PayPalPayment(string email, string password)
        {
            this.email = email;
            this.password = password;
        }

        /// <inheritdoc />
        public override bool ProcessPayment(double amount)
        {
            // Implement PayPal payment processing logic here.
            Console.WriteLine($"Processing PayPal payment of ${amount}.");
            return true; // Placeholder return value.
        }
    }
}
