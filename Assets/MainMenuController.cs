using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{

    private MainMenuScript mainMenuScript;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuScript = MainMenuScript.mainMenuScript;
        mainMenuScript.GoToPreparing();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
