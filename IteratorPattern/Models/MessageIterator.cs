using System.Collections;

namespace IteratorPattern.Models
{
    public class MessageIterator : IEnumerator
    {
        private EmailProvider EmailProvider { get; set; }
        private int _messageId;
        public object Current
        {
            get
            {
                return EmailProvider.Messages![_messageId];
            }
        }
        public MessageIterator(EmailProvider emailProvider)
        {
            EmailProvider = emailProvider;
        }


        public bool MoveNext()
        {
            if (_messageId + 1 < EmailProvider.Messages!.Count)
            {
                _messageId++;
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _messageId = 0;
        }
    }
}