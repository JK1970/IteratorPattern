using System.Collections;

namespace IteratorPattern.Models
{
    public class EmailProvider : IEnumerable
    {
        public List<Message>? Messages { get; set; }
        public EmailProvider()
        {
            Messages = new List<Message>();
        }

        public IEnumerator GetEnumerator()
        {
            return new MessageIterator(this);
        }
    }
}