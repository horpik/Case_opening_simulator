using Resources.Scripts.AllData;
using UnityEngine;

namespace Resources.Scripts.Achievement
{
    public class Achievement : IAchievement
    {
        private string name;
        private string description;
        private string rare;

        private bool isAwardReceived;

        private Sprite mainImage;
        private Sprite stateImage;

        private int countReward;

        public Achievement(string name, string description, string rare, Sprite mainImage,
            Sprite stateImage, int countReward)
        {
            this.name = name;
            this.description = description;
            this.rare = rare;
            this.mainImage = mainImage;
            this.stateImage = stateImage;
            this.countReward = countReward;
        }

        public string GetName() => name;

        public string GetDescription() => description;

        public string GetRare() => rare;

        public bool GetState() => isAwardReceived;

        public void SetState(bool state) => isAwardReceived = state;

        public int GetCountReward() => countReward;

        public Sprite GetMainImage() => mainImage;

        public Sprite GetStateImage() => stateImage;

    }
}