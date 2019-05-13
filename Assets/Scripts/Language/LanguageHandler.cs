using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class LanguageHandler {

    private Language language;
    private Dictionary<string, string> dictionary;

    private List<LanguageString> allStrings;

    public LanguageHandler(Language language)
    {
        allStrings = new List<LanguageString>();

        LoadLanguage(language);
    }

    public void SetLanguage(Language language)
    {
        LoadLanguage(language);

        foreach(LanguageString languageString in allStrings)
        {
            languageString.ReloadString();
        }
    }

    public void RegisterLanguageString(LanguageString languageString)
    {
        allStrings.Add(languageString);
    }

    public void LoadLanguage(Language language)
    {
        this.language = language;
        dictionary = new Dictionary<string, string>();

        TextAsset lang = Resources.Load<TextAsset>("Languages/" + language.ToString());
        if (lang != null)
        {
            string[] allLines = lang.text.Split(new[] { System.Environment.NewLine }, System.StringSplitOptions.None);

            foreach(string line in allLines)
            {
                if(line.Contains("<SPACE>"))
                {
                    string[] lineElems = line.Split(new[] { " <SPACE> " }, System.StringSplitOptions.None);
                    dictionary.Add(lineElems[0], lineElems[1]);
                }
            }
        }
    }

    public Language GetCurrentLanguage()
    {
        return language;
    }

    public string GetString(string key)
    {
        if (dictionary.ContainsKey(key))
        {
            return dictionary[key];
        }
        else
        {
            Debug.LogWarning("The key '" + key + "' does not have an entry for the language '" + language + "'.");
            return "Missing Key";
        }
    }

    public enum Language
    {
        english, norwegian, japanese
    }

}
