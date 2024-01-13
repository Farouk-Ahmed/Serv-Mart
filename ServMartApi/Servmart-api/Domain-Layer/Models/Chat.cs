
namespace Domain_Layer.Models
{
    public class Chat
    {
        public Guid ID { get; set; }
        public string FirstUserId { get; set; }
        public string SecondUserId { get; set; }
        public Guid RequestID { get; set; }

        public virtual User User { get; set; }
        public virtual Request Request { get; set; }
        public virtual ICollection<Message> Messages { get; set; }

    }
}
