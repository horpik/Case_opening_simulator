using System.Collections.Generic;
using Resources.Scripts.Roulette;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts.Cases
{
    public class ManagerCases : MonoBehaviour
    {
        [Header("ListView")] [SerializeField] private ListView listViewCases;

        [Header("Prefabs")] [SerializeField] private GameObject casePrefab;

        [Header("Managers")] [SerializeField] private ManagerOpeningCases managerOpeningCases;
        [SerializeField] private ManagerScreen managerScreen;

        private List<ICase> _listElements;


        private void Start()
        {
            _listElements = CaseData.GetData();
            foreach (var _case in _listElements)
            {
                GameObject element = listViewCases.Add(casePrefab);
                ListElement elementMeta = element.GetComponent<ListElement>();
                elementMeta.SetTitle(_case.GetName());
                elementMeta.SetMainImage(_case.GetMainImage());
                elementMeta.SetBackgroundImage(_case.GetBackgroundImage());
                elementMeta.SetPrice(_case.GetTypePrice(), _case.GetPrice());
                elementMeta.SetPriceImage(_case.GetTypePriceImage());
                Button actionButton = elementMeta.GetActionButton();
                actionButton.onClick.AddListener(() =>
                {
                    Debug.Log("click on button");
                    managerOpeningCases.ClickOnCase(_case.GetName(), _case.GetPrice(), _case.GetTypePrice(),
                        _case.GetItems());
                    managerScreen.OpenScreenOpeningCases();
                });
            }
        }
    }
}