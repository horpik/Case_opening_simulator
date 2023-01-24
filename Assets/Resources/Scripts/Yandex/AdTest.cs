using System;
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
        public void UserGotReward(string reward)
        {
            
        }
    }
}
