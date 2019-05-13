﻿using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Audio;

public class InGameHandler : MonoBehaviour {

    public AudioMixer audioMixer;
    public GUI_Master gui;

    public static NetworkTools networkTools;
    public static SceneHandler sceneHandler;
    public static AudioHandler audioHandler;
    public static GUIHandler guiHandler;
    public static LanguageHandler languageHandler;
    public static SettingsHandler settingsHandler;

	void Awake () {
        networkTools = new NetworkTools();
        sceneHandler = new SceneHandler();
        audioHandler = new AudioHandler(audioMixer);
        guiHandler = new GUIHandler(gui);
        languageHandler = new LanguageHandler(LanguageHandler.Language.english);
        settingsHandler = new SettingsHandler();
	}

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            guiHandler.PromptMenu(GUIHandler.GUIMenu.Options);
        }
    }

    #region AudioHandler

    public void SetVolume(AudioHandler.AudioChannel channel, float newVolume)
    {
        switch (channel)
        {
            case AudioHandler.AudioChannel.Master:
                audioHandler.SetOverallVolume(newVolume);
                break;
            case AudioHandler.AudioChannel.AX:
                audioHandler.SetAmbientVolume(newVolume);
                break;
            case AudioHandler.AudioChannel.MX:
                audioHandler.SetMusicVolume(newVolume);
                break;
            case AudioHandler.AudioChannel.SFX:
                audioHandler.SetSFXVolume(newVolume);
                break;
            case AudioHandler.AudioChannel.DX:
                audioHandler.SetDialogueVolume(newVolume);
                break;
        }
    }

    #endregion

    #region GUI

    public void PromptMenu(GUIHandler.GUIMenu menu)
    {
        guiHandler.PromptMenu(menu);
    }

    #endregion

    #region Language

    public static string Language_GetString(string key)
    {
        return languageHandler == null ? "" : languageHandler.GetString(key);
    }

    public static void Language_SetLanguage(LanguageHandler.Language language)
    {
        languageHandler.SetLanguage(language);
    }

    public static void Language_RegisterLanguageString(LanguageString languageString)
    {
        languageHandler.RegisterLanguageString(languageString);
    }

    public static LanguageHandler.Language Language_GetCurrentLanguage()
    {
        return languageHandler.GetCurrentLanguage();
    }

    #endregion

    #region Network

    public static bool Network_Authenticate()
    {
        //Thread.Sleep(1000);
        return true;
    }

    #endregion

    #region Settings

    public static bool Settings_GetUseMilitaryTime()
    {
        return settingsHandler.useMilitaryTime;
    }

    public static CurrentClothingSettings Settings_GetCurrentClothingSettings()
    {
        return settingsHandler.currentClothingSettings;
    }

    #endregion
}
