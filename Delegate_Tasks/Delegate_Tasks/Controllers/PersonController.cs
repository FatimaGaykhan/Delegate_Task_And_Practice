using System;
using Delegate_Tasks.Services;
using Delegate_Tasks.Services.Interfaces;

namespace Delegate_Tasks.Controllers
{
	public class PersonController
	{
		private readonly IPersonService _personService;
		public PersonController()
		{
			_personService = new PersonService();
		}

		public void GetPersonBySalary()
		{
			var result = _personService.GetPersonBySalary(m => m.Salary > 1000);
			foreach (var item in result)
			{
				Console.WriteLine(item.Name+" "+item.Surname+" "+item.Address);
			}
		}
	}
}

