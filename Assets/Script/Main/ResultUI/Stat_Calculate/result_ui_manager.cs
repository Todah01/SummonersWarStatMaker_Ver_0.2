﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class result_ui_manager : MonoBehaviour
{
    #region Public Variable
    public GameObject selected_data;
    public GameObject result_calculate_manager;
    public Image monster_profile_img;
    public Sprite[] monster_imgs;
    public Text monster_name_txt;
    public Text[] base_monster_stats_txt;
    public Text[] plus_monster_stats_txt;
    public Text[] comp_monster_stats_txt;
    #endregion

    #region Local Variable
    string monster_name;
    List<int> base_monster_stats, plus_monster_stats, comp_monster_stats;
    #endregion
    public void Set_data_to_result_ui()
    {
        // Get monster name and set monster name.
        monster_name = selected_data.GetComponent<select_data_control>().selected_monster.text;
        monster_name_txt.text = monster_name;

        // Set monster profile img.
        string moneter_name_tolower = monster_name.ToLower();
        for (int i = 0; i < monster_imgs.Length; i++)
        {
            if (monster_imgs[i].name.ToLower().Contains(moneter_name_tolower))
            {
                monster_profile_img.sprite = monster_imgs[i];
                break;
            }
        }

        // Get monster stats.
        base_monster_stats = result_calculate_manager.GetComponent<result_calculate_manager>().divide_stats_cur;
        plus_monster_stats = result_calculate_manager.GetComponent<result_calculate_manager>().divide_stats_plus;
        comp_monster_stats = result_calculate_manager.GetComponent<result_calculate_manager>().comp_stats;


    }
}
