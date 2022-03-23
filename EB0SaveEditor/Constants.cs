using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EB0SaveEditor
{
    class Constants
    {
        //public static int OFFSET = 0x1283;
        //public static int REDUNCANCY = 0x2FD;
        public static int OFFSET = 0;
        public static int REDUNCANCY = 0;

        public static string[] dict = {
            " ", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "!", "?", "..", "$", "'", "\"", "\\", "(", ")", ":", ";", ",", "-", ".", "/", "*", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "$", "α", "β", "γ", "π",
            "Ω", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "*", "*", "*", "*", "*",
            "*", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
        };

        public static int[] MONEY = { 0x1410, 0x1411 };
        public static int[] BANK_MONEY = { 0x1412, 0x1414 };
        public static int[] STORED_ITEMS = { 0x16B0, 0x16CF };
        public static int[] YOUR_NAME = { 0x1420, 0x1430 };
        public static int[] FAV_FOOD = { 0x1689, 0x1693 };

        //CHARACTERS
        public static string[] CHARACTERS =
        {
            "Ninten",
            "Ana",
            "Loid",
            "Teddy",
            "Pippi",
            "Eve",
            "Flying Man"
        };

        public static int NINTEN = 0x00;
        public static int ANA = 0x40;
        public static int LOID = 0x80;
        public static int TEDDY = 0xC0;
        public static int PIPPI = 0x100;
        public static int EVE = 0x140;
        public static int FLY = 0x180;

        //CHARACTER STATS
        static int STATUS = 0x1441;
        public static int[] MAX_HP = { 0x1443, 0x1444 };
        public static int[] MAX_PP = { 0x1445, 0x1446 };
        public static int[] OFFENSE = { 0x1447, 0x1448 };
        public static int[] DEFENSE = { 0x1449, 0x144A };
        public static int FIGHT = 0x144B;
        public static int SPEED = 0x144c;
        public int WISDOM = 0x144d;
        public static int STRENGTH = 0x144e;
        public static int FORCE = 0x144f;
        public static int LEVEL = 0x1450;
        public static int[] EXPERIENCE = { 0x1451, 0x1453 };
        public static int[] CURRENT_HP = { 0x1454, 0x1455 };
        public static int[] CURRENT_PP = { 0x1456, 0x1457 };
        public static int[] ITEMS = { 0x1460, 0x1467 };
        public static int WEAPON = 0x1468;
        public static int COIN = 0x1469;
        public static int RING = 0x146a;
        public static int PENDANT = 0x146b;
        public static int[] MAGIC = { 0x1470, 0x1477 };
        public static int[] NAME = { 0x1478, 0x147e };

        //ENEMY STATS
        public static int E_STATUS = 0x2681;
        public static int[] E_HP = { 0x2683, 0x2684 };
        public static int[] E_PP = { 0x2685, 0x2686 };
        public static int[] E_OFFENSE = { 0x2687, 0x2688 };
        public static int[] E_DEFENSE = { 0x2689, 0x268a };
        public static int E_FIGHT = 0x268b;
        public static int E_SPEED = 0x268c;
        public static int E_WISDOM = 0x268d;
        public static int E_STRENGTH = 0x268e;
        public static int E_FORCE = 0x268f;
        public static int E_IDENTITY = 0x2698;

        //STATUS
        public static int NOTHING = 0x0;
        public static int COLD = 0x1;
        public static int POISON = 0x2;
        public static int PUZZLED = 0x4;
        public static int CONFUSED = 0x8;
        public static int SLEEP = 0x10;
        public static int PARALYSIS = 0x20;
        public static int STONE = 0x40;
        public static int FAINTED = 0x80;

        //ITEMS
        public static int BIG_BAG = 0x01;
        public static int PHONE_CARD = 0x02;
        public static int CRUMBS = 0x03;

        //WEAPONS
        public static int BUTTER_KNIFE = 0xa;
        public static int SURV_KNIFE = 0xb;
        public static int SWORD = 0xc;
        public static int KATANA = 0xd;
        public static int STUN_GUN = 0xe;
        public static int AIR_GUN = 0xf;
        public static int PLASTIC_BAT = 0x10;
        public static int WOOD_BAT = 0x11;
        public static int ALUM_BAT = 0x12;
        public static int HANK_BAT = 0x13;
        public static int FRYING_PAN = 0x14;
        public static int NONSTICK_PAN = 0x15;
        public static int IRON_SKILLET = 0x16;
        public static int SLINGSHOT = 0x17;
        public static int BOOMERANG = 0x18;

        //MORE ITEMS
        public static int INSECTICIDE = 0x19;
        public static int SUPER_SPRAY = 0x20;
        public static int FLEA_BAG = 0x1b;
        public static int WORDS_O_LOVE = 0x1c;
        public static int SWEAR_WORDS = 0x1d;
        public static int STKY_MACHINE = 0x1e;
        public static int FLASHDARK = 0x1f;
        public static int STONEORIGIN = 0x20;
        public static int POISON_NEEDLE = 0x21;
        public static int FL_THROWER = 0x22;
        public static int BOMB = 0x23;
        public static int SUPER_BOMB = 0x24;
        public static int LASER_BOMB = 0x25;
        public static int PLASMA_BEAM = 0x26;
        public static int ROPE = 0x28;

        //COINS
        public static int PEACE_COIN = 0x2d;
        public static int PROTECT_COIN = 0x2e;
        public static int MAGIC_COIN = 0x2f;

        //RINGS
        public static int REPEL_RING = 0x4;
        public static int BRASS_RING = 0x30;
        public static int SILVER_RING = 0x31;
        public static int GOLD_RING = 0x32;

        //PENDANTS
        public static int H20_PENDANT = 0x33;
        public static int FIRE_PENDANT = 0x34;
        public static int EARTH_PENDANT = 0x35;
        public static int SEA_PENDANT = 0x36;

        //STILL MORE ITEMS
        public static int ORANGE_JUICE = 0x3c;
        public static int FRENCH_FRIES = 0x3d;
        public static int MAGIC_HERB = 0x3e;
        public static int HAMBURGER = 0x3f;
        public static int SPORTS_DRINK = 0x40;
        public static int LIFEUP_CREAM = 0x41;
        public static int ASTHMA_SPRAY = 0x42;
        public static int ANTIDOTE = 0x43;
        public static int MOUTH_WASH = 0x44;
        public static int BERRY_TOFU = 0x45;

        public static int BREAD = 0x47;
        public static int NOBLE_SEED = 0x48;
        public static int PSI_STONE = 0x49;
        public static int MAGIC_RIBBON = 0x4b;
        public static int MAGIC_CANDY = 0x4c;
        public static int QUICK_CAPSULE = 0x4e;
        public static int WIS_CAPSULE = 0x4f;
        public static int PHYS_CAPSULE = 0x50;
        public static int FORCE_CAPSULE = 0x51;
        public static int FIGHT_CAPSULE = 0x52;
        public static int BASEMENT_KEY = 0x55;
        public static int ZOO_KEY = 0x56;
        public static int GHOST_KEY = 0x57;
        public static int GGF_DIARY = 0x58;
        public static int PASS = 0x59;
        public static int TICKET = 0x5a;
        public static int CANARY_CHICK = 0x5f;
        public static int BOTTLE_ROCKET = 0x61;
        public static int HAT = 0x62;
        public static int DENTURES = 0x63;
        public static int TICKET_STUB = 0x64;
        public static int IC_CHIP = 0x65; //broken
        public static int OCARINA = 0x66;
        public static int FRANK_BADGE = 0x68;
        public static int FRND_RING = 0x69; //broken
        public static int ONYX_HOOK = 0x6b;
        public static int LAST_WEAPON = 0x6c;
        public static int RULER = 0x6d;
        public static int CASH_CARD = 0x6e;
        public static int RED_WEED = 0x6f;
        public static int BULLHORN = 0x70;
        public static int MAP = 0x71; //broken
        public static int DEBUG = 0x7f; //broken
        public static int REAL_ROCKET = 0xa6; //broken
        public static int TIME_MACHINE = 0xa8; //broken

        public static String[] ITEM_DICT =
        {
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*",
            "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*", "*"
        };

        public static void itemTableBuilder()
        {
            ITEM_DICT[NOTHING] = "(EMPTY)";
            ITEM_DICT[BIG_BAG] = "Big Bag";
            ITEM_DICT[PHONE_CARD] = "Phone Card";
            ITEM_DICT[CRUMBS] = "Crumbs";
            ITEM_DICT[BUTTER_KNIFE] = "Butter Knife";
            ITEM_DICT[SURV_KNIFE] = "Surv. Knife";
            ITEM_DICT[SWORD] = "Sword";
            ITEM_DICT[KATANA] = "Katana";
            ITEM_DICT[STUN_GUN] = "Stun Gun";
            ITEM_DICT[AIR_GUN] = "Air Gun";
            ITEM_DICT[PLASTIC_BAT] = "Platic Bat";
            ITEM_DICT[WOOD_BAT] = "Wooden Bat";
            ITEM_DICT[ALUM_BAT] = "Aluminum Bat";
            ITEM_DICT[HANK_BAT] = "Hank's Bat";
            ITEM_DICT[FRYING_PAN] = "Frying Pan";
            ITEM_DICT[NONSTICK_PAN] = "Nonstick Pan";
            ITEM_DICT[IRON_SKILLET] = "IronSkillet";
            ITEM_DICT[SLINGSHOT] = "Slingshot";
            ITEM_DICT[BOOMERANG] = "Boomerang";
            ITEM_DICT[INSECTICIDE] = "Insecticide";
            ITEM_DICT[SUPER_SPRAY] = "Super Spray";
            ITEM_DICT[FLEA_BAG] = "Flea Bag";
            ITEM_DICT[WORDS_O_LOVE] = "Words o' Love";
            ITEM_DICT[SWEAR_WORDS] = "Swear Words";
            ITEM_DICT[STKY_MACHINE] = "StkyMachine";
            ITEM_DICT[FLASHDARK] = "Flashdark";
            ITEM_DICT[STONEORIGIN] = "StoneOrigin*";
            ITEM_DICT[POISON_NEEDLE] = "PoisonNeedle*";
            ITEM_DICT[FL_THROWER] = "Fl Thrower";
            ITEM_DICT[BOMB] = "Bomb";
            ITEM_DICT[SUPER_BOMB] = "Super Bomb";
            ITEM_DICT[LASER_BOMB] = "Laser Beam";
            ITEM_DICT[PLASMA_BEAM] = "Plasma Beam";
            ITEM_DICT[ROPE] = "Rope";
            ITEM_DICT[PEACE_COIN] = "Peace Coin";
            ITEM_DICT[PROTECT_COIN] = "Protect Coin";
            ITEM_DICT[MAGIC_COIN] = "Magic Coin";
            ITEM_DICT[REPEL_RING] = "Repel Ring";
            ITEM_DICT[BRASS_RING] = "Brass Ring";
            ITEM_DICT[SILVER_RING] = "Silver Ring";
            ITEM_DICT[GOLD_RING] = "Gold Ring";
            ITEM_DICT[H20_PENDANT] = "H20 Pendant";
            ITEM_DICT[FIRE_PENDANT] = "Fire Pendant";
            ITEM_DICT[EARTH_PENDANT] = "Earth Pendant";
            ITEM_DICT[SEA_PENDANT] = "Sea Pendant";
            ITEM_DICT[ORANGE_JUICE] = "Orange Juice";
            ITEM_DICT[FRENCH_FRIES] = "French Fries";
            ITEM_DICT[MAGIC_HERB] = "Magic Herb";
            ITEM_DICT[HAMBURGER] = "Hamburger";
            ITEM_DICT[SPORTS_DRINK] = "Sports Drink";
            ITEM_DICT[LIFEUP_CREAM] = "LifeUp Cream";
            ITEM_DICT[ASTHMA_SPRAY] = "Asthma Spray";
            ITEM_DICT[ANTIDOTE] = "Antidote";
            ITEM_DICT[MOUTH_WASH] = "Mouth Wash";
            ITEM_DICT[BERRY_TOFU] = "Berry Tofu";
            ITEM_DICT[BREAD] = "Bread";
            ITEM_DICT[NOBLE_SEED] = "Noble Seed";
            ITEM_DICT[PSI_STONE] = "PSI Stone";
            ITEM_DICT[MAGIC_RIBBON] = "Magic Ribbon";
            ITEM_DICT[MAGIC_CANDY] = "Magic Candy";
            ITEM_DICT[QUICK_CAPSULE] = "Quick Capsule";
            ITEM_DICT[WIS_CAPSULE] = "Wisdom Capsule";
            ITEM_DICT[PHYS_CAPSULE] = "Physical Capsule";
            ITEM_DICT[FORCE_CAPSULE] = "Force Capsule";
            ITEM_DICT[FIGHT_CAPSULE] = "Fight Capsule";
            ITEM_DICT[BASEMENT_KEY] = "Basement Key";
            ITEM_DICT[ZOO_KEY] = "Zoo Key";
            ITEM_DICT[GHOST_KEY] = "Ghost Key";
            ITEM_DICT[GGF_DIARY] = "GGF's Diary";
            ITEM_DICT[PASS] = "Pass";
            ITEM_DICT[TICKET] = "Ticket";
            ITEM_DICT[CANARY_CHICK] = "Canary Chick";
            ITEM_DICT[BOTTLE_ROCKET] = "BottlRocket";
            ITEM_DICT[HAT] = "Hat";
            ITEM_DICT[DENTURES] = "Dentures";
            ITEM_DICT[TICKET_STUB] = "Ticket Stub";
            ITEM_DICT[IC_CHIP] = "IC Chip*";
            ITEM_DICT[OCARINA] = "Ocarina";
            ITEM_DICT[FRANK_BADGE] = "Franklin Badge";
            ITEM_DICT[FRND_RING] = "FrndshipRing*";
            ITEM_DICT[ONYX_HOOK] = "Onyx Hook";
            ITEM_DICT[LAST_WEAPON] = "Last Weapon";
            ITEM_DICT[RULER] = "Ruler";
            ITEM_DICT[CASH_CARD] = "Cash Card";
            ITEM_DICT[RED_WEED] = "Red Weed";
            ITEM_DICT[BULLHORN] = "Bullhorn";
            ITEM_DICT[MAP] = "Map*";
            ITEM_DICT[DEBUG] = "Debug*";
            ITEM_DICT[REAL_ROCKET] = "Real Rocket*";
            ITEM_DICT[TIME_MACHINE] = "Time Machine*";
        }
    }
}
