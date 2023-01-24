using Resources.Scripts.AllData;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources.Scripts.Achievement
{
    public class ListElementAchievement : ListElement
    {
        [Header("Images")] [SerializeField] private Image stateImage;

        [Header("Texts")] [SerializeField] private TextMeshProUGUI descriptionText;
        [SerializeField] private TextMeshProUGUI rareText;
        [SerializeField] private TextMeshProUGUI countRewardText;

        private IAchievement achievement;
        public void SetAchievement(IAchievement achievement) => this.achievement = achievement;
        public IAchievement GetAchievement() => achievement;
        public void SetStateImage(Sprite image) => stateImage.sprite = image;
        public void SetDescription(string description) => descriptionText.text = description;
        public void SetRare(string rare) => rareText.text = rare;
        public void SetCountReward(string reward) => countRewardText.text = reward;
    }
}