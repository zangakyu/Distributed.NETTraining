using System;
using Messaging.Domain;
using Messaging.Infrastructure;
using NFluent;
using NUnit.Framework;

namespace Messaging.Tests.Domain
{
    [TestFixture]
    public class TimelineMessageProjectionsTests
    {
        [Test]
        public void WhenHandleMessagePublished_ThenTimelineMessageIsSavedForAuthor()
        {
            // Actors = Given
            var date = DateTime.Now;
            UserId author = new UserId("1");

            var messagePublished = new MessagePublished(date, author, "hello World!");
            // TODO : FakeTimelineRepository is a fake implementation of interface for tests purpose only -> keep it in test assembly
            var timelineMessageRepositoryFake = new FakeTimeLineRepository();
            var timelineMessageProjections = new TimeLineMessageProjections(timelineMessageRepositoryFake);

            // Action = When
            timelineMessageProjections.Handle(messagePublished);
      
           
            // Asserts = Then
            var expectedTimelineMessage = new TimelineMessage(messagePublished.MessageId,author, date, author, "hello World!",0);
            var m = timelineMessageRepositoryFake.Messages;
            Check.That(timelineMessageRepositoryFake.Messages).ContainsExactly(expectedTimelineMessage);
        }

        [Test]
        public void GivenExistingTimelineMessage_WhenHandleMessageDeleted_ThenNbRepublishIsIncremented()
        {
            // Given
            var date = DateTime.Now;
            UserId author = new UserId("1");

            var messagePublished = new MessagePublished(date, author, "hello World!");
            var timelineMessageRepositoryFake = new FakeTimeLineRepository();
            var timelineMessageProjections = new TimeLineMessageProjections(timelineMessageRepositoryFake);
            //timelineMessageProjections.Handle(messagePublished);
            var existingTimelineMessage = new TimelineMessage(messagePublished.MessageId,author, date, author, "hello World!", 0);
            timelineMessageRepositoryFake.Messages.Add(existingTimelineMessage);

            // When
            var MD = new MessageDeleted(messagePublished.MessageId);

            timelineMessageProjections.Handle(MD);

            //timelineMessageRepositoryFake.Remove(messagePublished.MessageId);
            Check.That(timelineMessageRepositoryFake.Messages).Not.ContainsExactly(existingTimelineMessage);

        
        }

        //[Test]
        //public void messageRepublished()
        //{
        //    var date = DateTime.Now;
        //    UserId author = new UserId("1");

        //    var messagePublished = new MessagePublished(date, author, "hello World!");
        //    var timelineMessageRepositoryFake = new FakeTimeLineRepository();
        //    var timelineMessageProjections = new TimeLineMessageProjections(timelineMessageRepositoryFake);
        //    timelineMessageProjections.Handle(messagePublished);
        //    var expectedTimelineMessage = new TimelineMessage(messagePublished.MessageId, author, date, author, "hello World!", 0);

        //    timelineMessageRepositoryFake.RepublishedMessage(messagePublished.MessageId,new UserId("2"));
  
            
        //    Check.That(timelineMessageRepositoryFake.Messages.Find(x => x.MessageId.Equals(messagePublished.MessageId)).NbRepublish).Equals(1);


        //}

        // //TODO : repeat for some more Events : FollowerMessagePublished, FollowerMessageRepublished, FollowerMessageLiked
    }
}
