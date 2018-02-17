using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class AudioControler : MonoBehaviour {

    public vb_anim_leaf chest;
    private AudioSource MusicControl = new AudioSource();
    public AudioClip Zelda;
    public DefaultTrackableEventHandler mDefaultTrackableEventHandler;

    // Use this for initialization
    void Start () {
        mDefaultTrackableEventHandler = GetComponent<DefaultTrackableEventHandler>();



    }
    // Update is called once per frame
    void Update () {
        if (chest == true)
        {
            MusicControl.PlayOneShot(Zelda);
            Debug.Log("musique playing");
        }
        //else
            //MusicControl.Pause();
    }
    void OnEnable()
    {
        print("script was enabled");
    }
}
