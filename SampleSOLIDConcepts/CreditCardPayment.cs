namespace SampleSOLIDConcepts
{
    /// <summary>
    /// Represents a payment method using a credit card.
    /// </summary>
    public class CreditCardPayment : PaymentMethod
    {
        private string cardholderName;
        private string cardNumber;
        private string cvv;
        private DateTime expirationDate;

        /// <summary>
        /// Initializes a new instance of the <see cref="CreditCardPayment"/> class.
        /// </summary>
        /// <param name="cardholderName">The name of the cardholder.</param>
        /// <param name="cardNumber">The credit card number.</param>
        /// <param name="cvv">The card's CVV code.</param>
        /// <param name="expirationDate">The card's expiration date.</param>
        public CreditCardPayment(string cardholderName, string cardNumber, string cvv, DateTime expirationDate)
        {
            this.cardholderName = cardholderName;
            this.cardNumber = cardNumber;
            this.cvv = cvv;
            this.expirationDate = expirationDate;
        }

        /// <inheritdoc />
        public override bool ProcessPayment(double amount)
        {
            // Implement credit card payment processing logic here.
            Console.WriteLine($"Processing credit card payment of ${amount}.");
            return true; // Placeholder return value.
        }
    }
}
