using System.Linq;
using UnityEngine;

namespace Resources.Scripts.Cases
{
    public class ListViewCases : ListView
    {
        [SerializeField] protected float m_offsetX;
        private int _countElementInLineNow = 1;

        public override GameObject Add(GameObject element)
        {
            GameObject createdElement = Instantiate(element, this.m_ContentTransform);

            if (this.m_elements.Count == 0)
            {
                this.m_elements.Add(createdElement);
                _countElementInLineNow = 1;
                return createdElement;
            }

            ListElement elementMeta = createdElement.GetComponent<ListElement>();
            GameObject lastElement = this.m_elements.Last();

            Vector3 lastElementPosition = lastElement.transform.localPosition;
            Vector3 newElementPosition;
            if (_countElementInLineNow < countElementInLine)
            {
                newElementPosition = new Vector3
                {
                    x = lastElementPosition.x + elementMeta.Width() + m_offsetX,
                    y = lastElementPosition.y,
                    z = lastElementPosition.z
                };
                _countElementInLineNow += 1;
            }
            else
            {
                _countElementInLineNow = 1;
                newElementPosition = new Vector3
                {
                    x = startPositionX,
                    y = lastElementPosition.y - elementMeta.Height() - m_offsetY,
                    z = lastElementPosition.z
                };
                float contentHeight = this.m_ContentRectTransform.rect.height;
                contentHeight += this.m_offsetY + elementMeta.Height();
                this.m_ContentRectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, contentHeight);
            }

            createdElement.transform.localPosition = newElementPosition;
            this.m_elements.Add(createdElement);

            return createdElement;
        }
    }
}