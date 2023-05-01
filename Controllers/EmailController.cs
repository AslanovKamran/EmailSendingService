using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using SMTP_EmailServiceApp.Models.DTO;
using SMTP_EmailServiceApp.Services.EmailService;

namespace SMTP_EmailServiceApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmailController : ControllerBase
	{
		private readonly IEmailService _emailService;
		public EmailController(IEmailService emailService) => _emailService = emailService;

		[HttpPost]
		public async Task<IActionResult> SendEmail(EmailDto request)
		{
			try
			{
				await _emailService.SendEmailAsync(request);
				return Ok("Sent from Email Service");
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
