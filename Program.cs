using System;
using System.Collections.Generic;

namespace plan_your_heist
{
    class Program
    {
        static void Main (string[] args)
        {
            Console.WriteLine ("Plan your Heist!");

            Dictionary<int, string> teamMember = new Dictionary<int, string> ();
            Dictionary<int, int> memberSkill = new Dictionary<int, int> ();
            Dictionary<int, decimal> memberCourage = new Dictionary<int, decimal> ();

            while (true)
            {

                Console.WriteLine ("Enter your teammates name");
                string singleMemberName = Console.ReadLine ();
                if (singleMemberName == "")
                {
                    break;
                }

                teamMember.Add ((teamMember.Count + 1), singleMemberName);

                Console.WriteLine ("Enter your teammates skill level");
                memberSkill.Add ((teamMember.Count + 1), int.Parse (Console.ReadLine ()));

                Console.WriteLine ("Enter your teammates courage level 0.0 - 2.0 ");
                memberCourage.Add ((teamMember.Count + 1), decimal.Parse (Console.ReadLine ()));

            }
            foreach (KeyValuePair<int, string> name in teamMember)
            {
                // Console.WriteLine ($"{name.Key}: {name.Value}");
                foreach (KeyValuePair<int, int> skill in memberSkill)
                {
                    if (skill.Key == name.Key)
                    {
                        foreach (KeyValuePair<int, decimal> courage in memberCourage)
                        {
                            if (courage.Key == name.Key)
                            {

                                Console.WriteLine ($"{name.Value} skilllevel: {skill.Value}, courageLevel: {courage.Value}");
                            }
                        }
                    }
                }
            }
        }
    }
}