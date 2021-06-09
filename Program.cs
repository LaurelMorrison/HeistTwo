using System;
using System.Collections.Generic;
using System.Linq;

namespace HeistTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            LockSpecialist Taryn = new LockSpecialist()
            {
                Name = "Taryn",
                SkillLevel = 30,
                PercentageCut = 20
            };
            LockSpecialist Bre = new LockSpecialist()
            {
                Name = "Bre",
                SkillLevel = 25,
                PercentageCut = 40
            }; ;
            Muscle Preston = new Muscle()
            {
                Name = "Preston",
                SkillLevel = 5,
                PercentageCut = 10
            };
            Muscle Gus = new Muscle()
            {
                Name = "Gus",
                SkillLevel = 50,
                PercentageCut = 25
            }; ;
            Hacker Meg = new Hacker()
            {
                Name = "Meg",
                SkillLevel = 20,
                PercentageCut = 20
            }; ;
            Hacker Laurel = new Hacker()
            {
                Name = "Laurel",
                SkillLevel = 25,
                PercentageCut = 25
            };

            List<IRobber> rolodex = new List<IRobber>()
            {
                Taryn, Bre, Preston, Gus, Meg, Laurel
            };

            Console.Write($"There are {rolodex.Count()} possible crew members.");
            Console.Write("Have anyone in mind to build out the team?");
            string name = Console.ReadLine();
            Console.WriteLine($"What is {name}'s Speciality? \n 1.Hacker (Disables alarms) \n 2.Muscle (Disarms guards) \n 3.Lock Specialist (cracks vault)");
            int SpecialityNumb = Int32.Parse(Console.ReadLine());
            Console.Write($"What is {name}'s skill level (1-100)? ");
            int skillLevel = Int32.Parse(Console.ReadLine());
            Console.Write($"I see...What would {name} want as a cut? ");
            int percentageCut = Int32.Parse(Console.ReadLine());

            if (SpecialityNumb == 1)
            {
                Hacker NewMemb = new Hacker()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentageCut
                };
                rolodex.Add(NewMemb);
            }
            else if (SpecialityNumb == 2)
            {
                Muscle NewMemb = new Muscle()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentageCut
                };
                rolodex.Add(NewMemb);
            }
            else if (SpecialityNumb == 3)
            {
                LockSpecialist NewMemb = new LockSpecialist()
                {
                    Name = name,
                    SkillLevel = skillLevel,
                    PercentageCut = percentageCut
                };
                rolodex.Add(NewMemb);
            }
            else
            {
                Console.WriteLine("That dude is fake. Are you a cop?");
            }
        }
    }
}
