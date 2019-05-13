using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.UI;

public class MainMenuScript : MonoBehaviour
{
    public static MainMenuScript mainMenuScript;

    private enum State
    {
        Preparing, MainMenu, Login, Connecting, Info, Options, Game, LanguageSelection
    }

    [Header("Variables")]
    public float prepareTime;
    public float zoomInTime;

    [Header("Menu Elements")]
    public RectTransform titlePivot;
    public RectTransform mainMenuPivot;
    public RectTransform loginPivot;
    public RectTransform connectingPivot;
    public RectTransform infoPivot;
    public RectTransform optionsPivot;
    public RectTransform languageSelectionPivot;

    [Header("Language")]
    public Button languageButton;
    public Button languageChoice_english;
    public Button languageChoice_japanese;
    public Button languageChoice_norwegian;

    [Header("Faders")]
    public float faderFadeTime;
    public Image whiteout;
    private bool whiteout_on;
    public Image blackout;
    private bool blackout_on;

    private bool preparing;
    private State state;

    private void Awake()
    {
        if(mainMenuScript == null)
        {
            mainMenuScript = this;
        }
        else
        {
            Destroy(gameObject);
        }

        //whiteout.color = new Color(1.0f, 1.0f, 1.0f, 0.0f);
        //blackout.color = new Color(0.0f, 0.0f, 0.0f, 0.0f);
    }

