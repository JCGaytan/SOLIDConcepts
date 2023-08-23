namespace SampleSOLIDConcepts
{
    /// <summary>
    /// Represents a payment processor that coordinates payment processing.
    /// </summary>
    public class PaymentProcessor
    {
        private List<IPaymentGateway> paymentGateways;

        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentProcessor"/> class.
        /// </summary>
        /// <param name="paymentGateways">The list of payment gateways to use.</param>
        public PaymentProcessor(List<IPaymentGateway> paymentGateways)
        {
            this.paymentGateways = paymentGateways;
        }

        /// <summary>
        /// Processes payments using the configured payment gateways.
        /// </summary>
        /// <param name="amount">The payment amount.</param>
        public void ProcessPayments(double amount)
        {
            foreach (var paymentGateway in paymentGateways)
            {
                paymentGateway.ProcessPayment(amount);  // DIP: Depending on abstraction (IPaymentGateway).
            }
        }
    }
}
