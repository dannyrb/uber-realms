using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace wServer.realm.entities
{
    class MerchantLists
    {

        public static Dictionary<int, Tuple<int, CurrencyType>> prices = new Dictionary<int, Tuple<int, CurrencyType>>(){  //////////////PRICES ONLY\\\\\\\\\\\\\
                                  



//Rings t4
{0xac0, new Tuple<int,CurrencyType>(10, CurrencyType.Fame)}, //Defense
{0xac5, new Tuple<int,CurrencyType>(10, CurrencyType.Fame)}, //Attack
{0xabf, new Tuple<int,CurrencyType>(10, CurrencyType.Fame)}, //Speed
{0xac1, new Tuple<int,CurrencyType>(10, CurrencyType.Fame)}, //Vitality
{0xac2, new Tuple<int,CurrencyType>(10, CurrencyType.Fame)}, //Wisdom
{0xac3, new Tuple<int,CurrencyType>(10, CurrencyType.Fame)}, //Dexterity
{0xac4, new Tuple<int,CurrencyType>(10, CurrencyType.Fame)}, //Health
{0xac6, new Tuple<int,CurrencyType>(10, CurrencyType.Fame)}, //Magic


//Armor t9
{2656, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Robe 
{0xa13, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Heavy
{0xad3, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Leather



//Armor t12
{0xa93, new Tuple<int,CurrencyType>(125, CurrencyType.Fame)}, //Abyssal
{0xa96, new Tuple<int,CurrencyType>(125, CurrencyType.Fame)}, //Elder Warlock
{0xa90, new Tuple<int,CurrencyType>(125, CurrencyType.Fame)}, //Griffon Hide


//Armor t13
{0xafc, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Acrop
{0xb05, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //G sorc
{0xaf9, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Hydra Hide

                                  
//weapons t10
{0xa89, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Dagger
{0xa84, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Sword
{0xa8c, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Bow 
{0xf27, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Blades
{0xaa1, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Staff 
{0xa86, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Wand 
{0xc4e, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, // Katana

                                  
//Abilities t4

{0xf30, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Jacket
{0xab5, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Trap 
{0xc57, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, // Star


//Abilities t7
{0xf04, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, // Spell 
{0xf05, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Tome 
{0xf03, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Quiver 
{0xf02, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Cloak 
{0xf06, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Helm 
{0xf07, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Shield 
{0xf0a, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Seal 
{0xf09, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Poison
{0xf00, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Skull
{0xf08, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Orb
{0xf0b, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Prism
{0xf0c1, new Tuple<int,CurrencyType>(250, CurrencyType.Fame)}, //Scepter 


// Effusions 
{0xb13, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, // Defense
{0xb10, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, // Dexterity
{0xb11, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, // Life
{0xb12, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, // Mana


//randum stuff
{2878, new Tuple<int,CurrencyType>(150, CurrencyType.Fame)}, //Amulet of Resurrection
{0xaeb, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Greater Health Potion
{0xaec, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Greater Magic Potion
{0x161f, new Tuple<int,CurrencyType>(2000, CurrencyType.Fame)}, //Valentine


// dyes (For now)
// Clothing
{0x1007, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Black
{0x1009, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Blue
{0x100b, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Brown
{0x1010, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Coral
{0x1012, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Cornsilk
{0x1015, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Dark Blue
{0x101f, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Dark Red
{0x1002, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Aqua
{0x1004, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Azure
{0x1033, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Green
{0x102f, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, // Ghost White
{0x1079, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Sienna
{0x1030, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Gold

//Accessory
{0x1107, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Black
{0x1109, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Blue
{0x110b, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Brown
{0x1110, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Coral
{0x1112, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Cornsilk
{0x1115, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Dark Blue
{0x111f, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Dark Red
{0x1102, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Aqua
{0x1104, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Azure
{0x1133, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Green
{0x112f, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Ghost White
{0x1179, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Sienna
{0x1130, new Tuple<int,CurrencyType>(20, CurrencyType.Fame)}, //Gold


        };

      /*  public static int[] store1List = { 0x701, 0x705, 0x706, 0x70a, 0x70b, 0x710, 0x71f, 0x722, 0xc11, 0xc19, 0xc23, 0xc2e, 0xc3d }; //keys */
        public static int[] store1List = { }; // Keys (?) added to the map 
        public static int[] store2List = { }; // ????
        public static int[] store3List = { 0xa89, 0xa84, 0xa8c, 0xf27, 0xaa1, 0xa86, 0xc4e}; // weapons
        public static int[] store4List = { 0xa90, 0xaf9, 0xa96, 0xb05, 0xa93, 0xafc, }; //armor
        public static int[] store5List = { 0xb10, 0xb11, 0xb12, 0xb13, 0xaeb, 0xaec }; //Consumables
        public static int[] store6List = { 0xac0, 0xac5, 0xabf, 0xac1, 0xac2, 0xac3, 0xac4, 0xac6, 2878, 2878, }; // Rings
        public static int[] store7List = { 0xf04, 0xf00, 0xf02, 0xf03, 0xf05, 0xf06, 0xf07, 0xf08, 0xf09, 0xf0a, 0xf0b, 0xf0c, }; // Empty
        public static int[] store8List = { 0x1007, 0x1009, 0x100b, 0x1010, 0x1012, 0x1015, 0x101f, 0x1002, 0x1004, 0x1033, 0x102f, 0x1079, 0x1030 }; // Large Dyes
        public static int[] store9List = { 0x1107, 0x1109, 0x110b, 0x1110, 0x1112, 0x1115, 0x111f, 0x1102, 0x1104, 0x1133, 0x112f, 0x1179, 0x1130, }; // Small Dyes




        public static Dictionary<string, int[]> shopLists = new Dictionary<string, int[]>() {           
            
        };

        public static void AddPetShop()
        {
            List<int> PetShop = new List<int>();
            for(var i = 0x1500; i < 0x1541; i++)
            {
                PetShop.Add((int)i);
            }
            shopLists.Add("pets", PetShop.ToArray());
            PetShop.Shuffle();
            shopLists.Add("pets2", PetShop.ToArray());
            PetShop.Shuffle();
            shopLists.Add("pets3", PetShop.ToArray());
        }

        public static void GetKeys()
        {
            List<int> nkeys = new List<int>();
            foreach (var i in XmlDatas.Keys)
            {
                prices[(int)i] = new Tuple<int, CurrencyType>(XmlDatas.KeyPrices[i], CurrencyType.Fame);
                nkeys.Add((int)i);
            }
            shopLists["keys"] = nkeys.ToArray();
        }


        public static void AddCustomShops()
        {
            foreach (var i in XmlDatas.ItemPrices)
            {
                prices.Add(i.Key, new Tuple<int, CurrencyType>(i.Value, CurrencyType.Fame));
            }
            foreach (var i in XmlDatas.ItemShops)
            {
                if (shopLists.ContainsKey(i.Value))
                {
                    List<int> ls = shopLists[i.Value].ToList();
                    ls.Add(i.Key);
                    shopLists[i.Value] = ls.ToArray();
                }
                else
                {
                    shopLists.Add(i.Value, new int[] { i.Key });
                }
            }
        }
    }
}