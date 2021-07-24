using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pluralsight.ArraysCollections.Demos
{
    public class Bus
    {
        public const int Capacity = 5;
        public int Space { get => Capacity - _passengers.Count; }

        private List<Passenger> _passengers = new List<Passenger>();  
        public bool Load(Passenger passenger)
        {
            if (Space < 1)
                return false;
            if (_passengers.Count == 0) 
            {
                _passengers.Add(passenger);
            }
            int lastIndex = _passengers.Count;
            _passengers.Insert(lastIndex, passenger);
            Console.WriteLine($"{passenger} got on the bus");
            return true;
        }
        public void ArriveAt(string place)
        {
            Console.WriteLine($"\r\nBus arriving at {place}");
            if (_passengers.Count == 0)
                return;
            for (int i = 0; i < _passengers.Count; i++)            
            {
                if (_passengers[i].Destination.Contains(place))
                {
                    Console.WriteLine($"{_passengers[i].Name} is getting off");
                    _passengers.Remove(_passengers[i]);
                    
                }
            }
            
            //do{
            //    LinkedListNode<Passenger> nextNode = currentNode.Next;
            //    if (currentNode.Value.Destination == place)
            //    {
            //        Console.WriteLine($"{currentNode.Value} is getting off");
            //        _passengers.Remove(currentNode);
            //    }
            //    currentNode = nextNode;
            //} while (currentNode != null);

            Console.WriteLine($"{_passengers.Count} people left on the bus");
        }
    }
}
