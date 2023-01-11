using System.Collections.Generic;
using Resources.Scripts.Enums;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts.Cases
{
    public interface ICase
    {
        public string GetName();
        public Sprite GetMainImage();
        public Sprite GetBackgroundImage();
        public int GetPrice();
        public List<IItem> GetItems();
        public TypePrice GetTypePrice();
        public Sprite GetTypePriceImage();
    }
}