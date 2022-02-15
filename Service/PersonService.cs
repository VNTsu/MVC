using MVC2.Models;
using MVC2.Data;


namespace MVC2.Service
{
    public class PersonService : IPersonService
    {
        public List<Person> AllPerson()
        {
            return PersonData.Persons.ToList();
        }

        public void Create(Person persons)
        {
            int highestId = PersonData.Persons.Max(m => m.Id);
            persons.Id = highestId + 1;
            PersonData.Persons.Add(persons);
        }

        public void Delete(Person persons)
        {
            var item = PersonData.Persons.Where(m => m.Id == persons.Id).FirstOrDefault();
            PersonData.Persons.Remove(item);
        }

        public void Edit(Person persons)
        {
            var item = PersonData.Persons.Where(m => m.Id == persons.Id).FirstOrDefault();
            if (item != null)
            {
                item.FirtName = persons.FirtName;
                item.LastName = persons.LastName;
                item.City = persons.City;
                item.Gender = persons.Gender;
            }
        }
    }
}