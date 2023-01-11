using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources.Scripts.Roulette
{
    public class WinElement : MonoBehaviour
    {
        [SerializeField] private Image myBackgroundImage;
        [SerializeField] private Image myMainImage;
        [SerializeField] private TextMeshProUGUI myName;

        public void SetTitle(string title) => myName.text = title;
        public void SetMainImage(Sprite image) => myMainImage.sprite = image;
        public void SetBackgroundImage(Sprite image) => myBackgroundImage.sprite = image;
    }
}