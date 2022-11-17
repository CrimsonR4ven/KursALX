namespace AlxCourseHomework.MailingService
{
    public class EmailService
    {
        public static void SendEmail(Email email)
        {
            Console.WriteLine($"\nThe email has been sent \nFrom: {email.From} To: {email.To}\nSubject: {email.Subject}\nMessage:\n {email.Message}");
        }
    }
}
