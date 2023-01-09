using System;
using Resources.Scripts.Cases;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts
{
    public static class ManagerEvent
    {
        public delegate void ChangeMoney();

        public static event ChangeMoney Change;

        public delegate void ChangeScreen();

        public static void ActivateChangeMoney()
        {
            Change?.Invoke();
        }
    }
}