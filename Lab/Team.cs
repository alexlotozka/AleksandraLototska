using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
	class Team : INameAndCopy
	{
		protected string NameOrg;
		protected int RegNumb;
		public string Name { get; set; } /*вписали нейм*/
		public Team(string nameorg, int regnumb)
		{
			this.NameOrg = nameorg;
			this.RegNumb = regnumb;
		}
		public Team()
		{
			NameOrg = "Red Circle";
			RegNumb = 33;
		}
		public virtual object DeepCopy()
		{
			Team t = new Team();
			t.NameOrganisation = this.NameOrganisation;
			t.RegNumber = this.RegNumber;
			t.Name = this.Name;		
			return t;
		}

		public string NameOrganisation
		{
			get { return NameOrg; }
			set { NameOrg = value; }
		}
		public int RegNumber
		{
			get { return RegNumb; }
			set
			{
				if (RegNumb <= 0)
					throw new IndexOutOfRangeException("null");
					RegNumb = value;
				
			}
		}
		public override bool Equals(object obj)
		{
			if (obj.GetType() != this.GetType()) return false;
			Team t = (Team)obj;
			return (this.NameOrganisation == t.NameOrganisation && this.RegNumber == t.RegNumber && this.Name == t.Name);
		}
		public virtual int GetHashCode()
		{
			return Name.GetHashCode() + NameOrganisation.GetHashCode() + RegNumber.GetHashCode();
		}
		public virtual string ToString()
		{
			return $"{Name} {NameOrganisation} {RegNumber}";
		}

	}
}
