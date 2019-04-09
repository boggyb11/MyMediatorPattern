using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediatorPattern
{
  public interface IMediator
    {
        void SendMessage(string messsage, Horse horse);
    }
}
