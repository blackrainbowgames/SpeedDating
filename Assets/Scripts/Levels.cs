﻿using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public partial class GameData
    {
        public static List<Level> Levels = new List<Level>
        {
            #region Level#0 Easy
            
            new Level
            {
                MaleHobbies = new List<List<Hobby>>(),
                FemaleHobbies = new List<List<Hobby>>()
            },

            #endregion

            #region Level#1 Easy

            new Level
            {
                TableNumber = 2,
                Time = 60,
                Target = 6,
                TablePositions = new List<Vector2>
                {
                    new Vector2(-280, -40), new Vector2(280, -40)
                },
                TableScale = 1,
                MaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Animals, Hobby.Pictures, Hobby.Football, Hobby.Cars },
                    new List<Hobby> { Hobby.Books, Hobby.Food, Hobby.Games, Hobby.Drink },
                },
                FemaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Animals, Hobby.Pictures, Hobby.Football, Hobby.Books },
                    new List<Hobby> { Hobby.Books, Hobby.Food, Hobby.Games, Hobby.Pictures },
                }
            },
            
            #endregion

            #region Level#2 Easy

            new Level
            {
                TableNumber = 3,
                Time = 60,
                Target = 7,
                TablePositions = new List<Vector2>
                {
                    new Vector2(-400, 40), new Vector2(400, 40), new Vector2(0, -120)
                },
                TableScale = 1,
                MaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Games, Hobby.Work, Hobby.Football, Hobby.Books },
                    new List<Hobby> { Hobby.Flowers, Hobby.Football, Hobby.Drink, Hobby.Food },
                    new List<Hobby> { Hobby.Money, Hobby.Cars, Hobby.Animals, Hobby.Photo }
                },
                FemaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Games, Hobby.Work, Hobby.Football, Hobby.Cars },
                    new List<Hobby> { Hobby.Flowers, Hobby.Football, Hobby.Sex, Hobby.Photo },
                    new List<Hobby> { Hobby.Money, Hobby.Cars, Hobby.Games, Hobby.Football },
                }
            },
            
            #endregion

            #region Level#3 Easy

            new Level
            {
                TableNumber = 4,
                Time = 60,
                Target = 9,
                TablePositions = new List<Vector2>
                {
                    new Vector2(-240, 80), new Vector2(240, 80), new Vector2(-440, -240), new Vector2(440, -240)
                },
                MaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Animals, Hobby.Cars, Hobby.Food, Hobby.Pictures, Hobby.Archery, Hobby.Work, Hobby.Bicycle, Hobby.Beauty },
                    new List<Hobby> { Hobby.Fishing, Hobby.Archery, Hobby.Fashion, Hobby.Running },
                    new List<Hobby> { Hobby.Singing, Hobby.TV, Hobby.Sex },
                    new List<Hobby> { Hobby.Beauty, Hobby.Flowers, Hobby.Archery, Hobby.Books, Hobby.Music }
                },
                FemaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Work, Hobby.Food, Hobby.Beauty, Hobby.Sex, Hobby.Fashion, Hobby.Football },
                    new List<Hobby> { Hobby.Games, Hobby.Running, Hobby.Pictures, Hobby.Dancing, Hobby.Animals, Hobby.Bicycle, Hobby.Flowers },
                    new List<Hobby> { Hobby.Money, Hobby.TV, Hobby.Sex },
                    new List<Hobby> { Hobby.Jewelry, Hobby.Fishing, Hobby.Running, Hobby.Archery, Hobby.Singing, Hobby.Photo, Hobby.Drink, Hobby.Music }
                }
            },
            
            #endregion

            #region Level#4 Easy

            new Level
            {
                TableNumber = 4,
                Time = 60,
                Target = 10,
                TablePositions = new List<Vector2>
                {
                    new Vector2(-240, 80), new Vector2(240, 80), new Vector2(-440, -240), new Vector2(440, -240)
                },
                MaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Games, Hobby.Cars, Hobby.Dancing, Hobby.Photo },
                    new List<Hobby> { Hobby.TV, Hobby.Football, Hobby.Music, Hobby.Sex },
                    new List<Hobby> { Hobby.Flowers, Hobby.Animals, Hobby.Dancing },
                    new List<Hobby> { Hobby.Books, Hobby.Pictures, Hobby.Archery },
                },
                FemaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Games, Hobby.Cars, Hobby.Dancing },
                    new List<Hobby> { Hobby.TV, Hobby.Football, Hobby.Music, Hobby.Photo },
                    new List<Hobby> { Hobby.Flowers, Hobby.Animals, Hobby.Bicycle, Hobby.Jewelry },
                    new List<Hobby> { Hobby.Books, Hobby.Pictures, Hobby.Sex, Hobby.Dancing },
                }
            },
            
            #endregion

            #region Level#5 Medium

            new Level
            {
                TableNumber = 5,
                Time = 60,
                Target = 8,
                TablePositions = new List<Vector2>
                {
                    new Vector2(-280, 80), new Vector2(280, 80), new Vector2(0, -120), new Vector2(-440, -260), new Vector2(440, -260)
                },
                MaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Dancing, Hobby.Archery, Hobby.Bicycle, Hobby.Sex, Hobby.Money },
                    new List<Hobby> { Hobby.Sex, Hobby.Animals, Hobby.TV, Hobby.Flowers, Hobby.Beauty, Hobby.Music, Hobby.Fishing, Hobby.Money },
                    new List<Hobby> { Hobby.Running, Hobby.Drink, Hobby.Football, Hobby.Games, Hobby.TV, Hobby.Dancing, Hobby.Music, Hobby.Beauty },
                    new List<Hobby> { Hobby.Books, Hobby.TV, Hobby.Money, Hobby.Fishing, Hobby.Sex, Hobby.Music },
                    new List<Hobby> { Hobby.Drink, Hobby.Flowers, Hobby.Running, Hobby.Animals },
                },
                FemaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Football, Hobby.Photo, Hobby.Singing, Hobby.Flowers, Hobby.Bicycle, Hobby.Animals },
                    new List<Hobby> { Hobby.Dancing, Hobby.Cars, Hobby.Pictures },
                    new List<Hobby> { Hobby.Cars, Hobby.Food, Hobby.Fishing },
                    new List<Hobby> { Hobby.Singing, Hobby.Photo, Hobby.Books, Hobby.Beauty, Hobby.Work },
                    new List<Hobby> { Hobby.Archery, Hobby.Flowers, Hobby.Games, Hobby.TV, Hobby.Sex, Hobby.Jewelry, Hobby.Singing, Hobby.Books }
                }
            },
            
            #endregion

            #region Level#6 Easy

            new Level
            {
                TableNumber = 5,
                Time = 60,
                Target = 11,
                TablePositions = new List<Vector2>
                {
                    new Vector2(-280, 80), new Vector2(280, 80), new Vector2(0, -120), new Vector2(-440, -260), new Vector2(440, -260)
                },
                MaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Animals, Hobby.Bicycle, Hobby.Food, Hobby.Games, Hobby.Fashion },
                    new List<Hobby> { Hobby.Food, Hobby.Music, Hobby.Work, Hobby.Books, Hobby.Fashion, Hobby.Fishing, Hobby.Pictures, Hobby.Beauty },
                    new List<Hobby> { Hobby.Fashion, Hobby.Jewelry, Hobby.Games, Hobby.Books, Hobby.TV, Hobby.Archery },
                    new List<Hobby> { Hobby.Games, Hobby.Jewelry, Hobby.Pictures },
                    new List<Hobby> { Hobby.Drink, Hobby.Football, Hobby.Beauty, Hobby.TV },
                },
                FemaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Beauty, Hobby.Football, Hobby.TV, Hobby.Jewelry, Hobby.Running, Hobby.Money, Hobby.Archery },
                    new List<Hobby> { Hobby.Cars, Hobby.Money, Hobby.Photo, Hobby.Games, Hobby.Food, Hobby.Archery, Hobby.Jewelry, Hobby.Dancing },
                    new List<Hobby> { Hobby.Sex, Hobby.Pictures, Hobby.Music, Hobby.Cars },
                    new List<Hobby> { Hobby.Food, Hobby.TV, Hobby.Fishing, Hobby.Drink, Hobby.Animals, Hobby.Photo, Hobby.Music },
                    new List<Hobby> { Hobby.Fashion, Hobby.Sex, Hobby.Archery, Hobby.Football, Hobby.Singing, Hobby.Money, Hobby.Music }
                }
            },
            
            #endregion

            #region Level#7 Hard

            new Level
            {
                TableNumber = 5,
                Time = 120,
                Target = 12,
                TablePositions = new List<Vector2>
                {
                    new Vector2(-280, 80), new Vector2(280, 80), new Vector2(0, -120), new Vector2(-440, -260), new Vector2(440, -260)
                },
                MaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Bicycle, Hobby.Flowers, Hobby.Singing, Hobby.Sex, Hobby.Music, Hobby.Animals, Hobby.Books, Hobby.Games },
                    new List<Hobby> { Hobby.Jewelry, Hobby.Fishing, Hobby.Games, Hobby.Running, Hobby.Animals, Hobby.Money, Hobby.Music, Hobby.Pictures },
                    new List<Hobby> { Hobby.Music, Hobby.Animals, Hobby.Fashion, Hobby.Singing },
                    new List<Hobby> { Hobby.Fishing, Hobby.Games, Hobby.Dancing },
                    new List<Hobby> { Hobby.Dancing, Hobby.Flowers, Hobby.Work, Hobby.Money, Hobby.Fashion },
                },
                FemaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Games, Hobby.Books, Hobby.Money, Hobby.Running },
                    new List<Hobby> { Hobby.Beauty, Hobby.Fishing, Hobby.Cars, Hobby.Singing, Hobby.Dancing, Hobby.Fashion },
                    new List<Hobby> { Hobby.Beauty, Hobby.Sex, Hobby.Dancing, Hobby.Football, Hobby.Flowers, Hobby.Games, Hobby.Food, Hobby.Fishing },
                    new List<Hobby> { Hobby.Animals, Hobby.Music, Hobby.Books, Hobby.Cars, Hobby.Pictures, Hobby.Dancing, Hobby.Photo },
                    new List<Hobby> { Hobby.Beauty, Hobby.Sex, Hobby.TV, Hobby.Animals, Hobby.Cars, Hobby.Drink }
                }
            },
            
            #endregion

            #region Level#8

            new Level
            {
                TableNumber = 6,
                Time = 120,
                Target = 14,
                TablePositions = new List<Vector2>
                {
                    new Vector2(-180, 100), new Vector2(180, 100),
                    new Vector2(-520, -60), new Vector2(520, -60),
                    new Vector2(-240, -260), new Vector2(240, -260)
                },
                MaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Sex, Hobby.Fashion, Hobby.Music, Hobby.Flowers, Hobby.Work, Hobby.Drink, Hobby.Animals },
                    new List<Hobby> { Hobby.TV, Hobby.Flowers, Hobby.Photo },
                    new List<Hobby> { Hobby.Books, Hobby.Photo, Hobby.Singing, Hobby.Drink },
                    new List<Hobby> { Hobby.Cars, Hobby.Photo, Hobby.Games, Hobby.Singing },
                    new List<Hobby> { Hobby.Archery, Hobby.Music, Hobby.Cars, Hobby.Work, Hobby.Fishing },
                    new List<Hobby> { Hobby.Fashion, Hobby.Beauty, Hobby.Work, Hobby.Books, Hobby.Pictures, Hobby.TV, Hobby.Jewelry }
                },
                FemaleHobbies = new List<List<Hobby>>
                {
                    new List<Hobby> { Hobby.Photo, Hobby.Flowers, Hobby.Fashion, Hobby.Sex, Hobby.Books, Hobby.Cars, Hobby.Jewelry, Hobby.Dancing },
                    new List<Hobby> { Hobby.Beauty, Hobby.Books, Hobby.Animals, Hobby.Music, Hobby.Jewelry, Hobby.Food },
                    new List<Hobby> { Hobby.Singing, Hobby.Cars, Hobby.Animals, Hobby.Music },
                    new List<Hobby> { Hobby.Running, Hobby.Flowers, Hobby.Work, Hobby.Archery, Hobby.Sex, Hobby.Jewelry },
                    new List<Hobby> { Hobby.Beauty, Hobby.Dancing, Hobby.Music, Hobby.Games, Hobby.Money, Hobby.Photo, Hobby.Jewelry, Hobby.TV },
                    new List<Hobby> { Hobby.Jewelry, Hobby.Pictures, Hobby.Bicycle, Hobby.Music, Hobby.Dancing, Hobby.Cars }
                }
            },
            
            #endregion

            //#region Level#7

            //new Level
            //{
            //    Number = 7,
            //    TableNumber = 7,
            //    Time = 300,
            //    TablePositions = new List<Vector2>
            //    {
            //        new Vector2(-240, 100), new Vector2(240, 100),
            //        new Vector2(-520, -60), new Vector2(0, -60), new Vector2(520, -60),
            //        new Vector2(-280, -260), new Vector2(280, -260)
            //    },
            //    Generator = true,
            //    TableScale = 0.65f,
            //    MaleHobbies = new List<List<Hobby>>(),
            //    FemaleHobbies = new List<List<Hobby>>()
            //}
            
            //#endregion
        };
    }
}