using UnityEngine;

namespace Resources.Scripts.Items
{
    public class Item : IItem
    {
        private string myName;
        private Sprite myImage;
        private Sprite myImageState;
        private float myPrice;
        private bool canBeSelected = true;
        public Item(string name, Sprite image, float price)
        {
            myName = name;
            myImage = image;
            myPrice = price;
        }

        public float GetPrice()
        {
            return myPrice;
        }

        public string GetName()
        {
            return myName;
        }

        public Sprite GetImage()
        {
            return canBeSelected ? myImage : myImageState;
        }
        public void SetState(bool state)
        {
            canBeSelected = state;
        }
        public bool GetState()
        {
            return canBeSelected;
        }
    }
}