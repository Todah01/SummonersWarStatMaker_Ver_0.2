﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Accuracy : rune_set_class
{
    public override void InitSetting()
    {
        rune_data.name = "Accuracy";
        rune_data.rune_count = 0;
        rune_data.isAncient = true;
    }
    public override int get_set_effect(int data)
    {
        return 10;
    }
}