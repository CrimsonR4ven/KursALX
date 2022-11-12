namespace ALXCourseHomework.MailingService
{
    public class EmailService
    {
        public static void SendEmail(Email email)
        {
            Console.WriteLine("The email has been sent\n");
            Console.WriteLine($"From: {email.From} To: {email.To}");
            Console.WriteLine($"Subject: {email.Subject}");
            Console.WriteLine($"Message: {email.Message}");
        }
    }
}
