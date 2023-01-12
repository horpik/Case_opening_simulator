using System.Collections.Generic;
using Resources.Scripts.Enums;
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

        [Header("Images")] [SerializeField] private Image myMainImage;
        [SerializeField] private Image myPriceImage;
        [SerializeField] private Image myBackgroundImage;

        [Header("Texts")] [SerializeField] private TextMeshProUGUI myName;
        [SerializeField] private TextMeshProUGUI myPriceText;

        [Header("Button")] [SerializeField] private Button myActionButton;

        private IItem _myItem;
        private int myPrice;
        private int myWeight;
        private TypePrice myTypePrice;
        public void SetTitle(string title) => myName.text = title;
        public void SetMainImage(Sprite image) => myMainImage.sprite = image;
        public void SetBackgroundImage(Sprite image) => myBackgroundImage.sprite = image;
        public void SetPriceImage(Sprite image) => myPriceImage.sprite = image;
        public void SetWeight(int weight) => myWeight = weight;

        public void SetPrice(TypePrice typePrice, int price)
        {
            myPrice = price;
            myTypePrice = typePrice;
            myPriceText.text = myPrice.ToString();
        }

        public TypePrice GetTypePrice() => myTypePrice;
        public int GetPrice() => myPrice;
        public int GetWeight() => myWeight;
        public Image GetTypePriceImage() => myPriceImage;
        public string GetName() => myName.text;
        public Image GetMainImage() => myMainImage;
        public Image GetPriceImage() => myMainImage;
        public Image GetBackgroundImage() => myBackgroundImage;
        public float Height() => myTransform.rect.height;
        public float Width() => myTransform.rect.width;
        public Button GetActionButton() => this.myActionButton;
    }
}