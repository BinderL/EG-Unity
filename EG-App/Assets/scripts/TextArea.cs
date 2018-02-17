using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextArea : MonoBehaviour
{

    [TextArea]
    public string réponse = "4";
    public string stringToEdit = "Réponse?";
    public Canvas youWin;
    void OnGUI()
    {
        stringToEdit = GUI.TextArea(new Rect(10, 10, 200, 100), stringToEdit, 200);
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if ( stringToEdit == réponse)
        {
            youWin.enabled = true;
        }

    }
}
