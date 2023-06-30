using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace MessageNow.Models
{
    public class Message
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public bool Read { get; set; }
        public MessageNowUser User { get; set; }
    }
}
