using UnityEngine;

namespace Resources.Scripts.AllData
{
    public interface IAchievement
    {
        public string GetName();
        public string GetDescription();
        public string GetRare();

        public bool GetState();
        public void SetState(bool state);

        public int GetCountReward();
        public Sprite GetMainImage();
        
        public Sprite GetStateImage();
    }
}