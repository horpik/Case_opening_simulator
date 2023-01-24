using System.Collections.Generic;
using System.Linq;
using Resources.Scripts.AllData;
using Resources.Scripts.Enums;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts.Items
{
    public class ManagerItems : MonoBehaviour
    {
        [Header("ListView")] [SerializeField] private ListViewItems listViewItems;

        [Header("Prefabs")] [SerializeField] private GameObject itemPrefab;

        [Header("Texts")] [SerializeField] private TextMeshProUGUI countItems;
        [SerializeField] private TextMeshProUGUI countSellGem;
        [SerializeField] private TextMeshProUGUI countSellMoney;
        private List<IItem> _listElements;

        private static int sumSelectedItemsGem;
        private static int sumSelectedItemsMoney;

        private void Start()
        {
            _listElements = new List<IItem>();
            sumSelectedItemsGem = 0;
            sumSelectedItemsMoney = 0;
        }

        public void FieldGeneration()
        {
            DeleteItems();
            listViewItems.SetDefaultSizeContent();
            _listElements = User.GetItems();
            countItems.text = "Предметов: " + _listElements.Count;
            countSellGem.text = sumSelectedItemsGem.ToString();
            countSellMoney.text = sumSelectedItemsMoney.ToString();
            foreach (var item in _listElements)
            {
                GameObject element = listViewItems.Add(itemPrefab);
                ListElementItem elementMeta = element.GetComponent<ListElementItem>();
                elementMeta.SetItem(item);
                elementMeta.SetName(item.GetName());
                elementMeta.SetMainImage(item.GetMainImage());
                elementMeta.SetBackgroundImage(item.GetBackgroundImage());
                elementMeta.SetPrice(item.GetPrice());
                Button actionButton = elementMeta.GetActionButton();
                actionButton.onClick.AddListener(() =>
                {
                    if (item.GetState())
                    {
                        item.SetState(false);
                        actionButton.image.color = new Color(178f, 184f, 195f, 0.2f);
                        if (item.GetTypePrice() == TypeCurrency.Gem)
                        {
                            sumSelectedItemsGem += item.GetPrice();
                        }
                        else
                        {
                            sumSelectedItemsMoney += item.GetPrice();
                        }
                    }
                    else
                    {
                        item.SetState(true);
                        actionButton.image.color = new Color(178f, 184f, 195f, 0f);
                        if (item.GetTypePrice() == TypeCurrency.Gem)
                        {
                            sumSelectedItemsGem -= item.GetPrice();
                        }
                        else
                        {
                            sumSelectedItemsMoney -= item.GetPrice();
                        }
                    }

                    countSellGem.text = sumSelectedItemsGem.ToString();
                    countSellMoney.text = sumSelectedItemsMoney.ToString();
                });
            }
        }

        public void OpenOtherScreen()
        {
            foreach (var item in _listElements)
            {
                item.SetState(true);
            }

            sumSelectedItemsGem = 0;
            sumSelectedItemsMoney = 0;
        }

        private void DeleteItems()
        {
            _listElements = new List<IItem>(User.GetItems());
            foreach (var item in _listElements.Where(item => !item.GetState()))
            {
                User.RemoveItem(item);
            }

            _listElements.Clear();
            listViewItems.DestroyObjects();
        }

        public void SellItemsButton()
        {
            User.AddMoney(sumSelectedItemsMoney);
            User.AddGem(sumSelectedItemsGem);
            ManagerEvent.ActivateChangeMoney();
            sumSelectedItemsGem = 0;
            sumSelectedItemsMoney = 0;
            FieldGeneration();
        }
    }
}