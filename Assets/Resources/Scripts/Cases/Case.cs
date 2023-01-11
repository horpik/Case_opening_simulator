using System.Collections.Generic;
using Resources.Scripts.Enums;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts.Cases
{
    public class Case : ICase
    {
        private List<IItem> myItems;
        private Sprite myMainImage;
        private Sprite myBackgroundImage;
        private int myPrice;
        private string myName;
        private TypePrice myTypePrice;
        private Sprite myTypePriceImage;


        public Case(string name, Sprite mainImage, Sprite backgroundImage, Sprite typePriceImage, TypePrice typePrice,
            int price,
            List<IItem> items)
        {
            myName = name;
            myMainImage = mainImage;
            myBackgroundImage = backgroundImage;
            myTypePriceImage = typePriceImage;
            myTypePrice = typePrice;
            myPrice = price;
            myItems = items;
        }

        public TypePrice GetTypePrice() => myTypePrice;
        public Sprite GetTypePriceImage() => myTypePriceImage;
        public string GetName() => myName;
        public Sprite GetMainImage() => myMainImage;
        public Sprite GetBackgroundImage() => myBackgroundImage;
        public int GetPrice() => myPrice;
        public List<IItem> GetItems() => myItems;
    }
}