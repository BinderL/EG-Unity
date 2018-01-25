using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler {

	public GameObject vbBtnObjNatoo;
	public Animator ballAni;

	// Use this for initialization
	void Start () {
		vbBtnObjNatoo = GameObject.Find ("Natoobtn");
		vbBtnObjNatoo.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
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
