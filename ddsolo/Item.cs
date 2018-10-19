using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ddsolo;

    public class Item
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string NameMeervoud { get; set; }
    public Item(int id, string name, string namemeerdvoud)
    {
        ID = id;
        Name = name;
        NameMeervoud = namemeerdvoud;
    }
}