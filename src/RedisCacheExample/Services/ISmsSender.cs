using System.Threading.Tasks;

namespace RedisCacheExample.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
