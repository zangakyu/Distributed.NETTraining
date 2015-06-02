﻿using System;
using Messaging.Domain;
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
            var ownerId = new UserId("1");
            var publishDate = DateTime.Now;
            var authorId = new UserId("2");
            var content = "hello";
            var nbRepublish = 0;
            var messageId = ++MessagePublished.messageIds;
            var timelineMessage = new TimelineMessage(messageId,ownerId, publishDate, authorId, content, nbRepublish);

            // TODO : add a check for each properties getter (NO SETTER ! => )
            Check.That(timelineMessage.OwnerId).IsEqualTo(ownerId);
            Check.That(timelineMessage.PublishDate).IsEqualTo(publishDate);
            Check.That(timelineMessage.AuthorId).IsEqualTo(authorId);
            Check.That(timelineMessage.Content).IsEqualTo(content);
            Check.That(timelineMessage.NbRepublish).IsEqualTo(nbRepublish);
        }

        [Test]
        public void WhenInstanciateTwoTimelineMessageWithSameProperties_ThenTheyAreEquals()
        {
            var ownerId = new UserId("1");
            var publishDate = DateTime.Now;
            var authorId = new UserId("2");
            var content = "hello";
            var nbRepublish = 0;
            var messageId = ++MessagePublished.messageIds;

            var timelineMessage1 = new TimelineMessage(messageId,ownerId, publishDate, authorId, content, nbRepublish);
            var timelineMessage2 = new TimelineMessage(messageId,ownerId, publishDate, authorId, content, nbRepublish);

            Check.That(timelineMessage1).IsEqualTo(timelineMessage2);
        }
    }
}
