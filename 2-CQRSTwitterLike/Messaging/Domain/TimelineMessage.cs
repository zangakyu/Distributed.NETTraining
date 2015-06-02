using System;
using System.Collections.Generic;

namespace Messaging.Domain
{
    public struct TimelineMessage
    {
        private readonly int _messageId; 
        private readonly UserId _ownerId;
        private readonly DateTime _publishDate;
        private readonly UserId _authorId;
        private readonly string _content;
        private int _nbRepublish;
      //  private  List<UserId> _folowerRepublished;
        public TimelineMessage(int messageId,UserId ownerId, DateTime publishDate, UserId authorId, string content, int nbRepublish)
        {
            _messageId = messageId;
            _ownerId = ownerId;
            _publishDate = publishDate;
            _authorId = authorId;
            _content = content;
            _nbRepublish = nbRepublish;
         //   _folowerRepublished = new List<UserId>();
        }

        public UserId OwnerId
        {
            get { return _ownerId; }
        }

        public DateTime PublishDate
        {
            get { return _publishDate; }
        }

        public UserId AuthorId
        {
            get { return _authorId; }
        }

        public string Content
        {
            get { return _content; }
        }

        public int NbRepublish
        {
            get { return _nbRepublish; }
        }

        public int MessageId
        {
            get { return _messageId; }
        }

        //public List<UserId> FolowerRepublisehd
        //{
        //    get { return _folowerRepublished; }
        //}

        //public void republishedMessage(UserId id)
        //{
        //    _nbRepublish++;
        //  //  _folowerRepublished.Add(id);
        //}
    }
}