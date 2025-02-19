﻿using UnityEngine;

namespace Assets.Scripts.Views
{
    public class Menu : ViewBase
    {
        public GameObject DeluxeButton;

        public void ShowModes()
        {
            if (Current is Menu)
            {
                GetComponent<Mode>().Open();
            }
        }

        public void ShowShop()
        {
            if (Current is Menu || Current is Play)
            {
                GetComponent<Shop>().Open();
            }
        }

        public void ShowDeluxe()
        {
            if (Current is Menu)
            {
                GetComponent<Deluxe>().Open();
            }
        }

        public void Mute()
        {
            Profile.Mute = !Profile.Mute;
            GetComponent<AudioPlayer>().Refresh();
        }

        protected override void Initialize()
        {
            DeluxeButton.SetActive(!Profile.Deluxe);
        }
    }
}