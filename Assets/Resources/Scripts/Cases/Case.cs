using System.Collections.Generic;
using Resources.Scripts.AllData;
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
        private TypeCurrency myTypeCurrency;
        private Sprite myTypePriceImage;


        public Case(string name, Sprite mainImage, Sprite backgroundImage, Sprite typePriceImage, TypeCurrency typeCurrency,
            int price,
            List<IItem> items)
        {
            myName = name;
            myMainImage = mainImage;
            myBackgroundImage = backgroundImage;
            myTypePriceImage = typePriceImage;
            myTypeCurrency = typeCurrency;
            myPrice = price;
            myItems = items;
        }

        public TypeCurrency GetTypePrice() => myTypeCurrency;
        public Sprite GetTypePriceImage() => myTypePriceImage;
        public string GetName() => myName;
        public Sprite GetMainImage() => myMainImage;
        public Sprite GetBackgroundImage() => myBackgroundImage;
        public int GetPrice() => myPrice;
        public List<IItem> GetItems() => myItems;

        public int GetWeight()
        {
            int result = 0;
            foreach (var item in myItems)
            {
                result += item.GetWeight();
            }

            return result;
        }
    }
}