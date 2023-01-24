using System.Collections.Generic;
using UnityEngine;

namespace Resources.Scripts.AllData
{
    public interface ICase
    {
        public string GetName();
        public Sprite GetMainImage();
        public Sprite GetBackgroundImage();
        public int GetPrice();
        public List<IItem> GetItems();
        public int GetWeight();
    }
}