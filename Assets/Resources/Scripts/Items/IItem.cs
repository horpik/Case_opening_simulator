using UnityEngine;

namespace Resources.Scripts.Items
{
    public interface IItem
    {
        public float GetPrice();
        public string GetName();
        public Sprite GetImage();
        public void SetState(bool state);
        public bool GetState();
    }
}