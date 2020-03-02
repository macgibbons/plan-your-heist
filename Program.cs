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

            // Dictionary<string, int> bankDifficulty = new Dictionary<string, int> ();
            // bankDifficulty.Add ("Difficulty", 100);

            int bankDifficulty = 100;
            int teamSkill = 0;

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
            // iterating over the team members to add all of their skills and storing them in teamSkill
            foreach (Dictionary<string, string> member in teamMembers)
            {
                foreach (KeyValuePair<string, string> individual in member)
                {
                    if (individual.Key == "Skill")
                    {
                        teamSkill += int.Parse (individual.Value);

                    }
                }

            }
            // comparing the sum of the team members skills to the difficulty of the bank
            if (teamSkill >= bankDifficulty)
            {
                Console.WriteLine ("You succesfully robbed the bank! 💰");
            }
            else
            {
                Console.WriteLine ("Your heist failed 💣");

            }
        }
    }
}