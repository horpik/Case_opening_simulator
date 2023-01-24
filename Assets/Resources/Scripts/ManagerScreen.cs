using System.Collections.Generic;
using Resources.Scripts.Achievement;
using Resources.Scripts.Cases;
using Resources.Scripts.Items;
using Resources.Scripts.Roulette;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources.Scripts
{
    public class ManagerScreen : MonoBehaviour
    {
        [Header("Images")] [SerializeField] private Image casesButtonImage;
        [SerializeField] private Image inventoryButtonImage;
        [SerializeField] private List<Sprite> imagesButton;
        [SerializeField] private List<Sprite> imagesBackground;
        [SerializeField] private Image imageBackground;

        [Header("Canvases")] [SerializeField] private Canvas cases;
        [SerializeField] private Canvas inventory;
        [SerializeField] private Canvas openingCases;

        [Header("Currency")] [SerializeField] private TextMeshProUGUI countMoney;
        [SerializeField] private TextMeshProUGUI countGem;

        [Header("Managers")] [SerializeField] private ManagerOpeningCases managerOpeningCases;
        [SerializeField] private ManagerItems managerItems;
        [SerializeField] private ManagerCases managerCases;
        [SerializeField] private ManagerAchievement managerAchievement;

        public void Start()
        {
            ManagerEvent.Change += ChangeMoney;
            ClickOnCases();
            countMoney.text = User.GetCountMoney().ToString();
            countGem.text = User.GetCountGem().ToString();
            casesButtonImage.sprite = imagesButton[1];
            inventoryButtonImage.sprite = imagesButton[0];
            managerCases.GeneratedCases();
        }

        public void ClickOnInventory()
        {
            if (inventory.enabled) return;
            cases.enabled = false;
            openingCases.enabled = false;
            inventory.enabled = true;
            casesButtonImage.sprite = imagesButton[0];
            inventoryButtonImage.sprite = imagesButton[1];
            managerItems.FieldGeneration();
            managerOpeningCases.ExtraFinishScroll();
            managerOpeningCases.ClosePanelWinner();
        }

        public void ClickOnCases()
        {
            if (cases.enabled) return;
            inventory.enabled = false;
            openingCases.enabled = false;
            cases.enabled = true;
            managerItems.OpenOtherScreen();
            casesButtonImage.sprite = imagesButton[1];
            inventoryButtonImage.sprite = imagesButton[0];
            managerOpeningCases.ExtraFinishScroll();
            managerOpeningCases.ClosePanelWinner();
        }

        public void ClickOnOpenCase()
        {
            inventory.enabled = false;
            cases.enabled = false;
            openingCases.enabled = true;
            managerItems.OpenOtherScreen();
            casesButtonImage.sprite = imagesButton[0];
            inventoryButtonImage.sprite = imagesButton[0];
        }

        private void ChangeMoney()
        {
            countMoney.text = User.GetCountMoney().ToString();
            countGem.text = User.GetCountGem().ToString();
        }
    }
}