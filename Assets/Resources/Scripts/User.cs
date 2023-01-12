using System.Collections.Generic;
using Resources.Scripts.Enums;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts
{
    public static class User
    {
        private static int myGem = 1000;
        private static int myMoney = 2000;
        private static List<IItem> items;

        static User()
        {
            items = new List<IItem>()
            {
                new Item(
                    "Гем1",
                    UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                    TypePrice.Gem,
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
            return myMoney;
        }

        public static int GetCountGem()
        {
            return myGem;
        }

        public static void AddMoney(int money)
        {
            myMoney += money;
        }

        public static void AddGem(int gem)
        {
            myGem += gem;
        }
    }
}