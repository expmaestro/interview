using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
//using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace ConsoleApp1.Patterns.Behavioral
{
    // уменьшения связности в приложениях
    // делегаты
    // события
    // IObserver/ IObservable
    class Observer
    {
        public static void Run()
        {
            var directory = @"C:\Temp";
            // var fileStatusDelegate = new FileStatusDelegate(directory, new Subscriber(string.Empty).ItIsSubscriber);
            var eventObserver = new FileStatusEvent(directory);
            var subscriber1 = new Subscriber(string.Empty);
            var subscriber2 = new Subscriber("Second");

            eventObserver.RemoveFiles += subscriber1.ItIsSubscriber;
            eventObserver.RemoveFiles += subscriber2.ItIsSecondSubscriber;
            Console.ReadLine();
            Console.WriteLine("--- Remove second subscriber ---");
            eventObserver.RemoveFiles -= subscriber2.ItIsSecondSubscriber;
            Console.ReadKey();
        }
    }

    class DirMonitoring
    {
        private List<string> _files;
        private readonly string _directory;

        public DirMonitoring(string directory)
        {
            _directory = directory;
        }

        public bool StartMonitor()
        {
            if(!Directory.Exists(_directory))
            {
                return false;
            }
            _files = new List<string>();

            var directoryInfo = new DirectoryInfo(_directory);
            foreach (var fileInfo in directoryInfo.GetFiles())
            {
                _files.Add(fileInfo.FullName);
            }
            return true;
        }

        public List<string> DeletedFiles()
        {
            var result = new List<string>();
            foreach (var  file in _files.ToArray())
            {
                if(!File.Exists(file))
                {
                    _files.Remove(file);
                    result.Add(file);

                }
            }
            return result;
        }
    }

    class Subscriber
    {
        private readonly string _name;

        public Subscriber(string name)
        {
            _name = name;
        }

        // 1. Delegate
        public void ItIsSubscriber(string fileName)
        {
            Console.WriteLine($"{this._name} {fileName} was deleted!");
        }

        //2. event
        public void ItIsSubscriber(object sender, string fileName)
        {
            Console.WriteLine($"{this._name} {fileName} was deleted!");
        }
        public void ItIsSecondSubscriber(object sender, string fileName)
        {
            Console.WriteLine("------");
            Console.WriteLine($"{this._name} {fileName} was deleted!");
            Console.WriteLine("------");
        }
    }

    // добавим вариант реализации через делегаты
    #region Delegate
    class FileStatusDelegate : IDisposable
    {
        private readonly Action<string> _subscriber;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitoring;

        public FileStatusDelegate(string directory, Action<string> subscriber)
        {
            _subscriber = subscriber;
            _dirMonitoring = new DirMonitoring(directory);

            if (_dirMonitoring.StartMonitor())
            {
                _timer = new Timer(1000);
                _timer.Elapsed += CheckRemoval;
                _timer.Start();
            }
            else
            {
                Console.WriteLine("Specified directory does not exist");
                Dispose();
            }
        }

        private void CheckRemoval(Object source, ElapsedEventArgs e)
        {
            foreach (var fileName in _dirMonitoring.DeletedFiles())
            {
                _subscriber(fileName);
            }

        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
    #endregion

    #region Event

    class FileStatusEvent : IDisposable
    {
        public  EventHandler<string> RemoveFiles;
        private readonly Timer _timer;
        private readonly DirMonitoring _dirMonitoring;

        public FileStatusEvent(string directory)
        {
           // _subscriber = subscriber;
            _dirMonitoring = new DirMonitoring(directory);

            if (_dirMonitoring.StartMonitor())
            {
                _timer = new Timer(1000);
                _timer.Elapsed += CheckRemoval;
                _timer.Start();
            }
            else
            {
                Console.WriteLine("Specified directory does not exist");
                Dispose();
            }
        }

        private void CheckRemoval(Object source, ElapsedEventArgs e)
        {
            foreach (var fileName in _dirMonitoring.DeletedFiles())
            {
                var handler = RemoveFiles;
                handler?.Invoke(this, fileName);
               // _subscriber(fileName);
            }

        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
    #endregion

}
