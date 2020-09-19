using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1.Modules
{
    class Events
    {
        public static void Run()
        {
            var eventsMove = new EventsStudent();
            eventsMove.Moving += EventsMove_Moving;
           // eventsMove.Moving = Info;
            Console.WriteLine("=== Event move ===");
            //Action<string> method = Info;
            eventsMove.Move(7);
            Console.WriteLine("=== End Event move ===");
        }

        private static void EventsMove_Moving(object sender, MovingEventArgs e)
        {
           Console.WriteLine(e._message);
        }

        public static void Info (string text)
        {
            Console.WriteLine($"{text}");
        }
    }

    class EventsStudent
    {
        // public Action<string> Moving { get; set; } - делегает переделываем на событие
        //public event EventHandler EventName; - первая форма событий без параметров
        public event EventHandler<MovingEventArgs> Moving; // - вторая форма сабытий с параметром
        public void Move(int distance)
        {
            for (int i = 0; i <= distance; i++)
            {
                Thread.Sleep(1000);
                if(this.Moving != null)
                {
                    Moving(this, new MovingEventArgs($"Идет перемещение... пройдено километров {i}"));
                }
            }
        }
    }

    public class MovingEventArgs: EventArgs
    {
        public string _message { get; private set; }
        public MovingEventArgs(string message)
        {
            _message = message;
        }
    }
}
