using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Plan your Heist!");

            List<Dictionary<string, string>> teamMembers = new List<Dictionary<string, string>> ();

            // Dictionary<int, int> memberSkill = new Dictionary<int, int> ();
            // Dictionary<int, decimal> memberCourage = new Dictionary<int, decimal> ();

            while (true)
            {

                Dictionary<string, string> teamMember = new Dictionary<string, string> ();
                Console.WriteLine ("Enter your teammates name");
                string singleMemberName = Console.ReadLine ();
                if (singleMemberName == "")
                {
                    break;
                }

                teamMember.Add ("Name", singleMemberName);

                Console.WriteLine ("Enter your teammates skill level");
                teamMember.Add ("Skill", Console.ReadLine ());

                Console.WriteLine ("Enter your teammates courage level 0.0 - 2.0 ");
                teamMember.Add ("Courage", Console.ReadLine ());

                teamMembers.Add (teamMember);

            }
            foreach (Dictionary<string, string> member in teamMembers)
            {
                foreach (KeyValuePair<string, string> individual in member)
                {
                    Console.WriteLine ($"{individual.Key}: {individual.Value}");
                }

            }
        }
    }
}