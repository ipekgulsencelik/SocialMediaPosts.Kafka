namespace CQRS.Core.Messages
{
    public abstract class Message
    {
        public Guid ID { get; set; }
    }
}