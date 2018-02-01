using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class gestion_jeu : Singleton<gestion_jeu> {

    //Canvas[] canvas_var;

    public Canvas affichage_popup;

    public void Start()
    {
       // affichage_popup.transform.
        affichage_popup.enabled = false;

    }

    public void Update()
    {
        
    }

    protected gestion_jeu() {

    }

    public void popup(int numero)
    {
        Debug.Log("affichage popup");
        affichage_popup.enabled = true;
    }


}
