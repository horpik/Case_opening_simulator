using System.Collections.Generic;
using Resources.Scripts.AllData;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts
{
    public static class User
    {
        private static int money = 1000;
        private static List<IItem> items;

        static User()
        {
            items = new List<IItem>()
            {
                new Item(
                    "Гем1",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem_Back"),
                    10,
                    10),
            };
        }

        public static void AddItem(IItem item)
        {
            items.Add(item);
        }

        public static void RemoveItem(IItem item)
        {
            items.Remove(item);
        }

        public static List<IItem> GetItems()
        {
            return items;
        }
        public static int GetCountMoney()
        {
            return money;
        }
        public static void AddMoney(int gem)
        {
            money += gem;
        }
    }
}