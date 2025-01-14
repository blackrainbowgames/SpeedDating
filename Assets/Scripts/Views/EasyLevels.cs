﻿using System;
using System.Collections.Generic;
using System.Linq;
using Assets.Scripts.Common;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class EasyLevels : ViewBase
    {
        public int Page;
        private List<GameButton> _levelButtons;

        public void Awake()
        {
            _levelButtons = Panel.GetComponentsInChildren<GameButton>(true).Where(i => i.ListenerMethodUp == ListenerMethodUp).ToList();

            if (_levelButtons.Count == 0)
            {
                throw new Exception();
            }
        }

        protected override void Initialize()
        {
            Refresh();
        }

        protected virtual string ListenerMethodUp
        {
            get { return "PlayEasyLevel"; }
        }

        protected virtual int Progress
        {
            get { return Profile.ProgressEasy; }
        }

        protected virtual List<Level> LevelsList
        {
            get { return GameData.EasyLevels; }
        }

        public void Refresh()
        {
            var progress = Progress;

            for (var i = 0; i < _levelButtons.Count; i++)
            {
                var button = _levelButtons[i];
                var index = Page == 0 ? i : i + _levelButtons.Count;
                var exists = LevelsList.Count > index;

                button.gameObject.SetActive(exists);

                if (!exists) continue;

                var image = button.GetComponent<UITexture>();
                var text = button.GetComponentInChildren<UILabel>();
                
                button.Params = Convert.ToString(index);
                text.SetText(index + 1);

                button.Enabled = index <= progress || Settings.Debug;

                if (button.Enabled)
                {
                    button.Enabled = true;
                    image.mainTexture = Resources.Load<Texture2D>("Images/UI/LevelButton");
                    image.width = image.height = 128;
                }
                else
                {
                    if (LevelsList.Count > index)
                    {
                        image.mainTexture = Resources.Load<Texture2D>("Images/UI/LevelLockedButton");
                        image.width = image.height = 100;
                    }
                    else
                    {
                        button.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}