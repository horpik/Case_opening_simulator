using System.Collections.Generic;
using Resources.Scripts.AllData;
using UnityEngine;

namespace Resources.Scripts.Cases
{
    public class Case : ICase
    {
        private List<IItem> items;
        private Sprite mainImage;
        private Sprite backgroundImage;
        private int price;
        private string name;


        public Case(string name, Sprite mainImage, Sprite backgroundImage,
            int price,
            List<IItem> items)
        {
            this.name = name;
            this.mainImage = mainImage;
            this.backgroundImage = backgroundImage;
            this.price = price;
            this.items = items;
        }

        public string GetName() => name;
        public Sprite GetMainImage() => mainImage;
        public Sprite GetBackgroundImage() => backgroundImage;
        public int GetPrice() => price;
        public List<IItem> GetItems() => items;

        public int GetWeight()
        {
            int result = 0;
            foreach (var item in items)
            {
                result += item.GetWeight();
            }

            return result;
        }
    }
}