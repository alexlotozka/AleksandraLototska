using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam g = new ResearchTeam();
            g.AddPapers(new Paper() , new Paper("Wallet" , new DateTime (1995 , 11 , 12)) , new Paper("War and Peace", new DateTime(1865, 9, 12)));
            Console.WriteLine(g.ToString());
            Console.WriteLine(g.ToShortString());
            Console.WriteLine(g.TheLast);
            //Person person1 = new Person("Alexandra", "Lototska" , new DateTime( 2000, 23, 9) );
            //Person person2 = new Person("Dima", "Ermusevych", new DateTime(1996, 17, 7));
            //Person person3 = new Person("Julia", "Godunova", new DateTime(1994, 15, 4));
            //bool p1Ep2 = person1.Equals(person2);
            //bool p1Ep3 = person1.Equals(person3);
            Team m = new Team();
            Team k = new Team();
            bool teamEquals = m.Equals(k);
            Console.WriteLine($" m = k => {teamEquals}");
            m.RegNumber = -1;
            Console.WriteLine($"{m.RegNumber}");

            ResearchTeam r = new ResearchTeam();
            r.AddMembers(new Team("Emily", 24));
            Console.WriteLine(r.ToString());

            Console.WriteLine($"{r.NameOrganisation}");

            r.DeepCopy();

            Paper q = new Paper("No article", new DateTime(2000, 00, 00), new Person("Oliver", "Queen", new DateTime(1939, 9, 1)));
            Paper qw = new Paper("No article", new DateTime(2000, 00, 00), new Person("Lucifer", "Morningstar", new DateTime(1939, 9, 1)));
        }
    }
}
