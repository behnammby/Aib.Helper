using System.Threading.Tasks;
using MimeKit;

namespace Behnammby.Common.Services
{
    public interface IEmailService {
        Task SendEmailAsync(string email, string subject, MimeEntity messageBody);
    }
}