using MessageNow.Models;

namespace MessageNow.Dtos
{
    public class ConversationDto
    {
        public int Id { get; set; }
        public List<Message> Messages { get; set; }
        public Message? LastMessage { get; set; }
        public string Name { get; set; }
    }
}
