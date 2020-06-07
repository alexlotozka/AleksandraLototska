using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
			
	class Person
	{
		private string name { get; set; }
		
		private string surname { get; set; }
	

		private DateTime date = new DateTime();

		private DateTime Date
		{
			get { return date; }
			set { date = value; }
		}

		public Person(string name, string surname, DateTime date)
		{
            this.name = name;
			this.surname = surname;
			Date = date;
        }
		public Person()
		{
			name = "Aleksandra";
			surname = "Lototska";
			Date = new DateTime(2002, 5, 21, 10, 00, 00);
		}
		public override string ToString()
		{
			return $"{name} {surname} was born in {Date}";
		}
		public virtual string ToShortString()
		{
			return $"{name} {surname}";
		}
		public override bool Equals(object obj)
		{
			if (obj.GetType() != this.GetType()) return false;
			Person person = (Person)obj;
			return this.name == person.name &&
				this.surname == person.surname &&
				this.Date == person.Date;

		}
		public override int GetHashCode()
		{
			return name.GetHashCode() + surname.GetHashCode() + Date.GetHashCode();
		}
		object DeepCopy()
		{
			Person pers = new Person();
			pers.name = this.name;
			pers.surname = this.surname;
			pers.date = this.date;

		  return pers;
		}
	}
	
		
	}
	
	
	
	




