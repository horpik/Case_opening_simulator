using System.Collections.Generic;
using Resources.Scripts.Cases;
using Resources.Scripts.Enums;
using Resources.Scripts.Items;
using UnityEngine;

namespace Resources.Scripts.AllData
{
    public static class Data
    {
        private static List<ICase> cases;
        private static List<IAchievement> achievements;

        static Data()
        {
            cases = new List<ICase>()
            {
                new Case(
                    "Обычный\nящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Case/Brawl_Box"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Case/Brawl_Box_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gold"),
                    TypeCurrency.Gold,
                    40,
                    new List<IItem>()
                    {
                        new Item(
                            "Гем1",
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            TypeCurrency.Gem,
                            10,
                            1),
                        new Item(
                            "Гем2",
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            TypeCurrency.Gem,
                            10,
                            2),
                        new Item(
                            "Гем3",
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gold"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gold_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gold"),
                            TypeCurrency.Gold,
                            10,
                            10)
                    }),
                new Case(
                    "Большой\nящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Case/Big_Box"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Case/Big_Box_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    TypeCurrency.Gem,
                    50,
                    new List<IItem>()
                    {
                        new Item(
                            "Гем1",
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            TypeCurrency.Gem,
                            10,
                            10)
                    }),
                new Case(
                    "Мегаящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Case/Mega_Box"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Case/Mega_Box_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    TypeCurrency.Gem,
                    60,
                    new List<IItem>()
                    {
                        new Item(
                            "Гем1",
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            TypeCurrency.Gem,
                            10,
                            10)
                    }),
                new Case(
                    "Омегаящик",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Case/Omega_Box"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Case/Omega_Box_Back"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    TypeCurrency.Gem,
                    80,
                    new List<IItem>()
                    {
                        new Item(
                            "Гем1",
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem_Back"),
                            UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                            TypeCurrency.Gem,
                            10,
                            10)
                    }),
            };
            achievements = new List<IAchievement>()
            {
                new Achievement.Achievement(
                    "Name achievement",
                    "description",
                    "rare",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Achievement/Reward"),
                    10,
                    TypeCurrency.Gem
                ),new Achievement.Achievement(
                    "Name achievement",
                    "description",
                    "rare",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gold"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Achievement/Reward"),
                    100,
                    TypeCurrency.Gold
                ),new Achievement.Achievement(
                    "Name achievement",
                    "description",
                    "rare",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Achievement/Reward"),
                    101232,
                    TypeCurrency.Gem
                ),new Achievement.Achievement(
                    "Name achievement",
                    "description",
                    "rare",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Achievement/Reward"),
                    101,
                    TypeCurrency.Gem
                ),new Achievement.Achievement(
                    "Name achievement",
                    "description",
                    "rare",
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Item/Gem"),
                    UnityEngine.Resources.Load<Sprite>("Sprites/Achievement/Reward"),
                    10,
                    TypeCurrency.Gem
                ),
            };
        }

        public static List<ICase> GetDataCases()
        {
            return cases;
        }

        public static List<IAchievement> GetDataAchievements()
        {
            return achievements;
        }
    }
}