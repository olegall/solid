using System;

namespace InterfaceSegregation
{
    interface IMessageAfter
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }

    interface IVoiceMessage : IMessageAfter
    {
        byte[] Voice { get; set; }
    }

    interface ITextMessage : IMessageAfter
    {
        string Text { get; set; }
    }

    interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }

    class VoiceMessageAfter : IVoiceMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public byte[] Voice { get; set; }

        public void Send()
        {
            Console.WriteLine("Передача голосовой почты");
        }
    }

    class EmailMessageAfter : IEmailMessage
    {
        public string Text { get; set; }
        public string Subject { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Отправляем по Email сообщение: {0}", Text);
        }
    }

    class SmsMessageAfter : ITextMessage
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Отправляем по Sms сообщение: {0}", Text);
        }
    }
}
