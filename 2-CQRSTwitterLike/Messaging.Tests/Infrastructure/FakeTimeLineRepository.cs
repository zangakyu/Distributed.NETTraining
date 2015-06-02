using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Messaging.Domain;

namespace Messaging.Infrastructure 
{
    class FakeTimeLineRepository : ITimelineMessageRepository
    {
        public List<TimelineMessage> Messages { get; set; }

        public FakeTimeLineRepository()
        {
            Messages = new List<TimelineMessage>();
        }

        public IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i)
        {
            throw new NotImplementedException();
        }

        public void Save(TimelineMessage tm)
        {
            Messages.Add(tm);
        }

        public void Remove(int id)
        {
            Messages.Remove(Messages.Find(x => x.MessageId.Equals(id)));
        }

        public void RepublishedMessage(int id,UserId userId)
        {
         //   Messages.Find(x => x.MessageId.Equals(id)).republishedMessage(userId);

        }
    }
}
