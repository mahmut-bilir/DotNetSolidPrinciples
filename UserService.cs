public class UserService
{
    private readonly EmailService _emailService;

    public UserService(EmailService emailService)
    {
        _emailService = emailService;
    }

    public void CreateUser(string name, string email)
    {
        Console.WriteLine($"{name} User Created.");
        _emailService.SendEmail(email, "Your account has been created.");
    }
}