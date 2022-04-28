﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuPlayerPrefs : MonoBehaviour
{
    public MenuController menuController;
    // All Main Menu parameters 
 
    private void Start()
    {
        menuController = GetComponent<MenuController>();
    }
    public void SaveHoverTime(float sliderValue)
    {
        PlayerPrefs.SetFloat("hovertime", sliderValue);
        PlayerPrefs.Save();
    }
    public void SaveTargetRadius(float sliderValue)
    {
        PlayerPrefs.SetFloat("targetradius", sliderValue);
        PlayerPrefs.Save();
    }
    public void SaveTargetHeight(int menuInt)
    {
        PlayerPrefs.SetInt("targetheight", menuInt);
        PlayerPrefs.Save();
    }
    public void SaveNumPaddles(int menuInt)
    {
        PlayerPrefs.SetInt("numpaddles", menuInt);
        PlayerPrefs.Save();
    }


    // Private methods to load PlayerPrefs into the menu. 

    private void LoadHoverTimeToMenu()
    {
        if (PlayerPrefs.HasKey("hovertime"))
        {
            menuController.UpdateHoverTime(PlayerPrefs.GetFloat("hovertime"));
        }
    }
    private void LoadTargetRadiusToMenu()
    {
        if (PlayerPrefs.HasKey("maxtrials"))
        {
            menuController.UpdateTargetRadius(PlayerPrefs.GetFloat("targetradius"));
        }
    }

    private void LoadTargetHeightToMenu()
    {
        if (PlayerPrefs.HasKey("targetheight"))
        {
            menuController.RecordTargetHeight(PlayerPrefs.GetInt("targetheight"));
        }
    }
    


    

    // Clears all saved main menu preferences
    public void ResetPlayerPrefs()
    {
        Debug.Log("Reset Menu Preferences");
        PlayerPrefs.DeleteAll();
        // TODO 
        // SetDefaultSettings();
    }
}
