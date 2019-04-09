using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyMediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new HorseMediator();
            Kilka kilka = new Kilka(mediator);
            Jerry jerry = new Jerry(mediator);
            Lucy lucy = new Lucy(mediator);

            mediator.Lucy = lucy;
            mediator.Jerry = jerry;
            mediator.Kilka = kilka;

            jerry.Send("Can I have some hay?", kilka);

            kilka.Send("No I'm hungry", jerry);

            jerry.Send("Can I have some hay?", lucy);

            lucy.Send("Yes", jerry);

            Console.ReadKey();

        }
    }
}
