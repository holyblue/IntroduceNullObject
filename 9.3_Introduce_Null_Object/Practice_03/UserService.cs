namespace _9._3_Introduce_Null_Object.Practice_03;

public class UserService
{
    private readonly NotificationService _notificationService;

    public UserService(NotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void RegisterUser(string email, string phoneNumber)
    {
        // Register user...

        // Check for null notification service
        if (_notificationService != null)
        {
            _notificationService.SendEmail(email, "Welcome", "Thank you for registering!");
            _notificationService.SendSMS(phoneNumber, "Welcome to our service!");
        }
    }
}