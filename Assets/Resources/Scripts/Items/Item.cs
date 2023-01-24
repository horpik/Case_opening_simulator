using Resources.Scripts.AllData;
using Resources.Scripts.Enums;
using UnityEngine;

namespace Resources.Scripts.Items
{
    public class Item : IItem
    {
        private string myName;
        private Sprite myMainImage;

        private Sprite myBackgroundImage;

        // TODO лишнее поле?
        private Sprite myImageState;

        private int myPrice;
        private bool canBeSelected = true;
        private TypeCurrency myTypeCurrency;
        private Sprite myTypePriceImage;
        private int myWeight;

        public Item(string name, Sprite mainImage, Sprite backgroundImage, Sprite typePriceImage,
            TypeCurrency typeCurrency,
            int price, int weight)
        {
            myName = name;
            myMainImage = mainImage;
            myBackgroundImage = backgroundImage;
            myTypePriceImage = typePriceImage;
            myTypeCurrency = typeCurrency;
            myPrice = price;
            myWeight = weight;
        }

        public int GetWeight() => myWeight;

        public TypeCurrency GetTypePrice() => myTypeCurrency;
        public int GetPrice() => myPrice;
        public string GetName() => myName;
        public Sprite GetMainImage() => canBeSelected ? myMainImage : myImageState;
        public Sprite GetBackgroundImage() => myBackgroundImage;
        public void SetState(bool state) => canBeSelected = state;
        public bool GetState() => canBeSelected;
        public Sprite GetTypePriceImage() => myTypePriceImage;
    }
}