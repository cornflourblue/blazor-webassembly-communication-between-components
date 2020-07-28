using System;

namespace BlazorApp.Services
{
    public interface IMessageService
    {
        event Action<string> OnMessage;
        void SendMessage(string message);
        void ClearMessages();
    }

    public class MessageService : IMessageService
    {
        public event Action<string> OnMessage = delegate {};

        public void SendMessage(string message)
        {
            OnMessage(message);
        }

        public void ClearMessages()
        {
            OnMessage(null);
        }
    }
}