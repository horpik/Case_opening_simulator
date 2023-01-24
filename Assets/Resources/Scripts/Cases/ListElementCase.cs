using Resources.Scripts.AllData;
using Resources.Scripts.Enums;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts.Cases
{
    public class ListElementCase : ListElement
    {
        [Header("Images")] [SerializeField] private Image myPriceImage;
        [Header("Button")] [SerializeField] private Button myActionButton;
        [SerializeField] private TextMeshProUGUI myPriceText;
        private IItem _myItem;
        private ICase myCase;
        public void SetCase(ICase _case) => myCase = _case;

        public void SetPrice(int price)
        {
            myPriceText.text = price.ToString();
        }

        public ICase GetCase() => myCase;
        public Button GetActionButton() => this.myActionButton;
        public void SetPriceImage(Sprite image) => myPriceImage.sprite = image;
        public Image GetTypePriceImage() => myPriceImage;
    }
}