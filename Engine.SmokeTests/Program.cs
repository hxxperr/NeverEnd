using System;
using System.Linq;
using Engine;

namespace Engine.SmokeTests
{
    internal static class Program
    {
        private static void Main()
        {
            Assert(World.Items.GroupBy(item => item.ID).All(group => group.Count() == 1), "Item IDs must be unique.");
            Assert(World.Locations.All(location => !string.IsNullOrWhiteSpace(location.ImageName)), "Every location needs an image.");

            Player player = Player.CreateDefaultPlayer();
            Assert(player.CurrentLocation.ID == World.LOCATION_ID_HOME, "Default player should start at home.");
            Assert(player.HasItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD)), "Default player should have a sword.");
            Assert(player.HasItem(World.ItemByID(World.ITEM_ID_HEALING_POTION)), "Default player should have a potion.");

            Location guardPost = World.LocationByID(World.LOCATION_ID_GUARD_POST);
            Assert(!player.HasRequiredItemToEnterThisLocation(guardPost), "Guard post should require a pass.");

            player.AddItemToInventory(World.ItemByID(World.ITEM_ID_ADVENTURER_PASS));
            Assert(player.HasRequiredItemToEnterThisLocation(guardPost), "Pass should unlock the guard post.");

            Quest finalQuest = World.QuestByID(World.QUEST_ID_FIND_WIFE);
            player.Quests.Add(new PlayerQuest(finalQuest));
            player.AddItemToInventory(World.ItemByID(World.ITEM_ID_GOLD_RING));
            Assert(player.HasAllQuestCompletionItems(finalQuest), "Gold ring should complete the final quest requirements.");

            Console.WriteLine("Engine smoke tests passed.");
        }

        private static void Assert(bool condition, string message)
        {
            if (!condition)
            {
                throw new InvalidOperationException(message);
            }
        }
    }
}
