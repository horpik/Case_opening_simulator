using Resources.Scripts.AllData;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts.Items
{
    public class ListElementItem : ListElement
    {
        [SerializeField] private Button myActionButton;
        [SerializeField] private TextMeshProUGUI myPriceText;
        private IItem myItem;
        public void SetItem(IItem _item) => myItem = _item;

        public void SetPrice(int price)
        {
            myPriceText.text = price.ToString();
        }

        public IItem GetItem() => myItem;
        public Button GetActionButton() => this.myActionButton;
    }
}