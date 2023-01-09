using System.Collections.Generic;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts
{
    public static class User
    {
        private static float myMoney = 1000f;
        private static List<IItem> items;

        static User()
        {
            items = new List<IItem>()
            {
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

        public static float GetMoney()
        {
            return myMoney;
        }

        public static void AddMoney(float money)
        {
            myMoney += money;
        }
    }
}