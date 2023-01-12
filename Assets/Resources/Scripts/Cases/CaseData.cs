using System.Collections.Generic;
using Resources.Scripts.Enums;
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
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Brawl_Box_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gold"),
                    TypePrice.Gold,
                    40,
                    new List<IItem>()
                    {
                        new Item(
                            "Гем1",
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            TypePrice.Gem,
                            10,
                            1),
                        new Item(
                            "Гем2",
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            TypePrice.Gem,
                            10,
                            2),
                        new Item(
                            "Гем3",
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gold"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gold_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gold"),
                            TypePrice.Gold,
                            10,
                            10)
                    }),
                new Case(
                    "Большой\nящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Big_Box"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Big_Box_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                    TypePrice.Gem,
                    50,
                    new List<IItem>()
                    {
                        new Item(
                            "Гем1",
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            TypePrice.Gem,
                            10,
                            10)
                    }),
                new Case(
                    "Мегаящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Mega_Box"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Mega_Box_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                    TypePrice.Gem,
                    60,
                    new List<IItem>()
                    {
                        new Item(
                            "Гем1",
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            TypePrice.Gem,
                            10,
                            10)
                    }),
                new Case(
                    "Омегаящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Omega_Box"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/CaseImg/Omega_Box_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                    TypePrice.Gem,
                    80,
                    new List<IItem>()
                    {
                        new Item(
                            "Гем1",
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/ItemImg/Gem"),
                            TypePrice.Gem,
                            10,
                            10)
                    }),
            };
        }

        public static List<ICase> GetData()
        {
            return cases;
        }
    }
}