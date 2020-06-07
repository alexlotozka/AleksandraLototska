using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
	class Paper
	{
		public string NameOfPublication { get; set; }
		public Person AuthorName { get; set; }
		public DateTime DateOfPublication { get; set; }
		public Paper(string Name, DateTime date, Person qq)
		{
			this.NameOfPublication = Name;
			this.DateOfPublication = date;
			AuthorName = qq;
		}
		
		public Paper()
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
}
