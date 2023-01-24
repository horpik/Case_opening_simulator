using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources.Scripts
{
    public abstract class ListElement : MonoBehaviour
    {
        [Header("Components")] [SerializeField]
        private RectTransform transform;

        [Header("Images")] [SerializeField] private Image mainImage;
        [SerializeField] private Image backgroundImage;

        [Header("Texts")] [SerializeField] private TextMeshProUGUI name;


        // private int myPrice;
        //
        // private TypeCurrency myTypeCurrency;
        public void SetName(string title) => name.text = title;
        public void SetMainImage(Sprite image) => mainImage.sprite = image;
        public void SetBackgroundImage(Sprite image) => backgroundImage.sprite = image;
        public float Height() => transform.rect.height;

        public float Width() => transform.rect.width;
        // public TypeCurrency GetTypePrice() => myTypeCurrency;
        // public int GetPrice() => myPrice;
        // public string GetName() => name.text;
        // public Image GetMainImage() => mainImage;
        // public Image GetBackgroundImage() => backgroundImage;
    }
}