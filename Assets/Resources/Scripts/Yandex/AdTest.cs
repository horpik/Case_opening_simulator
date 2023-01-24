/*using System;
using UnityEngine;

namespace Resources.Scripts.Yandex
{
    public class AdTest : MonoBehaviour
    {
        [SerializeField] private string reward;

        private void OnEnable()
        {
            YandexSDK.YaSDK.onRewardedAdReward += UserGotReward;
        }

        private void OnDisable()
        {
            YandexSDK.YaSDK.onRewardedAdReward -= UserGotReward;
        }

        public void ShowRewarded()
        {
            YandexSDK.YaSDK.instance.ShowRewarded(reward);
        }

        public void ShowInterstitial()
        {
            YandexSDK.YaSDK.instance.ShowInterstitial();
        }

        public void UserGotReward(string reward)
        {
            if (this.reward == reward)
            {
                // Награда
            }
        }
    }
}*/