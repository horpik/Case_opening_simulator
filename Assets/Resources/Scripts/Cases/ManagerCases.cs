using System.Collections.Generic;
using Resources.Scripts.Roulette;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources.Scripts.Cases
{
    public class ManagerCases : MonoBehaviour
    {
        [Header("Components")] [SerializeField]
        private ListView listViewCases;

        [SerializeField] private GameObject casePrefab;
        [SerializeField] private ManagerOpeningCases managerOpeningCases;
        [SerializeField] private ManagerScreen managerScreen;
        private List<ICase> _listElements;


        private void Awake()
        {
            _listElements = CaseData.GetData();
            foreach (var _case in _listElements)
            {
                GameObject element = listViewCases.Add(casePrefab);
                ListElement elementMeta = element.GetComponent<ListElement>();
                elementMeta.SetTitle(_case.GetName());
                elementMeta.SetImage(_case.GetImage());
                elementMeta.SetList(_case.GetItems());
                elementMeta.SetPrice(_case.GetPrice());
                Button actionButton = elementMeta.GetActionButton();
                actionButton.onClick.AddListener(() =>
                {
                    managerOpeningCases.ClickOnCase(_case.GetName(), _case.GetPrice(), _case.GetItems());
                    managerScreen.OpenScreenOpeningCases();
                });
            }
        }
    }
}