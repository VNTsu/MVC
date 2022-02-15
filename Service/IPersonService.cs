using MVC2.Models;
using MVC2.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Service
{
     public interface IPersonService
    {
        List<Person> AllPerson();
        void Create (Person persons);
        void Delete (Person persons);
        void Edit (Person persons);
    }
}