using IteratorDemo.Interfaces;
using IteratorDemo.Model;

namespace IteratorDemo.Implementations
{
    internal class WalkingIterator : ITravelIterator
    {
        private List<Location> _locations;
        private int position;

        public WalkingIterator(List<Location> locations)
        {
            _locations = locations;
            this.position = 0;
        }

        public bool HasNext()
        {
            return position < _locations.Count;
        }

        public Location Next()
        {
            return _locations[position++];
        }

        public Location GetCurrentLocation()
        {
            return _locations[position];
        }
    }
}
