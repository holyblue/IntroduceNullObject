namespace _9._3_Introduce_Null_Object.Practice_03;
// Notification Service class
public class NotificationService
{
    public virtual void SendEmail(string email, string subject, string body)
    {
        // Simulating email sending
        Console.WriteLine($"Sending email to {email}: {subject} - {body}");
    }

    public virtual void SendSMS(string phoneNumber, string message)
    {
        // Do nothing
    }
}

// Service class