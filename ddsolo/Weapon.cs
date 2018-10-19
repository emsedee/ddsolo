namespace ddsolo
{
    public class Weapon : Item
    {
         public int MinDMG { get; set; }
        public int MaxDMG { get; set; }
        public Weapon(int id, string name, string namePlural, int mindmg, int maxdmg) : base(id, name, namePlural)
        {
            MinDMG = mindmg;
            MaxDMG = maxdmg;
        }
    }
}