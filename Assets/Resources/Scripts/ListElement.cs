using Resources.Scripts.AllData;
using Resources.Scripts.Enums;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts
{
    public abstract class ListElement : MonoBehaviour
    {
        [Header("Components")] [SerializeField]
        private RectTransform myTransform;

        [Header("Images")] [SerializeField] private Image myMainImage;
        [SerializeField] private Image myBackgroundImage;

        [Header("Texts")] [SerializeField] private TextMeshProUGUI myName;
        

        // private int myPrice;
        //
        // private TypeCurrency myTypeCurrency;
        public void SetName(string title) => myName.text = title;
        public void SetMainImage(Sprite image) => myMainImage.sprite = image;
        public void SetBackgroundImage(Sprite image) => myBackgroundImage.sprite = image;
        public float Height() => myTransform.rect.height;

        public float Width() => myTransform.rect.width;
        // public TypeCurrency GetTypePrice() => myTypeCurrency;
        // public int GetPrice() => myPrice;
        // public string GetName() => myName.text;
        // public Image GetMainImage() => myMainImage;
        // public Image GetBackgroundImage() => myBackgroundImage;
    }
}