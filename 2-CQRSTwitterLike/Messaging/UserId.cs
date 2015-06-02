using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Messaging
{
   public  class UserId
   {
       private int id;

       public UserId(int id)
       {
           this.id = id;
       }

       public UserId()
       {
           this.id = 42;
       }

       public  int Id
       {
           get { return id; }
       }
   }
}
