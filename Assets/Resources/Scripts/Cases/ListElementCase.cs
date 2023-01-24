using Resources.Scripts.AllData;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources.Scripts.Cases
{
    public class ListElementCase : ListElement
    {
        [Header("Button")] [SerializeField] private Button actionButton;
        [SerializeField] private TextMeshProUGUI priceText;
        private ICase _case;
        public void SetCase(ICase _case) => this._case = _case;

        public void SetPrice(int price)
        {
            priceText.text = price.ToString();
        }

        public ICase GetCase() => _case;
        public Button GetActionButton() => this.actionButton;
    }
}