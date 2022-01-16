using System;

namespace InterfaceSegregation
{
    interface IMessage
    {
        void Send();
        string Text { get; set; }
        string Subject { get; set; }
        string ToAddress { get; set; }
        string FromAddress { get; set; }

        byte[] Voice { get; set; }
    }

    class EmailMessage : IMessage
    {
        public string Subject { get; set; }
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public void Send()
        {
            Console.WriteLine("Отправляем по Email сообщение: {0}", Text);
        }
    }

    class SmsMessage : IMessage
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }

        public string Subject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Send()
        {
            Console.WriteLine("Отправляем по Sms сообщение: {0}", Text);
        }
    }

    class VoiceMessage : IMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }
        public byte[] Voice { get; set; }

        public string Text
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Subject
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public void Send()
        {
            Console.WriteLine("Передача голосовой почты");
        }
    }
}
