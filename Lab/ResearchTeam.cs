using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Lab
{
	class ResearchTeam : Team, INameAndCopy
	{
		private string ExplorationName;
		private string OrganisationName;
		private int RegistrationNumber;
		private TimeFrame Duration;
		private Paper ListOfPublication;
		public ResearchTeam(string ExplorationName, string OrganisationName, int RegistrationNumber, TimeFrame duration) : base(OrganisationName, RegistrationNumber)
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

		public ArrayList PublicationsList = new ArrayList();
		public void AddPapers(params Paper[] publicationList)
		{
			foreach (Paper pp in publicationList)
			{
				PublicationsList.Add(pp);
			}
			//this.team.AddRange(publicationList);
		}
		public object TheLast
		{
			get
			{
				PublicationsList.Sort();
				if (PublicationsList.Capacity == 0)
				{
					return null;
				}
				else
					return PublicationsList[PublicationsList.Count - 1];
			}
		}
		private ArrayList MemberList = new ArrayList();

		public void AddMembers(params Team[] memberList)
		{
			foreach (Team qq in memberList)
			{
				MemberList.Add(qq);
			}

		}
		public override string ToString()
		{
			StringBuilder sb = new StringBuilder("Publications:");
			foreach (Paper pp in PublicationsList)
			{
				sb.Append($" {pp.NameOfPublication} ,");
			}
			
			StringBuilder sb1 = new StringBuilder("\nMembers:");
			foreach (Team qq in MemberList)
			{
				sb.Append($" {qq.NameOrganisation} ,");
			}
			return $"{ExplorationName} {RegistrationNumber} {OrganisationName} {Duration}\n {sb} {sb1}";

		}

		public string ToShortString()
		{
			return $"{ExplorationName} {RegistrationNumber} {OrganisationName} {Duration}";
		}
		public TimeFrame this[int abs]
		{
			get
			{
				if (abs == 1)
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
		public override object DeepCopy()
		{
			ResearchTeam n = new ResearchTeam();
			n.ExplorationName = this.ExplorationName;
		    n.OrganisationName = this.OrganisationName;
			n.RegistrationNumber = this.RegistrationNumber;
			n.Duration = this.Duration;
			return n;
		}
		private Team teamm;

		public Team Teamm
		{
			get 
			{
				teamm = new Team();				
				teamm.NameOrganisation = this.OrganisationName;
				teamm.RegNumber = this.RegistrationNumber;
				return teamm; 			
			}
			set 
			{
				ResearchTeam gg = new ResearchTeam();
				teamm = new Team();
				teamm = gg;
				teamm = value; 
				
			}
		}
		
		public IEnumerable GetLastArticles(int num)
		{
			foreach (Paper qq in PublicationsList)
			{
				int yearOfPubl = qq.DateOfPublication.Year;
				const int hellOfAYear = 2020;
				int compareValue = hellOfAYear - yearOfPubl;
				if (compareValue < num)
					yield return qq;
			}

		}
		public IEnumerable GetMembWithout(string bb)
		{
			foreach (Paper qq in PublicationsList)
			{
				int indexOfString = qq.NameOfPublication.IndexOf(bb);
				if (indexOfString >= 0 && indexOfString < 100)
					yield return qq;
			}

			
		}
	}
}

