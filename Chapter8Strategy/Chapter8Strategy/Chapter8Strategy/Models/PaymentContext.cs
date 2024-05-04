namespace Chapter8Strategy.Models;

public class PaymentContext
{
    private IPaymentStrategy paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public async Task ExecutePayment(decimal amount)
    {
        await paymentStrategy.ProcessPaymentAsync(amount);
    }
}