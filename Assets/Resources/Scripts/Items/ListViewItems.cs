﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Resources.Scripts.Items
{
    public class ListViewItems : ListView
    {
        [SerializeField] protected float m_offsetX;
        private float defaultSizeContent;
        private int _countElementInLineNow = 1;

        private void Start()
        {
            defaultSizeContent = m_ContentRectTransform.rect.height;
        }

        public void SetDefaultSizeContent()
        {
            m_ContentRectTransform.sizeDelta = new Vector2(0, defaultSizeContent);
        }

        public void DestroyObjects()
        {
            foreach (var _object in m_elements)
            {
                Destroy(_object);
            }

            m_elements = new List<GameObject>();
        }

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