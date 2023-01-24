using Resources.Scripts.Enums;
using UnityEngine;

namespace Resources.Scripts.AllData
{
    public interface IItem
    {
        public int GetPrice();
        public string GetName();
        public Sprite GetMainImage();
        public Sprite GetBackgroundImage();
        public void SetState(bool state);
        public bool GetState();
        public int GetWeight();
        public TypeCurrency GetTypePrice();
        public Sprite GetTypePriceImage();
    }
}