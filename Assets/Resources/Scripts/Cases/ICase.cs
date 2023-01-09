using System.Collections.Generic;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts.Cases
{
    public interface ICase
    {
        public string GetName();
        public Sprite GetImage();
        public float GetPrice();
        public List<IItem> GetItems();
    }
}