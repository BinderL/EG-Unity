using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObj;
	public Animator ballAni;

	// Use this for initialization
	void Start () {
		vbBtnObj = GameObject.Find ("Natoobtn");
		vbBtnObj.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		ballAni.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){
		ballAni.Play ("ball_animation");
		Debug.Log ("ON");
	}
	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){
		ballAni.Play ("none");
		Debug.Log ("OFF");
	}
}
