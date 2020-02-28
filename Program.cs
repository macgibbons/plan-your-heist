using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Plan your Heist!");
            Console.WriteLine ("Enter your teammates name");
            Dictionary<string, string> teamMember = new Dictionary<string, string> ();
            teamMember.Add ("Name", Console.ReadLine ());

            Console.WriteLine ("Enter your teammates skill level");
            Dictionary<string, int> memberSkill = new Dictionary<string, int> ();
            teamMember.Add ("Skill", Console.ReadLine ());

            Console.WriteLine ("Enter your teammates courage level 0.0 - 2.0 ");
            Dictionary<string, decimal> memberCourage = new Dictionary<string, decimal> ();
            teamMember.Add ("Courage", Console.ReadLine ());

            foreach (KeyValuePair<string, string> name in teamMember)
            {
                Console.WriteLine ($"{name.Key}: {name.Value}");
            }
        }
    }
}