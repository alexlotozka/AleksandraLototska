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
	}
	enum TimeFrame
	{
		Year,
		TwoYears,
		Long
	}
	class Paper
	{
		public string Name { get; set; }
		public Person person { get; set; }
		public DateTime date { get; set; }
		public Paper(string Name, Person person, DateTime date)
		{
			this.Name = Name;
			this.person = person;
			this.date = date;
		}
		public Paper ()
		{
			Name = "Mark";
			person = person;
			date = new DateTime(2002, 5, 21, 10, 00, 00); 

		}
		public override string ToString()
		{
			return $"{Name} : {person} : {date} ";
		}

	}
	class ResearchTeam
	{
		private string Exploration;
		private string Organisation;
		private int Registration;
		private TimeFrame frame;
		private Paper List;
		public ResearchTeam(string Exploration, string Organisation, int Registration, TimeFrame frame)
		{
			this.Exploration = Exploration;
			this.Organisation = Organisation;
			this.Registration = Registration;
			this.frame = frame;
		}
		public ResearchTeam()
		{
			Exploration = "Columbus";
			Organisation = "Hoppius";
			Registration = 21;
			frame = TimeFrame.Year;
		}
		private string name;
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		private string organisation;
		public string OrganisationN
		{
			get { return organisation; }
			set { organisation = value; }
		}
		private int numberOfRegistration;

		public int Number
		{
			get { return numberOfRegistration; }
			set { numberOfRegistration = value; }
		}
		private TimeFrame time;

		public TimeFrame Time
		{
			get { return time; }
			set { time = value; }
		}
		private Paper blank;

		public Paper Blank
		{
			get { return blank; }
			set { blank = value; }
		}


	}
}

