using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ddsolo;
namespace ddsolo
{
    public class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_CULL = 1;
        public const int ITEM_ID_RODANS_BLADE = 2;
        public const int ITEM_ID_RODANS_RING = 3;
        public const int ITEM_ID_SUNFIRE_CAPE = 4;
        public const int ITEM_ID_ZHONYAS_HOURGLASS = 5;
        public const int ITEM_ID_TRINITY_FORCE = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_BF_SWORD = 8;
        public const int ITEM_ID_RABADONS_DEATHCAP = 9;
        public const int ITEM_ID_NEEDLESSLY_LARGE_ROD = 10;
        public const int ITEM_ID_MASTER_DILDO_SWORD = 11;
        public const int ITEM_ID_ADVENTURER_PASS = 12;
        public const int ITEM_ID_ZOMBIE_HEAD = 13;
        public const int ITEM_ID_C_SHARP_BOOK = 14;


        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SKELETON = 2;
        public const int MONSTER_ID_ZOMBIE = 3;
        public const int MONSTER_ID_PVOOSTEN = 4;

        public const int QUEST_ID_CLEAR_GRAVEYARD = 2;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 1;
        public const int QUEST_ID_CLEAR_F30 = 3;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_GRAVEYARD = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_F30 = 10;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_CULL, "Cull", "culls", 0, 5));
            Items.Add(new Item(ITEM_ID_RODANS_BLADE, "Rodan's Blade", "Blades of rodan"));
            Items.Add(new Item(ITEM_ID_RODANS_RING, "Rodan's Ring", "Rings of Rodan"));
            Items.Add(new Item(ITEM_ID_SUNFIRE_CAPE, "Sunfire Cape", "Sunfire Capes"));
            Items.Add(new Item(ITEM_ID_ZHONYAS_HOURGLASS, "Zhonya's Hourglass", "Hourglasses of Zhonya"));
            Items.Add(new Weapon(ITEM_ID_TRINITY_FORCE, "3 swords in a triangle", "TONS OF DAMAGE", 3, 10));
            Items.Add(new Potion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5));
            Items.Add(new Weapon(ITEM_ID_BF_SWORD, "BF Sword", "Fucking big swords", 5, 15));
            Items.Add(new Item(ITEM_ID_RABADONS_DEATHCAP, "Rabadon's deathcap", "Rabadon's deathcaps"));
            Items.Add(new Item(ITEM_ID_NEEDLESSLY_LARGE_ROD, "Needlessly large rod", "needlessly large rods"));
            Items.Add(new Weapon(ITEM_ID_MASTER_DILDO_SWORD, "Master Dildo Sword", "Master Dildo Swords", 10, 15));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer Pass", "Adventurer passes"));
            Items.Add(new Item(ITEM_ID_ZOMBIE_HEAD, "Zombie head", "Zombie heads"));
            Items.Add(new Item(ITEM_ID_C_SHARP_BOOK, "A book of c#", "Stacks of code"));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 5, 5);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CULL), 75, true));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RODANS_BLADE), 75, false));


            Monster Skeleton = new Monster(MONSTER_ID_SKELETON, "Skeleton", 5, 3, 10, 25, 25);
            Skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SUNFIRE_CAPE), 75, false));
            Skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ZHONYAS_HOURGLASS), 75, false));
            Skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BF_SWORD), 5, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RODANS_RING), 75, true));

            Monster Zombie = new Monster(MONSTER_ID_ZOMBIE, "Zombie", 20, 5, 40, 75, 75);
            Zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TRINITY_FORCE), 5, false));
            Zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RABADONS_DEATHCAP), 25, false));
            Zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ZOMBIE_HEAD), 75, true));

            Monster PvOosten = new Monster(MONSTER_ID_PVOOSTEN, "fluppe", 50, 200, 500, 500, 500);
            Zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MASTER_DILDO_SWORD), 100, true));
            Zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_C_SHARP_BOOK), 100, true));

            Monsters.Add(rat);
            Monsters.Add(Skeleton);
            Monsters.Add(Zombie);
            Monsters.Add(PvOosten);
        }

        private static void PopulateQuests()
        {
            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill Skeleton's in the farmer's field and bring back 3 Rodans rings. You will receive an adventurer's pass and 20 gold pieces.", 20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RODANS_RING), 3));

            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quest Cleargraveyard =
                new Quest(
                    QUEST_ID_CLEAR_GRAVEYARD,
                    "Clear the Graveyard",
                    "Kill zombies in the graveyard and bring back 3 zombie heads. You will receive a healing potion and 10 gold pieces.", 20, 10);

            Cleargraveyard.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_ZOMBIE_HEAD), 3));

            Cleargraveyard.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quests.Add(Cleargraveyard);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a fountain.");

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_GRAVEYARD);

            Location graveyard = new Location(LOCATION_ID_GRAVEYARD, "Alchemist's graveyard", "Many undeads are growing here.");
            graveyard.MonsterLivingHere = MonsterByID(MONSTER_ID_ZOMBIE);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of bones laying around.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SKELETON);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "There is a large, tough-looking guard here.", ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location f30 = new Location(LOCATION_ID_F30, "Lokaal F30", "You see stacks of code laying around.");
            f30.MonsterLivingHere = MonsterByID(MONSTER_ID_PVOOSTEN);

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = graveyard;

            graveyard.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = f30;

            f30.LocationToWest = bridge;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(graveyard);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(f30);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
