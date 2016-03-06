using System.Threading.Tasks;

namespace RedisCacheExample.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
