using Resources.Scripts.AllData;
using Resources.Scripts.Enums;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts.Achievement
{
    public class ListElementAchievement : ListElement
    {
        [Header("Images")] [SerializeField] private Image myStateImage;
        [SerializeField] private Image Reward;

        [Header("Texts")] [SerializeField] private TextMeshProUGUI myDescriptionText;
        [SerializeField] private TextMeshProUGUI myRareText;
        [SerializeField] private TextMeshProUGUI myCountRewardText;

        private IAchievement myAchievement;
        public void SetAchievement(IAchievement achievement) => myAchievement = achievement;
        public IAchievement GetAchievement() => myAchievement;
        public void SetStateImage(Sprite image) => myStateImage.sprite = image;
        public void SetRewardImage(Sprite image) => Reward.sprite = image;
        public void SetDescription(string description) => myDescriptionText.text = description;
        public void SetRare(string rare) => myRareText.text = rare;
        public void SetCountReward(string reward) => myCountRewardText.text = reward;
    }
}