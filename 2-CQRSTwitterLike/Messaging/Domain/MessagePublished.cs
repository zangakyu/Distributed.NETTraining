using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain
{
   public class MessagePublished
    {
        public static int messageIds=0;

        private int messageId;
        private DateTime messageDate;
        private String contenu;
        private UserId author;

        public int MessageId
        {
            get { return messageId; }
        }

        public DateTime MessageDate
        {
            get { return messageDate; }
        }

        public UserId Author
        {
            get { return author; }
        }

       public string Contenu
       {
           get { return contenu; }
       }

       public MessagePublished(DateTime date, UserId author, String contenu)
       {
           messageIds++;

           this.messageId = messageIds;
           this.messageDate = date;
           this.author = author;
           this.contenu = contenu;

        }
    }

}
