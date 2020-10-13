﻿using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace BeatSaberMarkupLanguage.Components
{
    public class NotifiableSingleton<T> : PersistentSingleton<T>, INotifyPropertyChanged where T : MonoBehaviour
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            try
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            catch (Exception ex)
            {
                Logger.log?.Error($"Error Invoking PropertyChanged: {ex.Message}");
                Logger.log?.Error(ex);
            }
        }
    }
}
