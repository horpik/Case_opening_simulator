using System.Collections.Generic;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts.Cases
{
    public static class CaseData
    {
        private static List<ICase> cases;

        static CaseData()
        {
            cases = new List<ICase>()
            {
                new Case(
                    "Обычный\nящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Brawl_Box"),
                    40f,
                    new List<IItem>()
                    {
                        new Item("Гем1", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем2", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем3", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем4", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем5", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем6", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем7", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем8", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем9", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                    }),
                new Case(
                    "Большой\nящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Big_Box"),
                    30f,
                    new List<IItem>()
                    {
                        new Item("Гем1", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем2", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем3", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем4", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем5", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем6", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем7", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем8", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем9", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                    }),
                new Case(
                    "Мегаящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Mega_Box"),
                    10f,
                    new List<IItem>()
                    {
                        new Item("Гем1", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем2", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем3", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем4", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем5", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем6", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем7", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем8", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем9", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                    }),
                new Case(
                    "Омегаящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Omega_Box"),
                    15f,
                    new List<IItem>()
                    {
                        new Item("Гем1", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем2", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем3", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем4", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем5", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем6", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем7", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем8", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                        new Item("Гем9", UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"), 10f),
                    })
            };
        }

        public static List<ICase> GetData()
        {
            return cases;
        }
    }
}