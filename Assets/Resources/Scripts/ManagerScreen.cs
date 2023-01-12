using System.Collections.Generic;
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

        public void Awake()
        {
            ManagerEvent.Change += ChangeMoney;
            OpenScreenCases();
            countMoney.text = User.GetCountMoney().ToString();
            countGem.text = User.GetCountGem().ToString();
            casesButtonImage.sprite = imagesButton[1];
            inventoryButtonImage.sprite = imagesButton[0];
        }

        public void OpenScreenInventory()
        {
            if (inventory.enabled) return;
            cases.enabled = false;
            openingCases.enabled = false;
            inventory.enabled = true;
            casesButtonImage.sprite = imagesButton[0];
            inventoryButtonImage.sprite = imagesButton[1];
            managerItems.FieldGeneration();
            managerOpeningCases.ExtraFinishScroll();
            imageBackground.sprite = imagesBackground[1];
        }

        public void OpenScreenCases()
        {
            if (cases.enabled) return;
            managerItems.OpenOtherScreen();
            inventory.enabled = false;
            openingCases.enabled = false;
            cases.enabled = true;
            casesButtonImage.sprite = imagesButton[1];
            inventoryButtonImage.sprite = imagesButton[0];
            managerOpeningCases.ExtraFinishScroll();
            imageBackground.sprite = imagesBackground[0];
        }

        public void OpenScreenOpeningCases()
        {
            openingCases.enabled = true;
            managerItems.OpenOtherScreen();
            inventory.enabled = false;
            cases.enabled = false;
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