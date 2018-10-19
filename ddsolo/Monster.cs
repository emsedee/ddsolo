using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ddsolo;
namespace ddsolo
{
    public class Monster : LivingCreature
    {
        public Monster(int iD, string name, int maxDMG, int experienceReward, int goldReward,int CurrentHP,int MaxHP)
            :base(CurrentHP, MaxHP)
        {
            ID = iD;
            Name = name;
            MaxDMG = maxDMG;
            ExperienceReward = experienceReward;
            GoldReward = goldReward;
            LootTable = new List<LootItem>();
        }
        public List<LootItem> LootTable { get; set; }
        public int ID { get; set; }
        public string Name { get; set; }
        public int MaxDMG { get; set; }
        public int ExperienceReward { get; set; }
        public int GoldReward { get; set; }
    }
}