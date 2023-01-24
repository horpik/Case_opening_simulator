using System.Collections.Generic;
using Resources.Scripts.AllData;
using UnityEngine;

namespace Resources.Scripts.Achievement
{
    public class ManagerAchievement : MonoBehaviour
    {
        [Header("ListView")] [SerializeField] private ListViewAchievement listViewAchievement;

        [Header("Prefabs")] [SerializeField] private GameObject achievementPrefab;

        // [Header("Managers")] [SerializeField] private ManagerScreen managerScreen;

        private List<IAchievement> _listElements;

        public void GeneratedAchievement()
        {
            _listElements = Data.GetDataAchievements();
            foreach (var achievement in _listElements)
            {
                GameObject element = listViewAchievement.Add(achievementPrefab);
                ListElementAchievement elementMeta = element.GetComponent<ListElementAchievement>();
                elementMeta.SetAchievement(achievement);
                elementMeta.SetMainImage(achievement.GetMainImage());
                elementMeta.SetStateImage(achievement.GetStateImage());
                elementMeta.SetName(achievement.GetName());
                elementMeta.SetDescription(achievement.GetDescription());
                elementMeta.SetRare(achievement.GetRare());
                elementMeta.SetCountReward(achievement.GetCountReward().ToString());
            }
        }
    }
}