using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
    public struct TimelineMessage
    {
        private readonly UserId userId;
        private readonly String author;
        private readonly String content;
        private readonly DateTime date;
        private readonly int nbRepublish;


        public string Author
        {
            get { return author; }
        }

        public UserId Id
        {
            get { return userId; }
        }

        public int NbRepublish
        {
            get { return nbRepublish; }
        }

        public string Content
        {
            get { return content; }
        }

        public DateTime Date
        {
            get { return date; }
        }


        public TimelineMessage(UserId userId,String author, DateTime date,String content, int nbRepublish)
        {
            this.author = author;
            this.userId = userId;
            this.date = date;
            this.content = content;
            this.nbRepublish = nbRepublish;
        }

        
    }
}
