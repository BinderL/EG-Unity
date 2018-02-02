using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioControler : MonoBehaviour {

    public vb_anim_leaf chest;
    private AudioSource MusicControl = new AudioSource();
    public AudioClip Zelda;

	// Use this for initialization
	void Start () {
  

    }
	
	// Update is called once per frame
	void Update () {
        if (chest.active==true)
        {
            MusicControl.PlayOneShot(Zelda);
            Debug.Log("musique playing");
        }
        else
            MusicControl.Pause();
    }
}
