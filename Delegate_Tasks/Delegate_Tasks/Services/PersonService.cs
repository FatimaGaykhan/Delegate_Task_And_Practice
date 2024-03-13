using System;
using Delegate_Tasks.Data;
using Delegate_Tasks.Models;
using Delegate_Tasks.Services.Interfaces;

namespace Delegate_Tasks.Services
{
    public class PersonService : IPersonService
    {
        public List<Person> GetPersonBySalary(Predicate<Person> func)
        {
            List<Person> resultPerson = new();
            foreach (var item in AppDbContext.people)
            {
                if (func(item))
                {
                    resultPerson.Add(item);
                }
            }
            return resultPerson;
        }
    }
}

