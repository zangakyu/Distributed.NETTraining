using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    public class TimelineMessageRepository
    {
        IEnumerable<TimelineMessage> timelineMessages;

        public TimelineMessageRepository(IEnumerable<TimelineMessage> tm)
        {
            this.timelineMessages = tm;
        }

        public IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i)
        {
           return timelineMessages.Where(message => message.Id == userId).OrderByDescending(x => x.Date).Take(i);
        }
    }
}
