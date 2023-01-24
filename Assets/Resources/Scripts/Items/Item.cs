using Resources.Scripts.AllData;
using UnityEngine;

namespace Resources.Scripts.Items
{
    public class Item : IItem
    {
        private string name;

        private Sprite mainImage;
        private Sprite backgroundImage;

        // TODO лишнее поле?
        private Sprite myImageState;

        private int myPrice;
        private bool canBeSelected = true;
        private int myWeight;

        public Item(string name, Sprite mainImage, Sprite backgroundImage, int price, int weight)
        {
            this.name = name;
            this.mainImage = mainImage;
            this.backgroundImage = backgroundImage;
            myPrice = price;
            myWeight = weight;
        }

        public int GetWeight() => myWeight;
        public int GetPrice() => myPrice;
        public string GetName() => name;
        public Sprite GetMainImage() => canBeSelected ? mainImage : myImageState;
        public Sprite GetBackgroundImage() => backgroundImage;
        public void SetState(bool state) => canBeSelected = state;
        public bool GetState() => canBeSelected;
    }
}