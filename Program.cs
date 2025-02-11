﻿using System;
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

            NewMemberQuestion();

            void NewMemberQuestion()
            {
                Console.WriteLine($"There are {rolodex.Count()} possible crew members.");
                Console.Write("Have anyone in mind to build out the team. What's their name? ");
                string name = Console.ReadLine();

                if (name == "")
                {
                    Console.WriteLine("Okay, we have all our prospects");
                }

                else
                {

                    Console.WriteLine($"What is {name}'s Speciality? \n 1. Hacker (Disables alarms) \n 2. Muscle (Disarms guards) \n 3. Lock Specialist (cracks vault) ");
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
                        Console.Write("Are you a cop? The heist is off. ");
                        return;
                    }
                    NewMemberQuestion();
                }
            };

            Random r = new Random();
            Bank bank = new Bank()
            {
                AlarmScore = r.Next(0, 100),
                VaultScore = r.Next(0, 100),
                SecurityGuardScore = r.Next(0, 100),
                CashOnHand = r.Next(50000, 1000000),
            };
            int[] BankScores = { bank.AlarmScore, bank.VaultScore, bank.SecurityGuardScore };

            Recon();

            void Recon()
            {
                Console.WriteLine($"Most secure: {BankScores.Max()}");
            }

        }
    }
}
