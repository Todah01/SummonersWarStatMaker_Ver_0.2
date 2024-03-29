﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class rune_slot_control : MonoBehaviour
{
    #region Public Variable
    public GameObject rune_data;
    public GameObject rune_img;
    public Sprite rune_selected_normal;
    public Sprite rune_selected_ancient;
    public int dropdown_value;
    public int rune_stat_value;
    public string rune_info;
    public string rune_stat_string;
    #endregion

    #region Local Variable
    Image self_img;
    Image rune_type_img;
    Color color;
    bool check_ancient;
    #endregion
    private void Awake()
    {
        self_img = this.GetComponent<Image>();
        rune_type_img = rune_img.GetComponent<Image>();
    }
    public void RuneSlotImgChange(bool isAncient)
    {
        if (rune_info == null) return;
        // Check ancient conversion of current rune type.
        check_ancient = rune_data.GetComponent<rune_control>().CheckAncientRune(rune_info);

        // Set ancient effect.
        if (check_ancient)
        {
            if (isAncient) self_img.sprite = rune_selected_ancient;
            else self_img.sprite = rune_selected_normal;
        }
    }
    public void rune_type_change(bool islegendary)
    {
        if(islegendary) ColorUtility.TryParseHtmlString("#FDAC51", out color);
        else ColorUtility.TryParseHtmlString("#E689F7", out color);

        rune_type_img.color = color;
    }
}
