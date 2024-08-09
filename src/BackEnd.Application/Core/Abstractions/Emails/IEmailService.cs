namespace BackEnd.Application.Core.Abstractions.Emails;

public interface IEmailService
{
    Task SendEmailAsync(string from, string to, string subject, string body);
}
