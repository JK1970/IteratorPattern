using IteratorPattern.Models;

namespace IteratorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            EmailProvider emailProvider = new();
            emailProvider.Messages!.AddRange(
                new List<Message>()
                {
                    new Message("Lorem "),
                    new Message("ipsum "),
                    new Message("dolor "),
                    new Message("sit "),
                    new Message("amet")
                }
            );

            MessageIterator messageIterator = (MessageIterator)emailProvider.GetEnumerator();

            do
            {
                Console.WriteLine(((Message)messageIterator.Current).Text);
            }
            while (messageIterator.MoveNext());

            messageIterator.Reset();
        }
    }
}

