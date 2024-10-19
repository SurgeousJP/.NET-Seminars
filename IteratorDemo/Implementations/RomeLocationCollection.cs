using IteratorDemo.Interfaces;
using IteratorDemo.Model;

namespace IteratorDemo.Implementations
{
    internal class RomeLocationCollection
    {
        private List<Location> _locations;

        public RomeLocationCollection()
        {
            _locations = new List<Location>();
        }

        public void AddNewLocation(Location location)
        {
            _locations.Add(location);
        }

        public ITravelIterator CreateIterator()
        {
            return new WalkingIterator(_locations);
        }
    }
}
