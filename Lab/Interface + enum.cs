using System;
using System.Collections.Generic;
using System.Text;

namespace Lab
{
	enum TimeFrame
	{
		Year = 1,
		TwoYears,
		Long
	}
	interface INameAndCopy
	{
		string Name { get; set; }
		 object DeepCopy();
	}
}
