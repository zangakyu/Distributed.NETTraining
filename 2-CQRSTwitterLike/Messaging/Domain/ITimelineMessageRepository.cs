using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Messaging.Domain
{
    public interface ITimelineMessageRepository
    {
        IEnumerable<TimelineMessage> GetLastMessagesForUser(UserId userId, int i);

        void Save(TimelineMessage tM);
        void Remove(int idMessage);


    }
}