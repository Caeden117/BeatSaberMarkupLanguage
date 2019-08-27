﻿using BeatSaberMarkupLanguage.Parser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace BeatSaberMarkupLanguage.TypeHandlers
{
    public abstract class TypeHandler
    {
        public abstract Dictionary<string, string[]> Props
        {
            get;
        }

        public abstract void HandleType(Component obj, Dictionary<string, string> data, BSMLParserParams parserParams);
    }
    public class ComponentHandler : Attribute
    {
        public Type type;
        public ComponentHandler(Type type)
        {
            this.type = type;
        }
    }
}