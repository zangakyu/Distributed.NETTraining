using System;
using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageTests
    {
        [Test]
        public void WhenInstanciateTimelineMessage_ThenCanGetEachProperties()
        {
            var timelineMessage = new TimelineMessage(new UserId(1), "Moi", DateTime.Now);

            // TODO : add a check for each properties getter (NO SETTER ! => )
            Check.That(timelineMessage.Author).IsEqualTo("Moi");
        }

        [Test]
        public void WhenInstanciateTwoTimelineMessageWithSameProperties_ThenTheyAreEquals()
        {
            var id = new UserId(1);
            var timelineMessage1 = new TimelineMessage(id, "Fromage", DateTime.Now);
            var timelineMessage2 = new TimelineMessage(id, "Fromage", DateTime.Now);

            Check.That(timelineMessage1).IsEqualTo(timelineMessage2);
        }
    }
}
