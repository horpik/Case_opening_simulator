using System.Collections.Generic;
using Resources.Scripts.Cases;
using Resources.Scripts.Items;
using Resources.Scripts.Roulette;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts
{
    public class ManagerScreen : MonoBehaviour
    {
        [SerializeField] private Canvas cases;
        [SerializeField] private Canvas inventory;
        [SerializeField] private Canvas openingCases;
        [SerializeField] private Image casesButtonImage;
        [SerializeField] private Image inventoryButtonImage;
        [SerializeField] private TextMeshProUGUI countMoney;
        [SerializeField] private List<Sprite> images;
        [SerializeField] private ManagerOpeningCases managerOpeningCases; 
        [SerializeField] private ManagerItems managerItems; 
        [SerializeField] private ManagerCases managerCases; 
        public void Awake()
        {
            ManagerEvent.Change += ChangeMoney;
            OpenScreenCases();
            countMoney.text = User.GetMoney() + "$";
            casesButtonImage.sprite = images[1];
            inventoryButtonImage.sprite = images[0];
        }

        public void OpenScreenInventory()
        {
            cases.enabled = false;
            openingCases.enabled = false;
            inventory.enabled = true;
            casesButtonImage.sprite = images[0];
            inventoryButtonImage.sprite = images[1];
            managerItems.FieldGeneration();
            managerOpeningCases.ExtraFinishScroll();
        }

        public void OpenScreenCases()
        {
            inventory.enabled = false;
            openingCases.enabled = false;
            cases.enabled = true;
            casesButtonImage.sprite = images[1];
            inventoryButtonImage.sprite = images[0];
            managerOpeningCases.ClosePanelWinItem();
        }

        public void OpenScreenOpeningCases()
        {
            openingCases.enabled = true;
            inventory.enabled = false;
            cases.enabled = false;
            casesButtonImage.sprite = images[0];
            inventoryButtonImage.sprite = images[0];
        }

        private void ChangeMoney()
        {
            countMoney.text = User.GetMoney() + "$";
        }
    }
}