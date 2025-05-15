using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.Observer
{
    public class NewsAgency : ISubject
    {
        private readonly List<IObserver> _observers = new List<IObserver>();

        public void RegisterObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }

        public void NotifyObservers(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }

        // News update method that triggers notification
        public void PublishNews(string news)
        {
            Console.WriteLine($"News Published: {news}");
            NotifyObservers(news);
        }
    }
}
