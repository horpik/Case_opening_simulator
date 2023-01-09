using System.Collections.Generic;
using System.Linq;
using Resources.Scripts.Items;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace Resources.Scripts.Roulette
{
    public class ManagerOpeningCases : MonoBehaviour
    {
        [SerializeField] private GameObject itemPrefab;
        [SerializeField] private GameObject mainPanel;
        [SerializeField] private TextMeshProUGUI nameCase;
        [SerializeField] private TextMeshProUGUI startScrollButtonText;
        [SerializeField] private GameObject winnerPanel;
        [SerializeField] private WinElement winnerItemPrefab;
        [SerializeField] private Button startScrollButton;
        [SerializeField] private float scrollSpeed;
        [SerializeField] private float startPositionPanelLeft;

        private Image startScrollButtonImage;
        private RectTransform m_RectTransformPanel;
        private List<GameObject> listPrefabs;
        private List<IItem> items;
        private float speed;
        private bool canScroll;
        private float widthPrefab;
        private float priceCase;

        private void Awake()
        {
            startScrollButtonImage = startScrollButton.GetComponent<Image>();
            widthPrefab = itemPrefab.GetComponent<ListElement>().Width();
            m_RectTransformPanel = mainPanel.GetComponent<RectTransform>();
            listPrefabs = new List<GameObject>();
        }

        private void FixedUpdate()
        {
            if (!canScroll) return;
            speed = Mathf.MoveTowards(speed, 0, Random.Range(190, 250) * Time.deltaTime);
            m_RectTransformPanel.offsetMin -= new Vector2(speed, 0) * Time.deltaTime;
            if (speed <= 0)
            {
                canScroll = false;
                ShowPanelWinItem(listPrefabs[GetWinIndex()]);
            }
        }

        private int GetWinIndex()
        {
            var finishPositionPanelLeft = m_RectTransformPanel.offsetMin.x;
            var rangeScrollLine = (finishPositionPanelLeft - startPositionPanelLeft) * (-1);
            var result = (int)((rangeScrollLine + 3 * widthPrefab) / widthPrefab);
            return result;
        }

        private void ShowPanelWinItem(GameObject winItem)
        {
            winnerPanel.SetActive(true);
            var winElement = winItem.GetComponent<ListElement>();
            winnerItemPrefab.SetTitle(winElement.GetName());
            winnerItemPrefab.SetImage(winElement.GetImage().sprite);
            var item = new Item(winElement.GetName(), winElement.GetImage().sprite, winElement.GetPrice());
            User.AddItem(item);
        }

        public void ClosePanelWinItem()
        {
            canScroll = false;
            winnerPanel.SetActive(false);
            GenerateRandomItem();
            startScrollButton.enabled = !(User.GetMoney() < priceCase);
        }

        public void ExtraFinishScroll()
        {
            canScroll = false;
        }
        private void GenerateScrollLine()
        {
            if (listPrefabs.Count != 0) return;

            for (var i = 0; i < 50; i++)
            {
                var instantiate = Instantiate(itemPrefab, mainPanel.transform);
                listPrefabs.Add(instantiate);
            }
        }

        private void GenerateRandomItem()
        {
            speed = scrollSpeed;
            m_RectTransformPanel.offsetMin = new Vector2(startPositionPanelLeft, 20);
            foreach (var elementMeta in listPrefabs.Select(prefab => prefab.GetComponent<ListElement>()))
            {
                elementMeta.SetImage(items[Random.Range(0, items.Count)].GetImage());
                elementMeta.SetTitle(items[Random.Range(0, items.Count)].GetName());
                elementMeta.SetPrice(items[Random.Range(0, items.Count)].GetPrice());
            }
        }

        public void ClickOnCase(string nameCase, float priceCase, List<IItem> items)
        {
            this.priceCase = priceCase;
            this.nameCase.text = nameCase;
            startScrollButtonText.text = "Открыть ($" + this.priceCase + ")";
            this.items = items;
            startScrollButton.enabled = !(User.GetMoney() < priceCase);
            // listPrefabs = new List<GameObject>();

            GenerateScrollLine();
            GenerateRandomItem();
        }

        public void ClearPrefabs()
        {
            if (listPrefabs == null || listPrefabs.Count == 0) return;

            foreach (var prefab in listPrefabs)
            {
                Destroy(prefab);
            }

            listPrefabs.Clear();
        }

        public void StartScroll()
        {
            if (!canScroll)
            {
                canScroll = true;
                startScrollButton.enabled = false;
                User.AddMoney(-priceCase);
                ManagerEvent.ActivateChangeMoney();
            }
        }
    }
}