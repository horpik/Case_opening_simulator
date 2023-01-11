using Resources.Scripts.Enums;
using UnityEngine;

namespace Resources.Scripts.Items
{
    public class Item : IItem
    {
        private string myName;
        private Sprite myMainImage;
        private Sprite myBackgroundImage;
        private Sprite myImageState;
        private int myPrice;
        private bool canBeSelected = true;
        private TypePrice myTypePrice;
        private Sprite myTypePriceImage;

        public Item(string name, Sprite mainImage, Sprite backgroundImage, Sprite typePriceImage, TypePrice typePrice,
            int price)
        {
            myName = name;
            myMainImage = mainImage;
            myBackgroundImage = backgroundImage;
            myTypePriceImage = typePriceImage;
            myTypePrice = typePrice;
            myPrice = price;
        }

        public TypePrice GetTypePrice() => myTypePrice;
        public int GetPrice() => myPrice;
        public string GetName() => myName;
        public Sprite GetMainImage() => canBeSelected ? myMainImage : myImageState;
        public Sprite GetBackgroundImage() => myBackgroundImage;
        public void SetState(bool state) => canBeSelected = state;
        public bool GetState() => canBeSelected;
        public Sprite GetTypePriceImage() => myTypePriceImage;
    }
}