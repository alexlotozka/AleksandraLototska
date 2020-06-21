using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam g = new ResearchTeam();
            g.AddPapers(new Paper(), new Paper("Parfumer", new DateTime(1995, 11, 12), new Person("Patrik", "Zuskind", new DateTime(1978))),
            new Paper("War and Peace", new DateTime(1865, 1, 1), new Person("Leo", "Tolstoi", new DateTime(1828, 9, 12))));

            Console.WriteLine(g.ToString());
            Console.WriteLine(g.ToShortString());

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

            g.AddPapers(new Paper("No article", new DateTime(1920, 1, 23), new Person("Oliver", "Queen", new DateTime(1900, 10, 17))));
            g.AddPapers(new Paper("No article", new DateTime(1843, 2, 12), new Person("Lucifer", "Morningstar", new DateTime(1800, 9, 1))));

            Console.WriteLine("\n");

            Console.WriteLine("Last articles:");
            foreach (Paper a in g.GetLastArticles(20))
            {
                Console.WriteLine(a.NameOfPublication);
            }

            Console.WriteLine("\n");

            Console.WriteLine("Authors without articles:");
            foreach (Paper a in g.GetMembWithout("No"))
            {
                Console.WriteLine(a.AuthorName);
            }
        }
    }
}
