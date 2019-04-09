using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediatorPattern
{
    public class HorseMediator : IMediator
    {
        private Jerry _jerry;
        private Kilka _kilka;
        private Lucy _lucy;

        public Kilka Kilka
        {
            set { _kilka = value; }
        }
        public Jerry Jerry
        {
            set { _jerry = value; }
        }

        public Lucy Lucy
        {
            set { _lucy = value; }
        }

        public void SendMessage(string messsage, Horse horse)
        {
            if (horse == _jerry)
            {
                _jerry.Notify(messsage);
            }
            if (horse == _kilka)
            {
                _kilka.Notify(messsage);
            }
            if(horse == _lucy)
            {
                _lucy.Notify(messsage);
            }
        }
    }
}