    void Update()
    {
        //blackout.color = Color.Lerp(blackout.color, new Color(0.0f, 0.0f, 0.0f, blackout_on ? 1.0f : 0.0f), Time.deltaTime * faderFadeTime);
        //whiteout.color = Color.Lerp(whiteout.color, new Color(1.0f, 1.0f, 1.0f, whiteout_on ? 1.0f : 0.0f), Time.deltaTime * faderFadeTime);

        switch (state)
        {
            case State.Preparing:
                titlePivot.position = new Vector3(0.0f, Screen.height, mainMenuPivot.position.z);
                mainMenuPivot.position = Vector3.Lerp(mainMenuPivot.position, new Vector3(Screen.width, Screen.height, mainMenuPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                loginPivot.position = Vector3.Lerp(loginPivot.position, new Vector3(Screen.width, loginPivot.position.y, loginPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                connectingPivot.position = Vector3.Lerp(connectingPivot.position, new Vector3(Screen.width, connectingPivot.position.y, connectingPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                infoPivot.position = Vector3.Lerp(infoPivot.position, new Vector3(-Screen.width, infoPivot.position.y, infoPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                optionsPivot.position = Vector3.Lerp(optionsPivot.position, new Vector3(-Screen.width, optionsPivot.position.y, optionsPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                languageSelectionPivot.position = Vector3.Lerp(languageSelectionPivot.position, new Vector3(-Screen.width, languageSelectionPivot.position.y, languageSelectionPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                break;
            case State.MainMenu:
                mainMenuPivot.position = Vector3.Lerp(mainMenuPivot.position, new Vector3(0.0f, Screen.height, mainMenuPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                loginPivot.position = Vector3.Lerp(loginPivot.position, new Vector3(Screen.width, loginPivot.position.y, loginPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                infoPivot.position = Vector3.Lerp(infoPivot.position, new Vector3(-Screen.width, infoPivot.position.y, infoPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                optionsPivot.position = Vector3.Lerp(optionsPivot.position, new Vector3(-Screen.width, optionsPivot.position.y, optionsPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                //loginPivot.localEulerAngles = Vector3.Slerp(loginPivot.localEulerAngles, new Vector3(0.0f, 90.0f, 0.0f), Time.deltaTime * prepareTime * 5.0f);
                break;
            case State.Login:
                mainMenuPivot.position = Vector3.Lerp(mainMenuPivot.position, new Vector3(-Screen.width, mainMenuPivot.position.y, mainMenuPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                loginPivot.position = Vector3.Lerp(loginPivot.position, new Vector3(0.0f, loginPivot.position.y, loginPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                connectingPivot.position = Vector3.Lerp(connectingPivot.position, new Vector3(Screen.width, connectingPivot.position.y, connectingPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                //loginPivot.localEulerAngles = Vector3.Slerp(loginPivot.localEulerAngles, new Vector3(0.0f, 0.0f, 0.0f), Time.deltaTime * prepareTime * 5.0f);
                break;
            case State.Connecting:
                loginPivot.position = Vector3.Lerp(loginPivot.position, new Vector3(-Screen.width, loginPivot.position.y, loginPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                connectingPivot.position = Vector3.Lerp(connectingPivot.position, new Vector3(0.0f, connectingPivot.position.y, connectingPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                break;
            case State.Info:
                mainMenuPivot.position = Vector3.Lerp(mainMenuPivot.position, new Vector3(mainMenuPivot.position.x, 0.0f, mainMenuPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                infoPivot.position = Vector3.Lerp(infoPivot.position, new Vector3(0.0f, infoPivot.position.y, infoPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                break;
            case State.LanguageSelection:
                optionsPivot.position = Vector3.Lerp(optionsPivot.position, new Vector3(Screen.width, optionsPivot.position.y, optionsPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                languageSelectionPivot.position = Vector3.Lerp(languageSelectionPivot.position, new Vector3(0.0f, languageSelectionPivot.position.y, languageSelectionPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                break;
            case State.Options:
                languageSelectionPivot.position = Vector3.Lerp(languageSelectionPivot.position, new Vector3(-Screen.width, languageSelectionPivot.position.y, languageSelectionPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                mainMenuPivot.position = Vector3.Lerp(mainMenuPivot.position, new Vector3(Screen.width, Screen.height, mainMenuPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                optionsPivot.position = Vector3.Lerp(optionsPivot.position, new Vector3(0.0f, optionsPivot.position.y, optionsPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                break;
            case State.Game:
                connectingPivot.position = Vector3.Lerp(connectingPivot.position, new Vector3(-Screen.width, connectingPivot.position.y, connectingPivot.position.z), Time.deltaTime * prepareTime * 5.0f);
                break;
        }
    }

    public void GoToPreparing()
    {
        state = State.Preparing;
        GetComponent<PlayableDirector>().Play();
    }

    public void GoToLogin()
    {
        state = State.Login;
        StopCoroutine("Connect");
    }

    public void GoToMainMenu()
    {
        state = State.MainMenu;
    }

    public void GoToConnect()
    {
        state = State.Connecting;
        StartCoroutine("Connect");
    }

    public void GoToInfo()
    {
        state = State.Info;
    }

    public void GoToLanguageSelection()
    {
        state = State.LanguageSelection;
        RefreshLanguageButtons(GetCurrentLanguageString());
    }

    public void GoToOptions()
    {
        state = State.Options;
        languageButton.GetComponentInChildren<Text>().text = GetCurrentLanguageString();
    }

    public void GoToGame()
    {
        state = State.Game;
        StartCoroutine("FadeOutAndStartGame");
    }

    public void SetStateToInGame()
    {
        state = State.Game;
        titlePivot.position = new Vector3(Screen.width, Screen.height, mainMenuPivot.position.z);
    }

    private string GetCurrentLanguageString()
    {
        switch (InGameHandler.Language_GetCurrentLanguage())
        {
            case LanguageHandler.Language.english:
                return "English";
            case LanguageHandler.Language.japanese:
                return "Japanese";
            case LanguageHandler.Language.norwegian:
                return "Norwegian";
        }

        return "";
    }

    private void RefreshLanguageButtons(string language)
    {
        languageChoice_english.interactable = !language.Equals("English");
        languageChoice_japanese.interactable = !language.Equals("Japanese");
        languageChoice_norwegian.interactable = !language.Equals("Norwegian");
    }

    public void ChangeLanguage(string language)
    {
        RefreshLanguageButtons(language);

        if (!languageChoice_english.interactable)
        {
            InGameHandler.Language_SetLanguage(LanguageHandler.Language.english);
        }
        else if (!languageChoice_japanese.interactable)
        {
            InGameHandler.Language_SetLanguage(LanguageHandler.Language.japanese);
        }
        else if (!languageChoice_norwegian.interactable)
        {
            InGameHandler.Language_SetLanguage(LanguageHandler.Language.norwegian);
        }
    }

    IEnumerator Connect()
    {
        //InGameHandler.Network_Authenticate();
        yield return new WaitForSeconds(3.0f);
        GoToGame();
    }

    IEnumerator FadeOutAndStartGame()
    {
        yield return new WaitForSeconds(0.5f);
        whiteout_on = true;

        while (whiteout.color.a < 0.99f)
        {
            yield return new WaitForEndOfFrame();
        }

        blackout.color = new Color(0.0f, 0.0f, 0.0f, 1.0f);
        blackout_on = true;
        whiteout_on = false;

        while (whiteout.color.a > 0.01f)
        {
            yield return new WaitForEndOfFrame();
        }
    }
}
