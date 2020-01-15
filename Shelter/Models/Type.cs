using System.Collections.Generic;

namespace Shelter.Models
{
    public class Type
    {
        private static List<Type> _instances = new List<Type> { };
        public string AnimalType { get; set; }
        public int Id { get; }
        public List<Details> Details { get; set; }

        public Type(string animalType)
        {
            AnimalType = animalType;
            _instances.Add(this);
            Id = _instances.Count;
            Details = new List<Details> { };
        }

        public static void ClearAll()
        {
            _instances.Clear();
        }

        public static List<Type> GetAll()
        {
            return _instances;
        }

        public static Type Find(int searchId)
        {
            return _instances[searchId - 1];
        }

        public void AddItem(Details details)
        {
            Details.Add(details);
        }
    }
}