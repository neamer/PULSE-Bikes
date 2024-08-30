using PULSE.Model;

namespace PULSE.Services.Interfaces
{
    public interface IMessengerService
    {
        void sendEmail(Email email);
    }
}
