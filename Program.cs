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

     
            
            Console.WriteLine ("How many Times are you going to try?");
            int trials = int.Parse (Console.ReadLine ());

            Console.WriteLine ("Whats the banks difficulty level");
            int bankDifficulty = int.Parse (Console.ReadLine ());

            // setting the number of successful and failed runs
            int succesfulRuns = 0; 
            int unsuccesfulRuns = 0; 
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
                

            for (int i = 0; i < trials; i++)
            {
                
            Random rand = new Random ();
            int heistLuck = rand.Next (-10, 11);
            bankDifficulty += heistLuck;

                    Console.WriteLine($"Round {i + 1}");
                if (teamSkill >= bankDifficulty)
                {
                    Console.WriteLine ("You succesfully robbed the bank! 💰");
                    Console.WriteLine ($"Team Skill Level: {teamSkill}");
                    Console.WriteLine ($"Bank Difficulty Level: {bankDifficulty}");
                    succesfulRuns += 1;
                    
                }
                else
                {
                    Console.WriteLine ("Your heist failed 🚫");
                    Console.WriteLine ($"Team Skill Level: {teamSkill}");
                    Console.WriteLine ($"Bank Difficulty Level: {bankDifficulty}");
                    unsuccesfulRuns += 1;

                }

                
            }
                Console.WriteLine($"🏆 Successful Heists: {succesfulRuns} 🏆");
                Console.WriteLine($"👎 Faied Heists: {unsuccesfulRuns} 👎");
        }
    }
}