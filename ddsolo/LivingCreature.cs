using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ddsolo;
namespace ddsolo
{
    public class LivingCreature
    {
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public LivingCreature(int currenthp, int maxhp)
        {
            MaxHP = maxhp;
            CurrentHP = currenthp;
        }
    }
}