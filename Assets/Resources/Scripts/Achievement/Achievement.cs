using Resources.Scripts.AllData;
using Resources.Scripts.Enums;
using UnityEngine;

namespace Resources.Scripts.Achievement
{
    public class Achievement : IAchievement
    {
        private string myName;
        private string myDescription;
        private string myRare;

        private bool isAwardReceived;

        private Sprite myMainImage;
        private Sprite myRewardImage;
        private Sprite myStateImage;

        private int myCountReward;
        private TypeCurrency myTypeReward;

        public Achievement(string name, string description, string rare, Sprite mainImage, Sprite rewardImage,
            Sprite stateImage, int countReward, TypeCurrency typeCurrency)
        {
            myName = name;
            myDescription = description;
            myRare = rare;
            myMainImage = mainImage;
            myRewardImage = rewardImage;
            myStateImage = stateImage;
            myCountReward = countReward;
            myTypeReward = typeCurrency;
        }

        public string GetName() => myName;

        public string GetDescription() => myDescription;

        public string GetRare() => myRare;

        public bool GetState() => isAwardReceived;

        public void SetState(bool state) => isAwardReceived = state;

        public int GetCountReward() => myCountReward;

        public Sprite GetMainImage() => myMainImage;

        public Sprite GetStateImage() => myStateImage;

        public Sprite GetRewardImage() => myRewardImage;

        public TypeCurrency GetTypeReward() => myTypeReward;
    }
}