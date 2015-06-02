using System;
using Messaging.Domain;
using Nancy;

namespace Messaging.Infrastructure
{
    public class MessagingModule : NancyModule
    {
        private readonly ITimelineMessageRepository _timelineMessageRepository;

        public MessagingModule(ITimelineMessageRepository timelineMessageRepository)
        {
            _timelineMessageRepository = timelineMessageRepository;
            Get["/hello"] = _ => "Hello world!";
            Get["/messaging/timelineMessages/{author}"] = OnTimelineMessagesRequested;
        }

        private dynamic OnTimelineMessagesRequested(dynamic arg)
        {
            return _timelineMessageRepository.GetLastMessagesForUser(new UserId(arg.userId), 5);
        }
    }
}
