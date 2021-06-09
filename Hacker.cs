using System;

namespace HeistTwo
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformanceSkill(Bank bank, int SkillLevel)
        {
            int BankScore = (bank.AlarmScore - SkillLevel);
            Console.WriteLine($"{Name} is hacking the alarm system. Decrease the security points by {SkillLevel}");
            if (BankScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled the alarm system!");
            }
        }
    }
}