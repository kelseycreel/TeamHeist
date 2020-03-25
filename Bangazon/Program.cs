using System;
using System.Collections.Generic;
using System.Linq;

namespace TeamHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TeamMember> myTeam = new List<TeamMember>();
            var bankDifficultyLevel = 100;

            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("How many members are on your team?");
            var teamCapacity = Console.ReadLine();

            int i = 0;
            do
            {
                i++;
                Console.WriteLine("Please enter the name of your team member.");
                var tMName = Console.ReadLine();

                Console.WriteLine($"Please enter the skill level of {tMName} (Has to be a positive number).");
                var tMSkill = Console.ReadLine();
                var tMSkillLevel = Int32.Parse(tMSkill);
                while (tMSkillLevel < 0)
                {
                    Console.WriteLine($"Invalid skill level. Please enter a positive number.");
                    tMSkill = Console.ReadLine();
                    tMSkillLevel = Int32.Parse(tMSkill);
                }

                Console.WriteLine($"Please enter the courage factor of {tMName} (any number between 0.0 and 2.0).");
                var tMCourage = Console.ReadLine();
                var tMCourageFactor = Convert.ToDecimal(tMCourage);
                while (tMCourageFactor < 0.0m || tMCourageFactor > 2.0m)
                {
                    Console.WriteLine($"Invalid courage factor. Please enter any number between 0.0 and 2.0.");
                    tMCourage = Console.ReadLine();
                    tMCourageFactor = Convert.ToDecimal(tMCourage);
                }

                myTeam.Add(new TeamMember(tMName, tMSkillLevel, tMCourageFactor));

                Console.WriteLine($"{tMName} has a skill level of {tMSkillLevel} and a courage factor of {tMCourageFactor}, and has been added to your team!");
                Console.ReadLine();
            }
            while (i < Int32.Parse(teamCapacity));

            Console.WriteLine($"You have {teamCapacity} team members! ");

            foreach (var member in myTeam)
            {
                Console.WriteLine($"{member.Name}: Skill - {member.SkillLevel},  Courage -{member.CourageFactor}");
            }

            Console.Clear();

            var sumSkillLevel = myTeam.Select(level => level.SkillLevel).Sum();

            if (sumSkillLevel >= bankDifficultyLevel)
            {
                Console.WriteLine("Success! Your team had enough skill to rob the bank!");
            }
            else
            {
                Console.WriteLine("Fail! Your team did not have enough skill to rob the bank!");
            }


            Console.ReadLine();
        }
    }
}
