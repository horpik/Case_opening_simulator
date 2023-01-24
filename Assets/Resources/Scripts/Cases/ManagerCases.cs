using System.Collections.Generic;
using Resources.Scripts.AllData;
using Resources.Scripts.Roulette;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts.Cases
{
    public class ManagerCases : MonoBehaviour
    {
        [Header("ListView")] [SerializeField] private ListViewCases listViewCases;

        [Header("Prefabs")] [SerializeField] private GameObject casePrefab;

        [Header("Managers")] [SerializeField] private ManagerOpeningCases managerOpeningCases;
        [SerializeField] private ManagerScreen managerScreen;

        private List<ICase> _listElements;


        public void GeneratedCases()
        {
            _listElements = Data.GetDataCases();
            foreach (var _case in _listElements)
            {
                GameObject element = listViewCases.Add(casePrefab);
                ListElementCase elementMeta = element.GetComponent<ListElementCase>();
                elementMeta.SetCase(_case);
                elementMeta.SetName(_case.GetName());
                elementMeta.SetMainImage(_case.GetMainImage());
                elementMeta.SetBackgroundImage(_case.GetBackgroundImage());
                elementMeta.SetPrice(_case.GetPrice());
                Button actionButton = elementMeta.GetActionButton();
                actionButton.onClick.AddListener(() =>
                {
                    managerOpeningCases.ClickOnCase(
                        _case.GetName(),
                        _case.GetPrice(),
                        _case.GetItems(),
                        _case.GetWeight());
                    managerScreen.ClickOnOpenCase();
                });
            }
        }
    }
}