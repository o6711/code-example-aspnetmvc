using System;

namespace DataLayer.Entities
{
    public class Message
    {
        public Guid MessageId { get; set; }

        public string Text { get; set; }

        public DateTime TimeStamp { get; set; }
    }
}
