using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediatorPattern
{
    //concrete colleague class
    public class Jerry : Horse
    {
        public Jerry(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message, Horse horse)
        {
            Console.WriteLine($"Jerry: {message}");
            mediator.SendMessage(message, horse);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Jerry receives message({message})");
        }
    }

    public class Kilka : Horse
    {
        public Kilka(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message, Horse horse)
        {
            Console.WriteLine($"Kilka: {message}");
            mediator.SendMessage(message, horse);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Kilka receives message({message})");
        }
    }

    public class Lucy : Horse
    {
        public Lucy(IMediator mediator) : base(mediator)
        {
        }

        public void Send(string message, Horse horse)
        {
            Console.WriteLine($"Lucy: {message}");
            mediator.SendMessage(message, horse);
        }

        public void Notify(string message)
        {
            Console.WriteLine($"Lucy receives message({message})");
        }
    }
}
