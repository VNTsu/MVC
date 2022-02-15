using System.Collections.Generic;
using MVC2.Controllers;
using MVC2.Models;

namespace MVC2.Data
{
    public class PersonData
    {
        public static List<Person> Persons = new List<Person> 
        {
            new Person
                {
                Id = 1,
                FirtName = "Nguyen",
                LastName = "Hoang",
                City = "Bac Ninh",
                    Gender = "male",
            },
            new Person
            {
                Id = 2,
                FirtName = "Nguyen",
                LastName = "Tien",
                    City = "Ha Noi",
                    Gender = "female",
                },
            new Person
            {
                Id = 3,
                FirtName = "Nguyen",
                LastName = "Manh",
                    City = "Ha Noi",
                    Gender = "other",
                },
        };
    }
}