namespace SampleSOLIDConcepts
{
    /// <summary>
    /// Represents an interface for payment gateways.
    /// </summary>
    public interface IPaymentGateway
    {
        /// <summary>
        /// Processes a payment for the given amount.
        /// </summary>
        /// <param name="amount">The payment amount.</param>
        /// <returns>True if the payment is successful; otherwise, false.</returns>
        bool ProcessPayment(double amount);  // SRP: Single responsibility - Only responsible for processing payments.
    }
}
