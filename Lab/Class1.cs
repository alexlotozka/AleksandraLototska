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
		Year =1,
		TwoYears,
		Long
	}
	class Paper
	{
		public string NameOfPublication { get; set; }
		public Person AuthorName { get; set; }
		public DateTime DateOfPublication { get; set; }
		public Paper(string Name, DateTime date)
		{
			this.NameOfPublication = Name;
			this.DateOfPublication = date;
			AuthorName = new Person();
		}
		public Paper ()
		{
			NameOfPublication = "Paper towns";
			DateOfPublication = new DateTime(2002, 5, 21, 10, 00, 00);
			AuthorName = new Person();

		}
		public override string ToString()
		{
			return $"{NameOfPublication} : {AuthorName} : {DateOfPublication} ";
		}

	}
	class ResearchTeam
	{
		private string ExplorationName;
		private string OrganisationName;
		private int RegistrationNumber;
		private TimeFrame Duration;
		private Paper ListOfPublication;
		public ResearchTeam(string ExplorationName, string OrganisationName, int RegistrationNumber, TimeFrame duration)
		{
			this.ExplorationName = ExplorationName;
			this.OrganisationName = OrganisationName;
			this.RegistrationNumber = RegistrationNumber;
			this.Duration = duration;
		}
		public ResearchTeam()
		{
			ExplorationName = "Columbus";
			OrganisationName = "Fixiki";
			RegistrationNumber = 21;
			Duration = TimeFrame.Year;
		}
		private string expname;
		public string ExpName
		{
			get { return expname; }
			set { expname = value; }
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
		private Paper theLast;

		
		 public List<Paper> PublicationsList = new List<Paper>();
		public Paper TheLast
		{
			get
			{
				PublicationsList.Sort();
				if (PublicationsList.Capacity == 0)
				{
					return null;
				}
				else
					return PublicationsList.FindLast();
			}
		}

		public void AddPapers(params Paper []publicationList)
		{
			foreach (Paper pp in publicationList)
			{
				PublicationsList.Add(pp);
			}
			//this.team.AddRange(publicationList);
		}
		public override string ToString()
		{ 
			StringBuilder sb = new StringBuilder("Публікації:");	
			foreach (Paper pp in PublicationsList)
			{
				sb.Append($" {pp.NameOfPublication} ,");
			}
			return $"{ExplorationName} {RegistrationNumber} {OrganisationName} {Duration} \n {sb}";
		}
		public string ToShortString()
		{
			return $"{ExplorationName} {RegistrationNumber} {OrganisationName} {Duration}";
		}
		public TimeFrame this[int abs]
		{
			get
			{
				if (abs ==1)
				{
					return TimeFrame.Year;
				}
				else if (abs == 2)
				{
					return TimeFrame.TwoYears;
				}
				else
				{
					return TimeFrame.Long;
				}
				
			}
			
		}

	}

}

