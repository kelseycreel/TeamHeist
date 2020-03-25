using System;
using System.Collections.Generic;

namespace TeamHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string name, int skillLevel, decimal courageFactor)> heistskillz = new List<(string, int, decimal)>();

            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("How many members are on your team?");
            var tMCapacity = Console.ReadLine();

            int i = 0;
            do
            {

                Console.WriteLine("Please enter the name of your team member.");
                var tMName = Console.ReadLine();

                Console.WriteLine($"Please enter the skill level of {tMName} (Has to be a positive number).");
                var tMSkill = Console.ReadLine();
                var tMSkillFactor = Int32.Parse(tMSkill);
                while (tMSkillFactor < 0)
                {
                    Console.WriteLine($"Invalid skill level. Please enter a positive number.");
                    tMSkill = Console.ReadLine();
                    tMSkillFactor = Int32.Parse(tMSkill);
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

                heistskillz.Add((name: tMName, skillLevel: tMSkillFactor, courageFactor: tMCourageFactor));

                Console.WriteLine($"{tMName} has a skill level of {tMSkillFactor} and a courage factor of {tMCourageFactor}, and has been added to your team!");
                i++;
                Console.ReadLine();

            }
            while (i < Int32.Parse(tMCapacity));

            Console.WriteLine($"You have {tMCapacity} team members! ");

            foreach (var skill in heistskillz)
            {
                Console.WriteLine($"{skill.name}: Skill - {skill.skillLevel},  Courage - {skill.courageFactor}");

            }

            Console.ReadLine();
        }
    }
}
