using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapViewController : MonoBehaviour
{

    private MainMenuScript mainMenuScript;

    // Start is called before the first frame update
    void Start()
    {
        mainMenuScript = MainMenuScript.mainMenuScript;
        mainMenuScript.SetStateToInGame();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
