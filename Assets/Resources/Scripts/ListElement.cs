using System.Collections.Generic;
using Resources.Scripts.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources.Scripts
{
    public class ListElement : MonoBehaviour
    {
        [Header("Components")] [SerializeField]
        private RectTransform myTransform;

        [Space] [SerializeField] private Image myImage;
        [SerializeField] private TextMeshProUGUI myName;
        [SerializeField] private TextMeshProUGUI myPriceText;
        [SerializeField] private Button myActionButton;
        private List<IItem> _myItems;
        private IItem _myItem;
        private float myPrice;
        public void SetTitle(string title) => myName.text = title;
        public void SetImage(Sprite image) => myImage.sprite = image;

        public void SetPrice(float price)
        {
            myPrice = price;
            myPriceText.text = myPrice + "$";
        }

        public void SetList(List<IItem> items) => _myItems = items;

        public float GetPrice() => myPrice;
        public string GetName() => myName.text;
        public Image GetImage() => myImage;

        public float Height() => myTransform.rect.height;
        public float Width() => myTransform.rect.width;


        public Button GetActionButton() => this.myActionButton;
    }
}