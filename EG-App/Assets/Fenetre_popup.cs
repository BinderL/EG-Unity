using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//public class WaitTimer : CustomYieldInstruction
//{
//    private float timeLeft;
//    private float lastTime;

//    public override bool keepWaiting
//    {
//        get
//        {
//            timeLeft -= Time.deltaTime;
//            return timeLeft > 0;
//        }
//    }

//    public WaitTimer(float time)
//    {
//        Reset(time);
//    }

//    public void Reset(float time = 0)
//    {
//        if (time == 0)
//        {
//            timeLeft = lastTime;
//        }
//        else
//        {
//            lastTime = timeLeft = time;
//        }
//    }
//}

public class Fenetre_popup : MonoBehaviour {

    //private WaitTimer clock;
    public Canvas affichage_popup_Rules;
    


    // Use this for initialization
    void Start() {
        affichage_popup_Rules.enabled = false;


    }

    // Update is called once per frame

    void Update()
    {
        //touch the screen to enable visible game object
        if (Input.touchCount > 2)
        {
            if (affichage_popup_Rules.enabled == false)
            {
                Debug.Log("popup");
                affichage_popup_Rules.enabled = true;
                //TouchScreenKeyboard.Open();
            }
            else
            {
                Debug.Log("not popup");
                affichage_popup_Rules.enabled = false;
            }
        }

        //slide in the screen to disable visible game object still not working
        //if (Input.touchCount > 0)
        //{
        //    if (Input.GetTouch(0).phase == TouchPhase.Moved)
        //    {
        //        Debug.Log("touch moved");
        //        if (affichage_popup.enabled == true)
        //        {
        //            affichage_popup.enabled = false;
        //        }
        //    }

            //}

            //touch the screen for detecting position of the screen
            //if (Input.touchCount > 0)
            //{
            //    foreach (Touch touch in Input.touches)
            //    {
            //        Debug.Log(touch.position);
            //    }
            //}

    }
}
