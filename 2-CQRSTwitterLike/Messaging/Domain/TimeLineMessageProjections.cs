using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain
{
    public class TimeLineMessageProjections
    {
        private ITimelineMessageRepository timeLineRepo;
        public TimeLineMessageProjections(ITimelineMessageRepository timelineRepo)
        {
            this.timeLineRepo = timelineRepo;
        }

        public void Handle(MessagePublished messagePublished)
        {
            TimelineMessage tLM = new TimelineMessage(messagePublished.MessageId,messagePublished.Author, messagePublished.MessageDate, messagePublished.Author, messagePublished.Contenu, 0);
            timeLineRepo.Save((tLM));
        }
        public void Handle(MessageDeleted messageDeleted)
        {
            timeLineRepo.Remove(messageDeleted.IdMessage);
        }
    }
}
