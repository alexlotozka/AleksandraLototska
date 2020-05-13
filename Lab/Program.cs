using System;

namespace Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            ResearchTeam g = new ResearchTeam();
            g.AddPapers(new Paper() , new Paper("Wallet" , new DateTime (1995 , 11 , 12)));
            Console.WriteLine(g.ToString());

        }
    }
}
