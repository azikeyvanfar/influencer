using System.Threading.Tasks;

namespace Domain.Contracts.FORG.MessageSender
{
    public interface IMessageSender
    {
        public Task SendEmailAsync(string toEmail, string subject, string message, bool isMessageHtml = false);
    }
}
