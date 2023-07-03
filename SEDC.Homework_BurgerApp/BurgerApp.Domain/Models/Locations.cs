namespace BurgerApp.Domain.Models
{
    public class Locations
    {
        public List<Location> LocationList { get; set; }
        
        public void ListAllLocations()
        {
            foreach (var location in LocationList)
            {
                Console.WriteLine($"Name: {location.Name}, Address:{location.Address}, Opens at: {location.OpensAt}, Closes at: {location.ClosesAt}");
            }
        }

        public void AddNewLocation(Location newLocation)
        {
            LocationList.Add(newLocation);
        }

        public void EditLocation(int index, Location updatedLocation)
        {
            LocationList[index] = updatedLocation;
        }

        public void DeleteLocation(int index) 
        { 
            LocationList.RemoveAt(index);
        }
    }
}
