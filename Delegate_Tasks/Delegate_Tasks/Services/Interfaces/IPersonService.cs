using System;
using Delegate_Tasks.Models;

namespace Delegate_Tasks.Services.Interfaces
{
	public interface IPersonService
	{
		public List<Person> GetPersonBySalary(Predicate<Person> func);

	}
}

