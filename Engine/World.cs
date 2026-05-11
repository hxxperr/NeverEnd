using System.Collections.Generic;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();
        public static readonly List<Character> Characters = new List<Character>();

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_TOAD_FOOT = 11;
        public const int ITEM_ID_TOAD_TONGUE = 12;
        public const int ITEM_ID_GOLD_RING = 13;
        public const int ITEM_ID_BOW = 14;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_GIANT_TOAD = 4;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;
        public const int QUEST_ID_TOWN_SQUARE_GOLDEN_TICKET = 3;
        public const int QUEST_ID_FIND_WIFE = 4;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_YARD = 10;
        public const int LOCATION_ID_SHOP = 11;

        public const int CHARACTER_ID_WIFE = 1;
        public const int CHARACTER_ID_BOOZER = 2;
        public const int CHARACTER_ID_DOG = 3;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateCharacters();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Ржавый меч", "Ржавые мечи", 1, 5));
            Items.Add(new Item(ITEM_ID_RAT_TAIL, "Крысиный хвост", "Крысиные хвосты"));
            Items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Кусок меха", "Куски меха"));
            Items.Add(new Item(ITEM_ID_SNAKE_FANG, "Змеиный клык", "Змеиные клыки"));
            Items.Add(new Item(ITEM_ID_SNAKESKIN, "Змеиная кожа", "Змеиные кожи"));
            Items.Add(new Weapon(ITEM_ID_CLUB, "Дубина", "Дубины", 3, 10));
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Лечебное зелье", "Лечебные зелья", 6));
            Items.Add(new Item(ITEM_ID_SPIDER_FANG, "Паучий клык", "Паучьи клыки"));
            Items.Add(new Item(ITEM_ID_SPIDER_SILK, "Паучий шелк", "Паучьи шелка"));
            Items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Пропуск охраны", "Пропуска охраны"));
            Items.Add(new Item(ITEM_ID_TOAD_FOOT, "Жабья лапка", "Жабьи лапки"));
            Items.Add(new Item(ITEM_ID_TOAD_TONGUE, "Жабий язык", "Жабьи языки"));
            Items.Add(new Item(ITEM_ID_GOLD_RING, "Золотое кольцо Анны", "Золотые кольца Анны"));
            Items.Add(new Weapon(ITEM_ID_BOW, "Охотничий лук", "Охотничьи луки", 5, 14));
        }

        private static void PopulateCharacters()
        {
            Characters.Add(new Character(CHARACTER_ID_WIFE, "Анна", "Жена", "Ваша любимая жена пропала ночью. Во дворе остались огромные следы.", 5, 5));
            Characters.Add(new Character(CHARACTER_ID_BOOZER, "Пьяница", "Житель города", "Он видел, как что-то большое ушло за мост.", 100, 100));
            Characters.Add(new Character(CHARACTER_ID_DOG, "Арбуз", "Пес", "Ваш пес нервно смотрит на север и не отходит от следов.", 3, 3));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Крыса", 4, 4, 6, 4, 4);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Змея", 6, 6, 9, 6, 6);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 70, true));

            Monster giantToad = new Monster(MONSTER_ID_GIANT_TOAD, "Огромная жаба", 9, 10, 18, 14, 14);
            giantToad.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TOAD_FOOT), 80, true));
            giantToad.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TOAD_TONGUE), 30, false));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Паучья матка", 13, 25, 35, 24, 24);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 100, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 60, false));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOLD_RING), 100, false));

            Monsters.Add(rat);
            Monsters.Add(snake);
            Monsters.Add(giantToad);
            Monsters.Add(giantSpider);
        }

        private static void PopulateQuests()
        {
            Quest findWife = new Quest(
                QUEST_ID_FIND_WIFE,
                "Найти Анну",
                "Анна пропала ночью. Следы ведут от дома к городу, а дальше за мост. Найдите ее кольцо и вернитесь во двор.",
                50,
                50);
            findWife.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_GOLD_RING), 1));
            findWife.RewardItem = ItemByID(ITEM_ID_BOW);

            Quest clearAlchemistGarden = new Quest(
                QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                "Очистить сад алхимика",
                "Алхимик просит прогнать крыс из сада и принести 3 крысиных хвоста.",
                18,
                12);
            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));
            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);

            Quest clearFarmersField = new Quest(
                QUEST_ID_CLEAR_FARMERS_FIELD,
                "Очистить поле фермера",
                "Фермер даст пропуск охраны, если вы принесете 3 змеиных клыка с поля.",
                24,
                18);
            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));
            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            Quest getBow = new Quest(
                QUEST_ID_TOWN_SQUARE_GOLDEN_TICKET,
                "Слухи на площади",
                "Городской пьяница обменяет охотничий лук на 2 куска меха. Говорит, за мостом без лука делать нечего.",
                12,
                10);
            getBow.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 2));
            getBow.RewardItem = ItemByID(ITEM_ID_BOW);

            Quests.Add(findWife);
            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
            Quests.Add(getBow);
        }

        private static void PopulateLocations()
        {
            Location home = new Location(LOCATION_ID_HOME, "Дом", "Ваш дом. Здесь можно перевести дух и восстановить здоровье.", "pichome.jpg");
            home.RestoresHitPoints = true;

            Location yard = new Location(LOCATION_ID_YARD, "Двор", "Двор перед вашим домом. На влажной земле видны огромные следы.", "picyard.jpg");
            yard.QuestAvailableHere = QuestByID(QUEST_ID_FIND_WIFE);

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Центр города", "У фонтана шумят жители. Здесь собирают слухи и обмениваются припасами.", "Pictownsquare.jpg");
            townSquare.QuestAvailableHere = QuestByID(QUEST_ID_TOWN_SQUARE_GOLDEN_TICKET);

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Хижина алхимика", "На полках стоят травы, склянки и мешочки с порошками.", "picalchhouse.jfif");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Сад алхимика", "Грядки перерыты, а среди трав слышен писк.", "picrats.jpg");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_RAT);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Ферма", "Фермер нервно смотрит на поле и просит помощи.", "picfarm.jpg");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Поле фермера", "В высокой траве шуршат змеи.", "picsnake.jpg");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_SNAKE);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Пост охраны", "Стражник пропускает за город только тех, у кого есть пропуск.", "picguardpost.jpg", ItemByID(ITEM_ID_ADVENTURER_PASS));

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Мост", "Каменный мост ведет к лесу. Следы становятся глубже.", "picbridge.jpg");
            bridge.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_TOAD);

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Темный лес", "Паутина покрывает деревья. В глубине блестит что-то золотое.", "picforest.jpg");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GIANT_SPIDER);
            spiderField.IsFinalLocation = true;

            Location shop = new Location(LOCATION_ID_SHOP, "Магазин", "Местная лавка. Торговец продает зелья и точит клинки.", "picshop.jpg");

            home.LocationToNorth = yard;

            yard.LocationToNorth = townSquare;
            yard.LocationToSouth = home;
            yard.LocationToEast = shop;

            shop.LocationToWest = yard;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = yard;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            Locations.Add(home);
            Locations.Add(yard);
            Locations.Add(shop);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            return Items.Find(item => item.ID == id);
        }

        public static Monster MonsterByID(int id)
        {
            return Monsters.Find(monster => monster.ID == id);
        }

        public static Quest QuestByID(int id)
        {
            return Quests.Find(quest => quest.ID == id);
        }

        public static Location LocationByID(int id)
        {
            return Locations.Find(location => location.ID == id);
        }
    }
}
