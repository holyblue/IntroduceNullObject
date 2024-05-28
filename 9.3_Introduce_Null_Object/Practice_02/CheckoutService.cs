namespace _9._3_Introduce_Null_Object.Practice_02;

public class CheckoutService
{
    private readonly PaymentGateway _paymentGateway;

    public CheckoutService(PaymentGateway paymentGateway)
    {
        _paymentGateway = paymentGateway;
    }

    public bool ProcessOrder(decimal amount)
    {
        // Check for null payment gateway
        if (_paymentGateway != null)
        {
            return _paymentGateway.ProcessPayment(amount);
        }

        return false;
    }
}