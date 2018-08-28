using System;
using System.Collections.Generic;

namespace dreamTeam
{
    class Program
    {
        static void Main(string[] args)
        {

            List<DreamTeam> theDreamTeam = new List<DreamTeam>(){
                new William(),
                new Leah(),
                new Vik(),
                new Michael(),
                new Adelaide(),
                new Seth(),
            };

            foreach (DreamTeam member in theDreamTeam)
            {
                System.Console.WriteLine(member.Work());
            }
        }
    }
}
