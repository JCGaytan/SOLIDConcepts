namespace SampleSOLIDConcepts
{
    /// <summary>
    /// Represents a base class for payment methods.
    /// </summary>
    public abstract class PaymentMethod : IPaymentGateway
    {
        /// <inheritdoc />
        public abstract bool ProcessPayment(double amount);  // SRP: Single responsibility - Only responsible for processing payments.

        // Additional common methods or properties for payment methods can be added here.
    }
}
