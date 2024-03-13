using System;
using Delegate_Tasks.Models;

namespace Delegate_Tasks.Data
{
	public class AppDbContext
	{
		public static List<Person> people;
        public static List<Book> books;
		static AppDbContext()
		{
			people = new List<Person>
			{
				new Person
				{
					Id=1,
					Name="Fatima",
					Surname="Gaykhanova",
					Address="28 may",
					Salary=5000
				},
                new Person
                {
                    Id=2,
                    Name="Rustam",
                    Surname="Heydarov",
                    Address="Bileceri",
                    Salary=800
                },
                new Person
                {
                    Id=3,
                    Name="Eldar",
                    Surname="Gaykhanov",
                    Address="Sumqayit",
                    Salary=1700
                },
                new Person
                {
                    Id=4,
                    Name="Saniya",
                    Surname="Bayramova",
                    Address="Balaken",
                    Salary=400
                },
                new Person
                {
                    Id=5,
                    Name="Mushfiq",
                    Surname="Calilov",
                    Address="Ehmedli",
                    Salary=950
                },

            };
            books = new List<Book>
            {
                new Book
                {
                    Id=1,
                    Name="Cinayet ve Ceza",
                    Author="Dostoyevski"
                },
                new Book
                {
                    Id=2,
                    Name="Qurur ve Qerez",
                    Author="Jane Austin"
                },
                new Book
                {
                    Id=3,
                    Name="Yeddi Gozel",
                    Author="Nizami"
                },
                new Book
                {
                    Id=4,
                    Name="Leyli ve Mecnun",
                    Author="Nizami"
                },
                new Book
                {
                    Id=5,
                    Name="1984",
                    Author="George Orwell"
                },

            };
		}
        
	}
}

