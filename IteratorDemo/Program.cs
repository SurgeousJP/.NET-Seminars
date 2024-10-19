using IteratorDemo.Implementations;
using IteratorDemo.Interfaces;
using IteratorDemo.Model;

var locations = new RomeLocationCollection();

locations.AddNewLocation(new Location("Colosseum"));
locations.AddNewLocation(new Location("Trevi Fountain"));
locations.AddNewLocation(new Location("Pantheon"));
locations.AddNewLocation(new Location("Vatican Museums"));

Console.WriteLine("Began walking through Rome: ");
ITravelIterator walkIterator = locations.CreateIterator();
while (walkIterator.HasNext())
{
    Location landmark = walkIterator.Next();
    Console.WriteLine(landmark.Name);
}
