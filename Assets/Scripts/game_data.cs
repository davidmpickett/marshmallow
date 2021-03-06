﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public static class game_data
{
    public class Achievement
    {
        public string Name { get; set; }
        //public float N { get; set; }
        //public float S { get; set; }
        public bool Earned { get; set; }
    }

    private static Dictionary<int, Achievement> achievement_dict = new Dictionary<int, Achievement>() {
        {0,  new Achievement{Name="Dark Side", Earned=false } },
        {1,  new Achievement{Name="Good & Golden", Earned=false } },
        {2,  new Achievement{Name="UnRoasted", Earned=false } },
        {3,  new Achievement{Name="Completely Charred", Earned=false } }
    };

    public static Dictionary<int, Achievement> AchievementDict
    {
        get
        {
            return achievement_dict;
        }
    }
}
