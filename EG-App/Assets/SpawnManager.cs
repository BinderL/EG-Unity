using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpawnManager : MonoBehaviour {

    public string title;
    public string msg;
    public string time;
    public string solution;

    // Use this for initialization
    void Start () {
        GameObject stadium = GameObject.FindGameObjectWithTag("Enigme1");
        transform.SetParent(stadium.transform, false);
        Vb_anim_leaf Bouton = GetComponentInParent<Vb_anim_leaf>();
        Bouton.vbBtnObjLeaf = GameObject.FindGameObjectWithTag("Player");
        GameObject Animator = GameObject.FindGameObjectWithTag("GameController");
        Bouton.AnimatorObject = Animator;
        //Bouton.chesttopAni = Animator.GetComponent<Animator>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
