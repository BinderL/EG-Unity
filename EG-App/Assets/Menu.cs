/*============================================================================== 
Copyright (c) 2017 PTC Inc. All Rights Reserved.

Menu  
==============================================================================*/

using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    #region PUBLIC_MEMBERS
    public Text aboutText;
    #endregion //PUBLIC_MEMBERS


    #region PRIVATE_MEMBERS
    Button[] buttons;
    Canvas[] canvas_var;
    #endregion //PRIVATE_MEMBERS


    #region PUBLIC_METHODS
    /*public void OnStartFullScreen(bool willRunFullScreen)
    {
        TransitionManager.isFullScreenMode = willRunFullScreen;
        LoadNextScene();
    }*/
    #endregion // PUBLIC_METHODS


    #region PRIVATE_METHODS
    void LoadNextScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }
    #endregion //PRIVATE_METHODS


    #region MONOBEHAVIOUR_METHODS

    void Start()
    {
        buttons = FindObjectsOfType<Button>();
        canvas_var = FindObjectsOfType<Canvas>();

        canvas_var[0].enabled = false;

        UpdateAboutText();
    }

    public void message_popup()
    {
        canvas_var[0].enabled=true;
    }

    void Update()
    {
#if UNITY_ANDROID
        // On Android, the Back button is mapped to the Esc key
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // Exit app
            Application.Quit();
        }
#endif
    }
    #endregion // MONOBEHAVIOUR_METHODS


    void LateUpdate()
    {

    }

    void UpdateAboutText()
    {
        if (!aboutText) return;

        string about =
            "\n<size=26>Enigme:</size>" +
            "\nUn  simple exemple ce que peux donner la réalité virtuelle, et ce projet a pour but de pouvoir l'utiliser dans un environnement d'escape game" +
            "\n";

        aboutText.text = about;

    }

}



