using SMTP_EmailServiceApp.Models.DTO;

namespace SMTP_EmailServiceApp.Services.EmailService
{
	public interface IEmailService
	{
		Task SendEmailAsync(EmailDto request);
	}
}
