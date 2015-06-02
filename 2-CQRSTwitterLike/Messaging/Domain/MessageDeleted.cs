using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging.Domain
{
   public class MessageDeleted
    {
        private readonly int _idMessage;

       public MessageDeleted(int idMessage)
       {
           _idMessage = idMessage;
       }
        public int IdMessage
        {
            get { return _idMessage; }
        }
    }
}
