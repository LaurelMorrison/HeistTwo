using System;

namespace HeistTwo
{
    public class LockSpecialist : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformanceSkill(Bank bank, int SkillLevel)
        {
            int BankScore = (bank.VaultScore - SkillLevel);
            Console.WriteLine($"{Name} is picking the lock. Decrease the security points by {SkillLevel}");
            if (BankScore <= 0)
            {
                Console.WriteLine($"{Name} has disabled picked the lock!");
            }
        }
    }
}