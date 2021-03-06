﻿// This source code is a part of Koromo Copy Project.
// Copyright (C) 2019. dc-koromo. Licensed under the MIT Licence.

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Koromo_Copy.Framework.Network
{
    public enum NetPriorityType
    {
        // ex) Download and save file, large data
        Low = 0,
        // ex) Download metadata, html file ...
        Trivial = 1,
        // Pause all processing and force download
        Emergency = 2,
    }

    public class NetPriority : IComparable<NetPriority>
    {
        [JsonProperty]
        public NetPriorityType Type { get; set; }
        [JsonProperty]
        public int TaskPriority { get; set; }

        public int CompareTo(NetPriority pp)
        {
            if (Type > pp.Type) return 1;
            else if (Type < pp.Type) return -1;

            return pp.TaskPriority.CompareTo(TaskPriority);
        }
    }
}
