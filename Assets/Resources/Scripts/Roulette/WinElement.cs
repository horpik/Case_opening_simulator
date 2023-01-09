using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Resources.Scripts.Roulette
{
    public class WinElement : MonoBehaviour
    {
        [SerializeField] private Image myImage;
        [SerializeField] private TextMeshProUGUI myName;

        public void SetTitle(string title) => myName.text = title;
        public void SetImage(Sprite image) => myImage.sprite = image;
    }
}