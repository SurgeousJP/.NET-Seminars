using IteratorDemo.Model;

namespace IteratorDemo.Interfaces
{
    internal interface ITravelIterator
    {
        bool HasNext();
        Location Next();
    }
}
