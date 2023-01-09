using System.Collections.Generic;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts.Cases
{
    public class Case : ICase
    {
        private List<IItem> myItems;
        private Sprite myImage;
        private float myPrice;
        private string myName;

        public Case(string name, Sprite image, float price, List<IItem> items)
        {
            myName = name;
            myImage = image;
            myPrice = price;
            myItems = items;
        }

        public string GetName()
        {
            return myName;
        }

        public Sprite GetImage()
        {
            return myImage;
        }

        public float GetPrice()
        {
            return myPrice;
        }

        public List<IItem> GetItems()
        {
            return myItems;
        }
    }
}